using Sklad3.Objects;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Sklad3
{
    static class DbSklad
    {
        private const string FileName = "Sklad.db3";
        private const bool UseWal = true; // Для импорта

        private static SQLiteSafe _sqlite;

        public static SQLiteSafe SQL => _sqlite;

        #region Create / Init

        public static void Init()
        {
            _sqlite = new SQLiteSafe(FileName, UseWal);
            if (!File.Exists(FileName))
                CreateDataBase();
            UpdateDB();
        }

        public static void CreateNewDataBase()
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);

                // Make backup
                string name = "Sklad.bak";
                int i = 0;
                while (File.Exists(name))
                {
                    name = "Sklad_" + i + ".bak";
                    i++;
                }

                File.Move(FileName, name);
            }
            CreateDataBase();
            UpdateDB();
        }

        private static void CreateDataBase()
        {
            SQLiteConnection.CreateFile(FileName);
            _sqlite.ExecuteNonQuery(Properties.Resources.CreateDB);
        }

        private static void UpdateDB()
        {
            if (!CoumnExists("Tovar", "note"))
                _sqlite.ExecuteNonQuery("ALTER TABLE Tovar ADD COLUMN note TEXT NOT NULL DEFAULT('')");
        }

        private static bool CoumnExists(string tableName, string columnName)
        {
            var cmd = new SQLiteCommand("PRAGMA table_info('" + tableName + "')");
            var tbl = _sqlite.ExecuteTable(cmd);
            foreach (DataRow row in tbl.Rows)
            {
                var name = (string)row["name"];
                if (name.Equals(columnName)) return true;
            }
            return false;
        }

        #endregion

        #region Месяцы

        private static List<Month> _months;

        public static Month AddMonth(DateTime date)
        {
            var cmd = new SQLiteCommand("INSERT INTO Months(date) VALUES (@D); SELECT last_insert_rowid()");
            cmd.Parameters.AddWithValue("@D", date);
            var id = (int)(long)_sqlite.ExecuteScalar(cmd);
            var month = new Month(id, date);
            _months?.Add(month);
            return month;
        }

        public static List<Month> Months
        {
            get
            {
                if (_months != null) return _months;

                var tbl = _sqlite.ExecuteTable("SELECT * FROM Months ORDER BY date ASC");
                _months = new List<Month>(tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                    _months.Add(new Month(row));
                return _months;
            }
        }

        private static Month _month;
        public static Month CurrentMonth
        {
            get { return _month; }
            set
            {
                _month = value;
                Clear();
            }
        }

        public static Month NewMonth()
        {
            var last = _months.Last();
            CurrentMonth = last;

            List<SklNm> counts = new List<SklNm>(); // Остатки на начало следующего месяца
            foreach (var m in Sklad)
            {
                if (m.KmCount > 0)
                    counts.Add(new SklNm(m.Tovar, m.KmCount));
            }

            var date = last.Date.AddMonths(1).Date;
            CurrentMonth = AddMonth(date);
            foreach (var nm in counts)
            {
                AddMonthBeg(_month, nm.Tovar, nm.Count);
            }

            return CurrentMonth;
        }

        private static void Clear()
        {
            _monthBeg = null;
            _prihod = null;
            _rashod = null;
            _schFact = null;
            _schFactById = null;
            _rasDocs = null;
            _rasDocsById = null;
        }

        #endregion

        #region Товары

        private static List<Tovar> _tovars;
        private static Dictionary<int, Tovar> _tovarById;

        public static Tovar AddTovar(string name, EdIsm edIsm, double price, string invn, string nsch)
        {
            var cmd = new SQLiteCommand("INSERT INTO Tovar(name, id_edism, price, invn, nsch, isVisible) VALUES (@N, @EI, @P, @IN, @NS, 1); SELECT * FROM Tovar WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@N", name);
            cmd.Parameters.AddWithValue("@EI", edIsm.Id);
            cmd.Parameters.AddWithValue("@P", price);
            cmd.Parameters.AddWithValue("@IN", invn);
            cmd.Parameters.AddWithValue("@NS", nsch);
            var tbl = _sqlite.ExecuteTable(cmd);
            var tov = new Tovar(tbl.Rows[0]);
            _tovars?.Add(tov);
            _tovarById?.Add(tov.Id, tov);
            return tov;
        }

        public static List<Tovar> Tovars
        {
            get
            {
                if (_tovars != null) return _tovars;

                var tbl = _sqlite.ExecuteTable("SELECT * FROM Tovar WHERE isVisible=1 ORDER BY name");
                _tovars = new List<Tovar>(tbl.Rows.Count + 1);
                _tovarById = new Dictionary<int, Tovar>();
                foreach (DataRow row in tbl.Rows)
                {
                    var t = new Tovar(row);
                    _tovars.Add(t);
                    _tovarById.Add(t.Id, t);
                }
                return _tovars;
            }
        }

        public static List<string> TovNamesList()
        {
            return Tovars.Select(t => t.Name).Distinct().ToList();
        }

        public static Tovar GetTovar(int id)
        {
            if (Tovars == null) return null;

            Tovar t;
            _tovarById.TryGetValue(id, out t);
            return t;
        }

        public static void Replace(Tovar from, Tovar to)
        {
            foreach (var p in _prihod)
                if (p.Tovar == from) p.Tovar = to;
            foreach (var r in _rashod)
                if (r.Tovar == from) r.Tovar = to;
            foreach (var n in _monthBeg)
                if (n.Tovar == from) n.Tovar = to;
            foreach (var m in _moves)
                if (m.Tovar == from) m.Tovar = to;
        }

        public static List<string> NschList()
        {
            return _tovars.Select(t => t.Nsch).Distinct().ToList(); // .Where(s => s != null)
        }

        public static void Remove(Tovar tov)
        {
            _tovars.Remove(tov);
            _tovarById.Remove(tov.Id);
        }

        #endregion

        #region Единицы измерения

        private static List<EdIsm> _edIsm;
        private static Dictionary<int, EdIsm> _dictEdIsm;

        public static EdIsm AddEdIsm(string name)
        {
            var cmd = new SQLiteCommand("INSERT INTO EdIsm(name) VALUES (@NAME); SELECT last_insert_rowid()");
            cmd.Parameters.AddWithValue("@NAME", name);
            var id = (int)(long)_sqlite.ExecuteScalar(cmd);
            var edIsm = new EdIsm(id, name);
            _edIsm?.Add(edIsm);
            _dictEdIsm?.Add(edIsm.Id, edIsm);
            return edIsm;
        }

        public static List<EdIsm> EdIsm
        {
            get
            {
                if (_edIsm != null) return _edIsm;

                var tbl = _sqlite.ExecuteTable("SELECT id, name FROM EdIsm ORDER BY name");
                _edIsm = new List<EdIsm>(tbl.Rows.Count);
                _dictEdIsm = new Dictionary<int, EdIsm>();
                foreach (DataRow row in tbl.Rows)
                {
                    var it = new EdIsm(row);
                    _edIsm.Add(it);
                    _dictEdIsm.Add(it.Id, it);
                }
                return _edIsm;
            }
        }

        public static EdIsm GetEdIsm(int id)
        {
            if (EdIsm == null) return null;
            return _dictEdIsm[id];
        }

        public static void Replace(EdIsm from, EdIsm to)
        {
            foreach (var t in _tovars)
                if (t.EdIsm == from) t.EdIsm = to;
        }

        public static void Remove(EdIsm edIsm)
        {
            _edIsm.Remove(edIsm);
            _dictEdIsm.Remove(edIsm.Id);
        }

        #endregion

        #region Предприятия

        private static List<Predpr> _predpr;
        private static Dictionary<int, Predpr> _predprById;

        public static Predpr GetPredp(int id)
        {
            if (Predp == null) return null;
            return _predprById[id];
        }

        public static List<Predpr> Predp
        {
            get
            {
                if (_predpr != null) return _predpr;

                var tbl = _sqlite.ExecuteTable("SELECT id, name FROM Predpr ORDER BY name");
                _predpr = new List<Predpr>(tbl.Rows.Count);
                _predprById = new Dictionary<int, Predpr>();
                foreach (DataRow row in tbl.Rows)
                {
                    var it = new Predpr((int)(long)row["id"], (string)row["name"]);
                    _predpr.Add(it);
                    _predprById.Add(it.Id, it);
                }
                return _predpr;
            }
        }

        public static Predpr GetPredp(string name)
        {
            var it = Predp.Find(i => i.Name == name);
            if (it != null) return it;

            var cmd = new SQLiteCommand("INSERT INTO Predpr(name) VALUES (@name); SELECT last_insert_rowid()");
            cmd.Parameters.AddWithValue("@name", name);
            var id = (int)(long)_sqlite.ExecuteScalar(cmd);
            it = new Predpr(id, name);
            _predpr.Add(it);
            _predprById.Add(id, it);
            return it;
        }

        public static void Replace(Predpr from, Predpr to)
        {
            foreach (var i in _schFact)
                if (i.Predp == from) i.Predp = to;

            var cmd = new SQLiteCommand("UPDATE SchFact SET id_predpr=@T WHERE id_predpr=@T");
            cmd.Parameters.AddWithValue("@F", from.Id);
            cmd.Parameters.AddWithValue("@T", to.Id);
            _sqlite.ExecuteNonQuery(cmd);
        }

        #endregion

        #region Должностные лица

        private static List<People> _doljList;

        public static People GetDolj(string name)
        {
            var dolj = Dolj.Find(d => d.Name.Equals(name));
            if (dolj != null) return dolj;

            var insCommand = new SQLiteCommand("INSERT INTO Dolj(name) VALUES (@name); SELECT last_insert_rowid()");
            insCommand.Parameters.AddWithValue("@name", name);
            var id = (int)(long)_sqlite.ExecuteScalar(insCommand);

            dolj = new People(id, name);
            _doljList.Add(dolj);

            return dolj;
        }

        public static People GetDolj(int id)
        {
            return Dolj.Find(d => d.Id == id); // TODO Оптимизировать
        }

        public static List<People> Dolj
        {
            get
            {
                if (_doljList == null)
                {
                    var tbl = _sqlite.ExecuteTable("SELECT * FROM Dolj");
                    _doljList = new List<People>(tbl.Rows.Count + 8);
                    foreach (DataRow row in tbl.Rows)
                        _doljList.Add(new People(row));
                }
                return _doljList;
            }
        }

        public static void Replace(People from, People to)
        {
            foreach (var i in _rasDocs)
                if (i.Dolj == from) i.Dolj = to;

            var cmd = new SQLiteCommand("UPDATE Ras SET id_dl=@T WHERE id_dl=@T");
            cmd.Parameters.AddWithValue("@F", from.Id);
            cmd.Parameters.AddWithValue("@T", to.Id);
            _sqlite.ExecuteNonQuery(cmd);
        }

        #endregion

        #region Подразделения

        private static List<Podrazd> _podrList;

        public static Podrazd GetPodrazd(string name)
        {
            var podr = Podrazd.Find(d => d.Name.Equals(name));
            if (podr != null) return podr;

            var insCommand = new SQLiteCommand("INSERT INTO Podrazd(name) VALUES (@name); SELECT last_insert_rowid()");
            insCommand.Parameters.AddWithValue("@name", name);
            var id = (int)(long)_sqlite.ExecuteScalar(insCommand);

            podr = new Podrazd(id, name);
            _podrList.Add(podr);

            return podr;
        }

        public static Podrazd GetPodrazd(int id)
        {
            return Podrazd.Find(d => d.Id == id); // TODO Оптимизировать
        }

        public static List<Podrazd> Podrazd
        {
            get
            {
                if (_podrList == null)
                {
                    var tbl = _sqlite.ExecuteTable("SELECT * FROM Podrazd");
                    _podrList = new List<Podrazd>(tbl.Rows.Count + 8);
                    foreach (DataRow row in tbl.Rows)
                        _podrList.Add(new Podrazd(row));
                }
                return _podrList;
            }
        }

        public static void Replace(Podrazd from, Podrazd to)
        {
            foreach (var i in _rasDocs)
                if (i.Podr == from) i.Podr = to;

            var cmd = new SQLiteCommand("UPDATE Ras SET id_podr=@T WHERE id_podr=@T");
            cmd.Parameters.AddWithValue("@F", from.Id);
            cmd.Parameters.AddWithValue("@T", to.Id);
            _sqlite.ExecuteNonQuery(cmd);
        }

        #endregion

        #region Расходные документы

        private static List<Ras> _rasDocs;
        private static Dictionary<int, Ras> _rasDocsById;

        public static List<Ras> RasDocs
        {
            get
            {
                if (_rasDocs != null) return _rasDocs;

                var cmd = new SQLiteCommand("SELECT * FROM RasDoc WHERE id_month=@M");
                cmd.Parameters.AddWithValue("@M", _month.Id);
                var tbl = _sqlite.ExecuteTable(cmd);

                _rasDocs = new List<Ras>(tbl.Rows.Count + 8);
                _rasDocsById = new Dictionary<int, Ras>();

                foreach (DataRow row in tbl.Rows)
                {
                    var doc = new Ras(row);
                    _rasDocs.Add(doc);
                    _rasDocsById.Add(doc.Id, doc);
                }

                return _rasDocs;
            }
        }

        public static Ras GetRasDoc(People dolj, Podrazd podr, int? numDoc, DateTime dateDoc)
        {
            var doc = RasDocs.Find(f => f.Dolj == dolj && f.Podr == podr && f.Date == dateDoc && f.Number == numDoc);
            if (doc != null) return doc;

            var cmd = new SQLiteCommand("INSERT INTO RasDoc(id_dl, id_podr, ntreb, date, id_month) VALUES (@id_dl, @id_podr, @ntreb, @date, @m); SELECT * FROM RasDoc WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@id_dl", dolj.Id);
            cmd.Parameters.AddWithValue("@id_podr", podr.Id);
            if (numDoc.HasValue)
                cmd.Parameters.AddWithValue("@ntreb", numDoc.Value);
            else
                cmd.Parameters.AddWithValue("@ntreb", DBNull.Value);
            cmd.Parameters.AddWithValue("@date", dateDoc);
            cmd.Parameters.AddWithValue("@m", _month.Id);

            var tbl = _sqlite.ExecuteTable(cmd);
            doc = new Ras(tbl.Rows[0]);

            _rasDocs.Add(doc);
            _rasDocsById.Add(doc.Id, doc);

            return doc;
        }

        public static Ras GetRasDoc(int id)
        {
            if (RasDocs == null) return null;
            Ras doc;
            return _rasDocsById.TryGetValue(id, out doc) ? doc : null;
        }

        public static void Remove(Ras doc)
        {
            _rasDocs.Remove(doc);
            _rasDocsById.Remove(doc.Id);
        }

        #endregion

        #region Счет-фактуры

        private static List<SFact> _schFact;
        private static Dictionary<int, SFact> _schFactById;

        public static List<SFact> SchFacts
        {
            get
            {
                if (_schFact != null) return _schFact;

                var cmd = new SQLiteCommand("SELECT * FROM SchFact WHERE id_month=@m");
                cmd.Parameters.AddWithValue("@m", _month.Id);
                var tbl = _sqlite.ExecuteTable(cmd);

                _schFact = new List<SFact>(tbl.Rows.Count + 8);
                _schFactById = new Dictionary<int, SFact>();

                foreach (DataRow row in tbl.Rows)
                {
                    var sf = new SFact(row);
                    _schFact.Add(sf);
                    _schFactById.Add(sf.Id, sf);
                }

                return _schFact;
            }
        }

        public static SFact AddSf(string num, Predpr predp, DateTime date)
        {
            var sf = SchFacts.Find(f => f.Number == num && f.Predp == predp && f.Date == date);
            if (sf != null) return sf;

            var cmd = new SQLiteCommand("INSERT INTO SchFact (num, id_predpr, datesf, id_month) VALUES (@N, @P, @D, @M); SELECT * FROM SchFact WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@N", num);
            cmd.Parameters.AddWithValue("@P", predp.Id);
            cmd.Parameters.AddWithValue("@D", date);
            cmd.Parameters.AddWithValue("@M", _month.Id);
            var tbl = _sqlite.ExecuteTable(cmd);
            sf = new SFact(tbl.Rows[0]);

            _schFactById.Add(sf.Id, sf);
            _schFact.Add(sf);
            return sf;
        }

        public static SFact GetSf(int id)
        {
            if (SchFacts == null) return null;
            SFact sf;
            return _schFactById.TryGetValue(id, out sf) ? sf : null;
        }

        public static void Remove(SFact sf)
        {
            _schFact.Remove(sf);
            _schFactById.Remove(sf.Id);
        }

        #endregion

        #region Движение

        private static List<SklNm> _monthBeg;
        public static List<SklNm> MonthBeg()
        {
            if (_monthBeg != null) return _monthBeg;

            var cmd = new SQLiteCommand("SELECT * FROM SklNm WHERE id_month=@id_month");
            cmd.Parameters.AddWithValue("@id_month", _month.Id);
            var tbl = _sqlite.ExecuteTable(cmd);
            _monthBeg = new List<SklNm>(tbl.Rows.Count + 8);
            foreach (DataRow row in tbl.Rows)
                _monthBeg.Add(new SklNm(row));
            return _monthBeg;
        }

        public static SklNm AddMonthBeg(Month month, Tovar tovar, double count)
        {
            var beg = _monthBeg?.Find(m => m.Tovar == tovar); // Пытаемся обновить существующую запись
            if (beg != null)
            {
                beg.Count += count;
                return beg;
            }

            var cmd = new SQLiteCommand("INSERT INTO SklNm(id_month, id_tov, count) VALUES (@id_month, @id_tov, @count);" +
                                                  "SELECT * FROM SklNm WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@id_month", month.Id);
            cmd.Parameters.AddWithValue("@id_tov", tovar.Id);
            cmd.Parameters.AddWithValue("@count", count);
            var tbl = _sqlite.ExecuteTable(cmd);
            beg = new SklNm(tbl.Rows[0]);
            _monthBeg?.Add(beg);
            return beg;
        }

        private static List<SklPr> _prihod;
        public static List<SklPr> Prihod
        {
            get
            {
                if (_prihod != null) return _prihod;

                var cmd = new SQLiteCommand("SELECT * FROM SklPr WHERE id_month=@id_month");
                cmd.Parameters.AddWithValue("@id_month", _month.Id);
                var tbl = _sqlite.ExecuteTable(cmd);
                _prihod = new List<SklPr>(tbl.Rows.Count + 8);
                foreach (DataRow row in tbl.Rows)
                    _prihod.Add(new SklPr(row));
                return _prihod;
            }
        }

        public static SklPr AddPrihod(Month month, Tovar tovar, double count, DateTime datePr, string typeDoc, SFact sf)
        {
            var cmd = new SQLiteCommand("INSERT INTO SklPr (id_month, id_tov, count, date_pr, typedoc, id_sf) VALUES (@id_month, @id_tov, @count, @date_pr, @typedoc, @id_sf);" +
                                                  "SELECT * FROM SklPr WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@id_month", month.Id);
            cmd.Parameters.AddWithValue("@id_tov", tovar.Id);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@date_pr", datePr);
            cmd.Parameters.AddWithValue("@typedoc", typeDoc);
            if (sf != null)
                cmd.Parameters.AddWithValue("@id_sf", sf.Id);
            else
                cmd.Parameters.AddWithValue("@id_sf", DBNull.Value);
            var tbl = _sqlite.ExecuteTable(cmd);
            var p = new SklPr(tbl.Rows[0]);
            _prihod?.Add(p);
            return p;
        }

        private static List<SklRs> _rashod;
        public static List<SklRs> Rashod
        {
            get
            {
                if (_rashod != null) return _rashod;

                var cmd = new SQLiteCommand("SELECT * FROM SklRs WHERE id_month=@id_month");
                cmd.Parameters.AddWithValue("@id_month", _month.Id);
                var tbl = _sqlite.ExecuteTable(cmd);
                _rashod = new List<SklRs>(tbl.Rows.Count + 8);
                foreach (DataRow row in tbl.Rows)
                    _rashod.Add(new SklRs(row));
                return _rashod;
            }
        }

        public static SklRs AddRashod(Month month, Tovar tovar, double count, DateTime dateRs, Ras doc)
        {
            var cmd = new SQLiteCommand("INSERT INTO SklRs (id_month, id_tov, count, date_rs, id_doc) VALUES (@id_month, @id_tov, @count, @date_rs, @id_doc);" +
                                                  "SELECT * FROM SklRs WHERE id=last_insert_rowid()");
            cmd.Parameters.AddWithValue("@id_month", month.Id);
            cmd.Parameters.AddWithValue("@id_tov", tovar.Id);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@date_rs", dateRs);
            if (doc != null)
                cmd.Parameters.AddWithValue("@id_doc", doc.Id);
            else
                cmd.Parameters.AddWithValue("@id_doc", DBNull.Value);
            var tbl = _sqlite.ExecuteTable(cmd);
            var r = new SklRs(tbl.Rows[0]);
            _rashod?.Add(r);
            return r;
        }

        private static List<SklMoves> _moves;
        public static List<SklMoves> Sklad
        {
            get
            {
                _moves = new List<SklMoves>();
                _tovars?.ForEach(t => t.TotalCount = 0);

                var dict = new Dictionary<Tovar, SklMoves>();
                foreach (var nm in MonthBeg())
                {
                    var m = new SklMoves(nm);
                    _moves.Add(m);
                    dict.Add(nm.Tovar, m);
                }
                foreach (var pr in Prihod)
                {
                    SklMoves m;
                    if (!dict.TryGetValue(pr.Tovar, out m))
                    {
                        m = new SklMoves(pr.Tovar);
                        _moves.Add(m);
                        dict.Add(pr.Tovar, m);
                    }
                    m.PrCount += pr.Count;
                }
                foreach (var rs in Rashod)
                {
                    SklMoves m;
                    if (!dict.TryGetValue(rs.Tovar, out m))
                    {
                        m = new SklMoves(rs.Tovar);
                        _moves.Add(m);
                        dict.Add(rs.Tovar, m);
                    }
                    m.RsCount += rs.Count;
                }

                foreach (var m in _moves)
                    m.Tovar.TotalCount = m.KmCount;

                return _moves;
            }
        }

        public static List<string> TypeDocs => Prihod.Select(p => p.TypeDoc).Distinct().Where(t => !String.IsNullOrEmpty(t)).ToList();

        #endregion
    }
}
