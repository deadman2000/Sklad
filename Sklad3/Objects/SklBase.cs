using Sklad3.UI;
using System.Data;

namespace Sklad3.Objects
{
    public abstract class SklBase : IdObject
    {
        private Tovar _tovar;
        private double _count;

        protected SklBase(DataRow row) : base(row)
        {
            _tovar = DbSklad.GetTovar((int)(long)row["id_tov"]);
            _count = (double)row["count"];
        }

        protected SklBase(Tovar tov, double count) : base(0)
        {
            _tovar = tov;
            _count = count;
        }

        public Tovar Tovar
        {
            get { return _tovar; }
            set
            {
                _tovar = value;
                UpdateField("id_tov", _tovar.Id);
                MainForm.Inst.UpdateTables();
            }
        }

        public double Count
        {
            get { return _count; }
            set
            {
                _count = value;
                if (_count <= 0)
                    Delete();
                else
                    UpdateField("count", _count);
                MainForm.Inst.UpdateTables();
            }
        }
    }
}
