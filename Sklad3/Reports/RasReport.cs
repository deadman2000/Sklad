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

        public RasReport(Ras doc)
        {
            _doc = doc;
            _rashod = DbSklad.Rashod.FindAll(r => r.Doc == doc).OrderBy(r => r.Tovar.Name).ToArray();
        }

        protected override string Template
        {
            get
            {
                return _doc.Type.Template; // TODO двухстраничный вариант
            }
        }

        int _offset = 0; // Позиция списка товаров
        int rowsPerAll; // Число строк во всех листах

        class RasSheet
        {
            public string Name;
            public int Count;
            public bool ColumnFill; // Заполнять колонками, иначе строчками
        }

        private List<RasSheet> _sheets = new List<RasSheet>();

        private void PrepareSheets()
        {
            foreach (var name in sl.GetSheetNames())
            {
                var s = PrepareSheet(name);
                if (s != null)
                    _sheets.Add(s);
            }

            rowsPerAll = _sheets.Sum(s => s.Count);
            if (rowsPerAll > _rashod.Length)
            {
                // TODO Копируем листы, пока их не начнет хватать
                //sl.CopyWorksheet(
            }
        }

        private RasSheet PrepareSheet(string name)
        {
            sl.SelectWorksheet(name);

            var n1 = FindCell("$NAME");
            var n2 = FindCell("$NAME_END");
            if (n1 == null || n2 == null) return null;

            sl.SetCellValue(n2.Row, n2.Col, ""); // Стираем ключи

            if (n1.Col == n2.Col)
            {
                return new RasSheet
                {
                    Name = name,
                    Count = n2.Row - n1.Row,
                    ColumnFill = true
                };
            }

            if (n1.Row == n2.Row)
            {
                return new RasSheet
                {
                    Name = name,
                    Count = n2.Col - n1.Col,
                    ColumnFill = false
                };
            }

            return null;
        }


        protected override void FillContent()
        {
            PrepareSheets();

            foreach (var s in _sheets)
                FillSheet(s);
        }

        private RasSheet _currentSheet;

        private void FillSheet(RasSheet sheet)
        {
            _currentSheet = sheet;
            sl.SelectWorksheet(sheet.Name);

            int sheetCount = (int)Math.Round((double)_rashod.Length / sheet.Count + 0.5); // Число страниц
            // TODO Коипрование листов

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

            ReplaceCells("$TOTAL_SUM", sum);
            ReplaceCells("$TOTAL_SUM_NAME", RuDateAndMoneyConverter.CurrencyToTxt(sum, false));

            ReplaceCells("$TOTAL_COUNT", count);
            ReplaceCells("$TOTAL_COUNT_NAME", RuDateAndMoneyConverter.NumeralsToTxt(count, TextCase.Nominative, true, false));

            _offset += sheet.Count;
        }

        delegate object ValueExpression(SklRs r);

        private void FillTable(string field, ValueExpression func)
        {
            while (true)
            {
                var n1 = FindCell("$" + field);
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

            }        }
    }
}
