using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormSelectRasDoc : XtraForm
    {
        public FormSelectRasDoc(List<Ras> ras)
        {
            InitializeComponent();

            gcRas.DataSource = ras;
            gvRas.BestFitColumns();
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            OnSelected();
        }

        private void gvRas_DoubleClick(object sender, EventArgs e)
        {
            OnSelected();
        }

        protected void OnSelected()
        {
            if (gvRas.SelectedRowsCount == 0) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        public Ras SelectedRasDoc
        {
            get
            {
                if (gvRas.SelectedRowsCount == 0)
                    return null;
                return gvRas.GetRow(gvRas.GetSelectedRows()[0]) as Ras;
            }
        }
    }
}