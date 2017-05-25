using System.Data;
using System.Data.SQLite;

namespace Sklad3.Objects
{
    public abstract class IdObject
    {
        protected int _id;

        protected IdObject(DataRow row)
        {
            _id = (int)(long)row["Id"];
        }

        protected IdObject(int id)
        {
            _id = id;
        }

        protected abstract string Table { get; }

        public int Id => _id;

        protected virtual bool CheckDublicate()
        {
            return false;
        }

        protected void UpdateField(string field, object value)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE " + Table + " SET " + field + "=@V WHERE id=@id");
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.Parameters.AddWithValue("@V", value);
            DbSklad.SQL.ExecuteNonQuery(cmd);
        }

        public void Delete()
        {
            var cmd = new SQLiteCommand("DELETE FROM " + Table + " WHERE id=@id");
            cmd.Parameters.AddWithValue("@id", _id);
            DbSklad.SQL.ExecuteNonQuery(cmd);
            DeleteFromList();
        }

        protected abstract void DeleteFromList();
    }
}