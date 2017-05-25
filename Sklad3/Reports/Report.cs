using Sklad3.Properties;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Sklad3.Reports
{
    abstract class Report
    {
        protected static readonly NumberFormatInfo nfi_money = new NumberFormatInfo
        {
            NumberDecimalSeparator = "-",
            NumberDecimalDigits = 2,
            NumberGroupSeparator = ""
        };

        protected SLDocument sl;

        static void PrepareFolder()
        {
            if (!Directory.Exists("reports"))
                Directory.CreateDirectory("reports");
        }

        public void Build()
        {
            PrepareFolder();

            var fileName = String.Format("reports/{0}_{1:ddMMyy_HHmmss}.xlsx", Template, DateTime.Now);

            using (sl = new SLDocument("templates/" + Template + ".xlsx"))
            {
                Prepare();
                FillContent();
                sl.SaveAs(fileName);
            }
            sl = null;

            Process.Start(Path.GetFullPath(fileName));
        }

        protected virtual void Prepare()
        {
            ReplaceCellValue("%PODR%", Settings.Default.Podrazd);
            ReplaceCellValue("%USERNAME%", Settings.Default.UserName);
            ReplaceCellValue("%MONTH%", DbSklad.CurrentMonth.ToString());
        }

        private void ReplaceCellValue(string from, string to)
        {
            foreach (var rows in sl.GetCells())
            {
                int row = rows.Key;
                foreach (var column in rows.Value)
                {
                    int col = column.Key;
                    var val = sl.GetCellValueAsString(row, col);
                    if (val.IndexOf(from) != -1)
                        sl.SetCellValue(row, col, val.Replace(from, to));
                }
            }
        }

        protected abstract void FillContent();

        protected abstract string Template { get; }
    }
}
