using System;
using System.Data;

namespace Sklad3.Objects
{
    /// <summary>
    /// Счет-фактура
    /// </summary>
    public class SFact : IdObject
    {
        private string _number;
        private Predpr _predp;
        private DateTime _date;

        public SFact(DataRow row) : base(row)
        {
            _number = (string)row["num"];
            _predp = DbSklad.GetPredp((int)(long)row["id_predpr"]);
            _date = (DateTime)row["datesf"];
        }

        protected override string Table => "SchFact";

        public string Number
        {
            get { return _number; }
            set
            {
                _number = value; 
                UpdateField("num", _number);
            }
        }

        public Predpr Predp
        {
            get { return _predp; }
            set
            {
                _predp = value; 
                UpdateField("id_predpr", _predp.Id);
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value; 
                UpdateField("datesf", _date);
            }
        }

        protected override void DeleteFromList()
        {
            DbSklad.Remove(this);
        }

        public override string ToString()
        {
            return String.Format("№{0} от {1} {2}", _number, _predp, _date);
        }
    }
}
