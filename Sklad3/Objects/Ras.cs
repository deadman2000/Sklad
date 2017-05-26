using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Sklad3.Objects
{
    /// <summary>
    /// Расходный документ
    /// </summary>
    public class Ras : IdObject
    {
        private Podrazd _podr;
        private People _dolj;
        private int? _number;
        private DateTime _date;
        private RasDocPattern _type;

        public Ras(DataRow row) : base(row)
        {
            _dolj = DbSklad.GetDolj((int)(long)row["id_dl"]);
            _podr = DbSklad.GetPodrazd((int)(long)row["id_podr"]);
            if (!(row["ntreb"] is DBNull))
                _number = (int)(long)row["ntreb"];
            _date = (DateTime)row["date"];
            if (!(row["type"] is DBNull))
                _type = RasDocPattern.ById((int)(long)row["type"]);
        }

        protected override string Table => "RasDoc";

        /// <summary>
        /// Должностное лицо
        /// </summary>
        public People Dolj
        {
            get { return _dolj; }
            set
            {
                if (_dolj == value) return;
                _dolj = value;
                UpdateField("id_dl", _dolj.Id);
            }
        }

        /// <summary>
        /// Подразделение
        /// </summary>
        public Podrazd Podr
        {
            get { return _podr; }
            set
            {
                if (_podr == value) return;
                _podr = value;
                UpdateField("id_podr", _podr.Id);
            }
        }

        public int? Number
        {
            get { return _number; }
            set
            {
                if (_number == value) return;
                _number = value;
                UpdateField("ntreb", _number);
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date == value) return;
                _date = value;
                UpdateField("date", _date);
            }
        }

        public RasDocPattern Type
        {
            get { return _type; }
            set
            {
                if (_type == value) return;
                _type = value;
                UpdateField("type", _date);
            }
        }

        protected override void DeleteFromList()
        {
            DbSklad.Remove(this);
        }

        public override string ToString()
        {
            return String.Format("№{0} {1} от {2} {3}", _number, _podr, _date, _dolj);
        }
    }
}
