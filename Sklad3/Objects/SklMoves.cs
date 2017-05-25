
namespace Sklad3.Objects
{
    public class SklMoves
    {
        private Tovar _tovar;
        private readonly SklNm _nm;

        public SklMoves(SklNm nm)
        {
            _nm = nm;
            _tovar = _nm.Tovar;
        }

        public SklMoves(Tovar tov)
        {
            _tovar = tov;
        }

        public Tovar Tovar
        {
            get { return _tovar; }
            set { _tovar = value; }
        }

        public SklNm Nm => _nm;

        public double? NmSum
        {
            get
            {
                if (Nm != null) return Nm.Count * Tovar.Price;
                return null;
            }
        }

        public double PrCount { get; set; }

        public double PrSum => PrCount * Tovar.Price;

        public double RsCount { get; set; }

        public double RsSum => RsCount * Tovar.Price;

        public double KmCount
        {
            get
            {
                double c = PrCount - RsCount;
                if (_nm != null) c += _nm.Count;
                return c;
            }
        }

        public double KmSum => KmCount * Tovar.Price;
    }
}
