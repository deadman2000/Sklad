using System;
using System.Data;

namespace Sklad3.Objects
{
    public class People : NamedItem
    {
        public People(DataRow row) : base(row) { }

        public People(int id, string name) : base(id, name) { }

        protected override string Table => "Dolj";

        protected override bool CheckDublicate()
        {
            var exists = DbSklad.Dolj.Find(e => e.Name.Equals(Name) && e != this);
            if (exists == null) return false;

            DbSklad.Replace(this, exists);
            Delete();
            return true;
        }

        protected override void DeleteFromList()
        {
            DbSklad.Dolj.Remove(this);
        }
    }
}
