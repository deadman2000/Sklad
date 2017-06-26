using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklad3.Reports
{
    class RasReport : Report
    {
        private Ras _doc;
        private SklRs[] _rashod;
        private int _offset = 0; // Позиция списка товаров
        private RasBook _book;
        private List<RasSheet> _sheets;

        public RasReport(Ras doc)
        {
            _doc = doc;
            _rashod = DbSklad.Rashod.FindAll(r => r.Doc == doc).OrderBy(r => r.Tovar.Name).ToArray();
            _book = _doc.Type.GetBook(_rashod.Length);
        }

        protected override string Template => _book.FileName;

        protected override void FillContent()
        {
            _sheets = _book.GetSheets(sl, _rashod.Length);

            foreach (var s in _sheets)
                FillSheet(s);

            double sum = 0;
            int count = 0;
            foreach (var r in _rashod)
            {
                sum += r.TotalPrice;
                count += (int)r.Count;
            }

            ReplaceCells("$TOTAL_SUM", sum);
            ReplaceCells("$TOTAL_SUM_NAME", RuDateAndMoneyConverter.CurrencyToTxt(sum, false));

            ReplaceCells("$TOTAL_COUNT", count);
            ReplaceCells("$TOTAL_COUNT_NAME", RuDateAndMoneyConverter.NumeralsToTxt(count, TextCase.Nominative, true, false));
        }

        private RasSheet _currentSheet;

        private void FillSheet(RasSheet sheet)
        {
            _currentSheet = sheet;
            sl.SelectWorksheet(sheet.Name);

            ReplaceCells("$NAME_END", "");

            FillTable("IND", r => Array.IndexOf(_rashod, r) + 1);
            FillTable("NAME", r => r.Tovar.Name);
            FillTable("INVN", r => r.Tovar.Invn);
            FillTable("COUNT", r => r.Count);
            FillTable("EDISM", r => r.Tovar.EdIsm.Name);
            FillTable("PRICE", r => r.Tovar.Price);
            FillTable("SUM", r => r.TotalPrice);

            int c = Math.Min(sheet.Count, _rashod.Length - _offset);
            double sum = 0;
            int count = 0;
            for (int i = 0; i < c; i++)
            {
                var r = _rashod[_offset + i];
                sum += r.TotalPrice;
                count += (int)r.Count;
            }

            ReplaceCells("$SHEET_SUM", sum);
            ReplaceCells("$SHEET_SUM_NAME", RuDateAndMoneyConverter.CurrencyToTxt(sum, false));

            ReplaceCells("$SHEET_COUNT", count);
            ReplaceCells("$SHEET_COUNT_NAME", RuDateAndMoneyConverter.NumeralsToTxt(count, TextCase.Nominative, true, false));

            _offset += sheet.Count;
        }

        delegate object ValueExpression(SklRs r);

        private void FillTable(string field, ValueExpression func)
        {
            while (true)
            {
                var n1 = sl.FindCell("$" + field);
                if (n1 == null) return;

                sl.SetCellValue(n1.Row, n1.Col, ""); // Стираем ключи

                if (_currentSheet.ColumnFill)
                {
                    for (int r = 0; r <= _currentSheet.Count; r++)
                    {
                        var i = _offset + r;
                        if (i >= _rashod.Length) break;

                        var rs = _rashod[i];
                        sl.SetCellValue(n1.Row + r, n1.Col, func(rs));
                    }
                }
                else
                {
                    for (int c = 0; c <= _currentSheet.Count; c++)
                    {
                        var i = _offset + c;
                        if (i >= _rashod.Length) break;

                        var rs = _rashod[i];
                        sl.SetCellValue(n1.Row, n1.Col + i, func(rs));
                    }
                }

            }
        }
    }
}
