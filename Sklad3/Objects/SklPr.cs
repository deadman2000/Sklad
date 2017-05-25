using System;
using System.Data;

namespace Sklad3.Objects
{
    public class SklPr : SklBase
    {
        private DateTime _date;
        private string _typeDoc;
        private SFact _sFact;

        public SklPr(DataRow row) : base(row)
        {
            _date = (DateTime)row["date_pr"];
            if (row["id_sf"] != DBNull.Value)
                _sFact = DbSklad.GetSf((int)(long)row["id_sf"]);
            _typeDoc = (string)row["typedoc"];
        }

        public SklPr(Tovar tov, double count) : base(tov, count) { }

        protected override string Table => "SklPr";

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                UpdateField("date_pr", _date);
            }
        }

        public string TypeDoc
        {
            get { return _typeDoc; }
            set
            {
                _typeDoc = value;
                UpdateField(_typeDoc, _typeDoc);
            }
        }

        public SFact SFact
        {
            get { return _sFact; }
            set
            {
                _sFact = value;
                UpdateField("id_sf", _sFact.Id);
            }
        }

        public double TotalPrice => Count * Tovar.Price;

        protected override void DeleteFromList()
        {
            DbSklad.Prihod.Remove(this);
        }
    }
}
