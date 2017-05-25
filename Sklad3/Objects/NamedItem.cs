using System.Data;

namespace Sklad3.Objects
{
    public abstract class NamedItem : IdObject
    {
        private string _name;

        protected NamedItem(DataRow row) : base(row)
        {
            _name = (string)row["Name"];
        }

        protected NamedItem(int id, string name) : base(id)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (!CheckDublicate())
                    UpdateField("Name", _name);
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
