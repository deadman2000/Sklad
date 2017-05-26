using System;
using DevExpress.XtraEditors;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormAddRsOne : XtraForm
    {
        public FormAddRsOne()
        {
            InitializeComponent();

            cbMonth.Properties.Items.AddRange(DbSklad.Months);
            cbMonth.EditValue = DbSklad.CurrentMonth;
            deDate.EditValue = DateTime.Now;

            lueRsDoc.Properties.DataSource = DbSklad.RasDocs;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var tov = selExistTov.SelectedTovar;
            if (tov != null)
            {
                if (selExistTov.Count > tov.TotalCount)
                {
                    XtraMessageBox.Show("Количество больше чем в остатке!");
                    return;
                }

                var month = (Month)cbMonth.SelectedItem;
                var date = (DateTime)deDate.EditValue;
                var rasDoc = (Ras)lueRsDoc.EditValue;
                var r = DbSklad.AddRashod(month, tov, selExistTov.Count, date, rasDoc);
                MainForm.Inst.UpdateTables();
                MainForm.Inst.ScrollTo(r);
                Close();
            }
        }
    }
}