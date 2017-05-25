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
    public partial class FormSelectTovar : DevExpress.XtraEditors.XtraForm
    {
        public FormSelectTovar()
        {
            InitializeComponent();
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            if (selectTovar.SelectedTovar != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public Tovar Tovar => selectTovar.SelectedTovar;
    }
}