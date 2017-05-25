using System.Data;

namespace Sklad3.Objects
{
    public class Predpr : NamedItem
    {
        public Predpr(DataRow row) : base(row) { }

        public Predpr(int id, string name) : base(id, name) { }

        protected override string Table => "Predpr";

        protected override bool CheckDublicate()
        {
            var exists = DbSklad.Predp.Find(e => e.Name.Equals(Name) && e != this);
            if (exists == null) return false;

            DbSklad.Replace(this, exists);
            Delete();
            return true;
        }

        protected override void DeleteFromList()
        {
            DbSklad.Predp.Remove(this);
        }
    }
}