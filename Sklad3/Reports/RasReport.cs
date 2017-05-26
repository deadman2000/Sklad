using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklad3.Reports
{
    class RasReport : Report
    {
        private Ras _doc;

        public RasReport(Ras doc)
        {
            _doc = doc;
        }

        protected override string Template
        {
            get
            {
                return _doc.Type.Pattern; // TODO двухстраничный вариант
            }
        }

        protected override void FillContent()
        {
        }
    }
}
