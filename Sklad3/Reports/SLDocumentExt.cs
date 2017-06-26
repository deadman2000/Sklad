using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklad3.Reports
{
    static class SLDocumentExt
    {
        public static bool SetCellValue(this SLDocument doc, int RowIndex, int ColumnIndex, object val)
        {
            if (val == null) return doc.SetCellValue(RowIndex, ColumnIndex, "");

            switch (Type.GetTypeCode(val.GetType()))
            {
                case TypeCode.Boolean:
                    return doc.SetCellValue(RowIndex, ColumnIndex, (bool)val);
                case TypeCode.Int32:
                    return doc.SetCellValue(RowIndex, ColumnIndex, (int)val);
                case TypeCode.Double:
                    return doc.SetCellValue(RowIndex, ColumnIndex, (double)val);
                case TypeCode.String:
                    return doc.SetCellValue(RowIndex, ColumnIndex, (string)val);

                default:
                    Console.WriteLine("Not implemented SetCellValue for " + val.GetType().Name);
                    return doc.SetCellValue(RowIndex, ColumnIndex, val.ToString());
            }
        }

        public static CellCoord FindCell(this SLDocument doc, string value)
        {
            foreach (var rows in doc.GetCells())
            {
                int row = rows.Key;
                foreach (var column in rows.Value)
                {
                    int col = column.Key;
                    var val = doc.GetCellValueAsString(row, col);
                    if (val == value)
                        return new CellCoord(row, col);
                }
            }
            return null;
        }
    }

    public class CellCoord
    {
        public int Row, Col;

        public CellCoord(int r, int c)
        {
            Row = r;
            Col = c;
        }
    }
}
