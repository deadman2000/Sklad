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

        private Tovar _tovar;
        public Tovar Tovar => _tovar;

        private void sbSelect_Click(object sender, EventArgs e)
        {
            _tovar = selectTovar.GetSelectedTovar();
            if (_tovar != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}