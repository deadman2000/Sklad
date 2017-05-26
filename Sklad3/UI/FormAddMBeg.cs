using System;
using DevExpress.XtraEditors;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormAddMBeg : XtraForm
    {
        public FormAddMBeg()
        {
            InitializeComponent();

            cbMonth.Properties.Items.AddRange(DbSklad.Months);
            cbMonth.EditValue = DbSklad.CurrentMonth;
        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (selTov.SelectedTovar != null)
            {
                var b = DbSklad.AddMonthBeg((Month)cbMonth.SelectedItem, selTov.SelectedTovar, selTov.Count);
                MainForm.Inst.UpdateTables();
                MainForm.Inst.ScrollTo(b);
                Close();
            }
        }
    }
}