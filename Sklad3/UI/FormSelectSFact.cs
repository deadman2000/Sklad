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
    public partial class FormSelectSFact : DevExpress.XtraEditors.XtraForm
    {
        public FormSelectSFact()
        {
            InitializeComponent();

            gcSFact.DataSource = DbSklad.SchFacts;
            gvSFact.BestFitColumns();
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            OnSelected();
        }

        private void gvSFact_DoubleClick(object sender, EventArgs e)
        {
            OnSelected();
        }

        protected void OnSelected()
        {
            if (gvSFact.SelectedRowsCount == 0) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        public SFact SelectedSFact
        {
            get
            {
                if (gvSFact.SelectedRowsCount == 0) return null;
                return gvSFact.GetRow(gvSFact.GetSelectedRows()[0]) as SFact;
            }
        }
    }
}