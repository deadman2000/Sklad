using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklad3.Objects
{
    public class RasDocPattern
    {
        public static readonly RasDocPattern[] Patterns = new RasDocPattern[]
            {
                new RasDocPattern(0, "Списание нефинансовых активов", "rs_0504104"),
                new RasDocPattern(1, "Списание мягкого и хозяйственного инвентаря", "rs_0504143")
            };

        private static readonly Dictionary<int, RasDocPattern> _byId = Patterns.ToDictionary(p => p._id, p => p);

        public static RasDocPattern ById(int id)
        {
            RasDocPattern p;
            if (_byId.TryGetValue(id, out p)) return p;
            return null;
        }

        private RasDocPattern(int id, string name, string pattern)
        {
            _id = id;
            _name = name;
            _pattern = pattern;
        }

        private int _id;
        public int Id => _id;

        private string _pattern;
        public string Pattern => _pattern;

        private string _name;
        public string Name => _name;

        public override string ToString() => _name;
    }
}
