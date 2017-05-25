using System.Data;

namespace Sklad3.Objects
{
    public class Podrazd : NamedItem
    {
        public Podrazd(DataRow row) : base(row) { }

        public Podrazd(int id, string name) : base(id, name) { }

        protected override string Table => "Podrazd";

        protected override bool CheckDublicate()
        {
            var exists = DbSklad.Podrazd.Find(e => e.Name.Equals(Name) && e != this);
            if (exists == null) return false;

            DbSklad.Replace(this, exists);
            Delete();
            return true;
        }

        protected override void DeleteFromList()
        {
            DbSklad.Podrazd.Remove(this);
        }
    }
}