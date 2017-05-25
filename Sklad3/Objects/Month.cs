using System;
using System.Data;

namespace Sklad3.Objects
{
    class Month : IdObject
    {
        private DateTime _date;

        public Month(DataRow row) : base(row)
        {
            _date = (DateTime)row["date"];
        }

        public Month(int id, DateTime date) : base(id)
        {
            _date = date;
        }

        protected override string Table => "Month";

        public DateTime Date => _date;

        protected override void DeleteFromList()
        {
            DbSklad.Months.Remove(this);
        }

        public override string ToString()
        {
            return _date.ToString("MMMM yyyy");
        }
    }
}