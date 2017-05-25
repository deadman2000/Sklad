using System;
using System.Data;
using System.Data.SQLite;

namespace Sklad3.Objects
{
    public class Tovar : NamedItem
    {
        private EdIsm _edIsm;
        private string _nsch;
        private string _invn;
        private double _price;
        private bool _visible;
        private double _totalCount;
        private string _note;

        public Tovar(DataRow row) : base(row)
        {
            _edIsm = DbSklad.GetEdIsm((int)(long)row["id_edism"]);
            _nsch = (string)row["nsch"];
            _invn = (string)row["invn"];
            _price = (double)row["price"];
            _visible = (int)row["isVisible"] == 1;
            _note = (string)row["note"];
        }
        protected override string Table => "Tovar";

        public EdIsm EdIsm
        {
            get { return _edIsm; }
            set
            {
                _edIsm = value;
                UpdateField("id_edism", _edIsm.Id);
            }
        }

        public string Nsch
        {
            get { return _nsch; }
            set
            {
                _nsch = value;
                UpdateField("nsch", _nsch);
            }
        }

        public string Invn
        {
            get { return _invn; }
            set
            {
                _invn = value;
                UpdateField("invn", _invn);
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                UpdateField("price", _price);
            }
        }

        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                UpdateField("note", _note);
            }
        }


        public bool Visible
        {
            get { return _visible; }
            set
            {
                _visible = value;
                UpdateField("isVisible", _visible ? 1 : 0);
            }
        }

        /// <summary>
        /// Остаток на конец текущего месяца
        /// </summary>
        public double TotalCount
        {
            get { return _totalCount; }
            set { _totalCount = value; }
        }

        public string NameWithInvn
        {
            get
            {
                if (!String.IsNullOrEmpty(_invn))
                    return Name + " " + _invn;
                return Name;
            }
        }

        protected override bool CheckDublicate()
        {
            var exists = DbSklad.Tovars.Find(t => t != this && t._edIsm == _edIsm && t.Name.Equals(Name) && t.Nsch.Equals(_nsch) && t._invn.Equals(_invn) && Math.Abs(t._price - _price) < 0.01);
            if (exists == null) return false;

            DbSklad.Replace(this, exists);

            var cmd = new SQLiteCommand("UPDATE SklNm SET id_tov=@T WHERE id_tov=@F; UPDATE SklPr SET id_tov=@T WHERE id_tov=@F; UPDATE SklRs SET id_tov=@T WHERE id_tov=@F;");
            cmd.Parameters.AddWithValue("@F", _id);
            cmd.Parameters.AddWithValue("@T", exists._id);
            DbSklad.SQL.ExecuteNonQuery(cmd);

            Delete();
            return true;
        }

        protected override void DeleteFromList()
        {
            DbSklad.Remove(this);
        }
    }
}