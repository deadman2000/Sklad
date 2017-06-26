using Sklad3.Reports;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklad3.Objects
{
    public class RasDocPattern
    {
        public static readonly RasDocPattern[] Patterns = new RasDocPattern[]
            {
                new RasDocPattern(0, "Списание нефинансовых активов", "rs_0504104"),
                new RasDocPattern(1, "Списание мягкого и хозяйственного инвентаря", "rs_0504143"),
                new RasDocPattern(2, "Списание материальных запасов", "rs_0504230", "rs_0504230_2"),
                //new RasDocPattern(3, "Прием-передача нефинансовых активов", "rs_0504101"),
                new RasDocPattern(4, "Накладная на внутреннее перемещение", "rs_0504102"),
                new RasDocPattern(5, "Требование-накладная", "rs_0504204", "rs_0504204_2")
            };

        private static readonly Dictionary<int, RasDocPattern> _byId = Patterns.ToDictionary(p => p._id, p => p);

        public static RasDocPattern ById(int id)
        {
            RasDocPattern p;
            if (_byId.TryGetValue(id, out p)) return p;
            return null;
        }

        private RasDocPattern(int id, string name, params string[] templates)
        {
            _id = id;
            _name = name;
            _templates = templates;
        }

        private int _id;
        public int Id => _id;

        private string[] _templates;

        private string _name;
        public string Name => _name;

        public override string ToString() => _name;

        private RasBook[] _books;

        private RasBook[] GetBooks()
        {
            if (_books == null)
            {
                _books = new RasBook[_templates.Length];
                for (int i = 0; i < _templates.Length; i++)
                {
                    _books[i] = new RasBook(_templates[i]);
                }
                _books = _books.OrderBy(b => b.TotalCount).ToArray();
            }

            return _books;
        }

        public RasBook GetBook(int count)
        {
            return GetBooks().First(b => b.TotalCount > count) ?? GetBooks().Last();
        }
    }

    public class RasBook
    {
        public readonly string FileName;
        public readonly int TotalCount;
        public readonly RasSheet[] BaseSheets;

        public RasBook(string fileName)
        {
            FileName = fileName;

            int cnt = 0;
            List<RasSheet> sheets = new List<RasSheet>();
            using (SLDocument sl = new SLDocument("templates/" + fileName + ".xlsx"))
            {
                foreach (var name in sl.GetSheetNames())
                {
                    var s = PrepareSheet(sl, name);
                    if (s != null)
                    {
                        sheets.Add(s);
                        cnt += s.Count;
                    }
                }
            }
            BaseSheets = sheets.ToArray();
            TotalCount = cnt;
        }

        public List<RasSheet> GetSheets(SLDocument sl, int count)
        {
            List<RasSheet> sheets = new List<RasSheet>(BaseSheets);

            int rowsPerAll = sheets.Sum(s => s.Count);  // Число строк во всех листах
            if (rowsPerAll < count)
            {
                int cnt = (int)Math.Round((double)count / rowsPerAll + 0.5);
                List<RasSheet> originals = new List<RasSheet>(sheets);
                var init = sl.GetCurrentWorksheetName();
                sl.AddWorksheet("blank");
                sl.SelectWorksheet("blank");
                for (int i = 1; i < cnt; i++)
                {
                    foreach (var s in originals)
                    {
                        string newname = s.Name + "_" + i;
                        sl.CopyWorksheet(s.Name, newname);
                        sheets.Add(new RasSheet
                        {
                            Name = newname,
                            Count = s.Count,
                            ColumnFill = s.ColumnFill
                        });
                    }
                }
                sl.SelectWorksheet(init);
                sl.DeleteWorksheet("blank");
            }
            return sheets;
        }

        private RasSheet PrepareSheet(SLDocument sl, string name)
        {
            sl.SelectWorksheet(name);

            var n1 = sl.FindCell("$NAME");
            var n2 = sl.FindCell("$NAME_END");
            if (n1 == null || n2 == null) return null;

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
    }

    public class RasSheet
    {
        public string Name;
        public int Count;
        public bool ColumnFill; // Заполнять колонками, иначе строчками
    }
}
