using System.Data;
using System.Data.SQLite;

namespace Sklad3.Objects
{
    public class SklNm : SklBase
    {
        public SklNm(DataRow row) : base(row) { }

        public SklNm(Tovar tovar, double count) : base(tovar, count) { }

        protected override string Table => "SklNm";

        protected override void DeleteFromList()
        {
            DbSklad.MonthBeg().Remove(this);
        }
    }
}
