using System;
using System.Data;

namespace Sklad3.Objects
{
    public class SklRs : SklBase
    {
        private DateTime _date;
        private Ras _doc;

        public SklRs(DataRow row) : base(row)
        {
            _date = (DateTime)row["date_rs"];
            if (row["id_doc"] != DBNull.Value)
                _doc = DbSklad.GetRasDoc((int)(long)row["id_doc"]);
        }

        public SklRs(Tovar tov, double count) : base(tov, count) { }

        protected override string Table => "SklRs";

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                UpdateField("date_rs", _date);
            }
        }

        public Ras Doc
        {
            get { return _doc; }
            set
            {
                _doc = value;
                UpdateField("id_doc", _doc.Id);
            }
        }

        public double TotalPrice => Count * Tovar.Price;

        protected override void DeleteFromList()
        {
            DbSklad.Rashod.Remove(this);
        }
    }
}
