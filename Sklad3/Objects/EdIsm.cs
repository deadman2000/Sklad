using System.Data;

namespace Sklad3.Objects
{
    public class EdIsm : NamedItem
    {
        public EdIsm(DataRow row) : base(row) { }

        public EdIsm(int id, string name) : base(id, name) { }

        protected override string Table => "EdIsm";

        protected override bool CheckDublicate()
        {
            var exists = DbSklad.EdIsm.Find(e => e.Name.Equals(Name) && e != this);
            if (exists == null) return false;

            DbSklad.Replace(this, exists);
            Delete();
            return true;
        }

        protected override void DeleteFromList()
        {
            DbSklad.Remove(this);
        }
    }
}