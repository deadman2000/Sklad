using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sklad3.Reports
{
    class MatReport : Report
    {
        private List<SklMoves> _moves;
        const int ROWS_PER_LIST = 14;
        const int START_ROW = 8;

        public MatReport(List<SklMoves> moves)
        {
            _moves = moves.Where(m => m.PrCount != 0 || m.RsCount != 0).OrderBy(m => m.Tovar.Name).ToList();
        }

        protected override string Template => "mat_rep";

        protected override void FillContent()
        {
            var listsCount = (int)Math.Round((double)_moves.Count / ROWS_PER_LIST + 0.5);

            var init = sl.GetCurrentWorksheetName();
            CopyLists(init, listsCount - 1);

            int ind = 0;
            for (int i = 0; i < listsCount; i++)
            {
                if (i == 0)
                    sl.SelectWorksheet(init);
                else
                    sl.SelectWorksheet(init + "_" + (i + 1));

                double totalNm = 0, totalRs = 0, totalPr = 0, totalKm = 0;

                for (int j = 0; j < ROWS_PER_LIST; j++)
                {
                    var m = _moves[ind];
                    var row = START_ROW + j;

                    sl.SetCellValue(row, 2, ind + 1);
                    sl.SetCellValue(row, 3, m.Tovar.NameWithInvn);
                    sl.SetCellValue(row, 4, m.Tovar.EdIsm.Name);
                    sl.SetCellValue(row, 5, m.Tovar.Price.ToString("N", nfi_money));
                    if (m.Nm != null)
                    {
                        sl.SetCellValue(row, 6, m.Nm.Count);
                        sl.SetCellValue(row, 7, m.NmSum.Value.ToString("N", nfi_money));
                    }
                    if (m.PrCount > 0)
                    {
                        sl.SetCellValue(row, 8, m.PrCount);
                        sl.SetCellValue(row, 9, m.PrSum.ToString("N", nfi_money));
                    }
                    if (m.RsCount > 0)
                    {
                        sl.SetCellValue(row, 10, m.RsCount);
                        sl.SetCellValue(row, 11, m.RsSum.ToString("N", nfi_money));
                    }
                    if (m.KmCount > 0)
                    {
                        sl.SetCellValue(row, 12, m.KmCount);
                        sl.SetCellValue(row, 13, m.KmSum.ToString("N", nfi_money));
                    }
                    sl.AutoFitRow(row);
                    Console.WriteLine("Autofit row");

                    totalNm += m.NmSum.GetValueOrDefault(0);
                    totalRs += m.RsSum;
                    totalPr += m.PrSum;
                    totalKm += m.KmSum;

                    ind++;
                    if (ind == _moves.Count) break;
                }

                int totalRow = START_ROW + ROWS_PER_LIST;

                if (totalNm > 0) sl.SetCellValue(totalRow, 7, totalNm.ToString("N", nfi_money));
                if (totalPr > 0) sl.SetCellValue(totalRow, 9, totalPr.ToString("N", nfi_money));
                if (totalRs > 0) sl.SetCellValue(totalRow, 11, totalRs.ToString("N", nfi_money));
                if (totalKm > 0) sl.SetCellValue(totalRow, 13, totalKm.ToString("N", nfi_money));

                //sl.AutoFitRow(START_ROW, START_ROW + ROWS_PER_LIST);

                //sl.AutoFitColumn(5, 13);
            }

            sl.SelectWorksheet(init);
        }
    }
}
