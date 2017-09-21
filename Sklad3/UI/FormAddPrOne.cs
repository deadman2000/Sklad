using System;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormAddPrOne : DevExpress.XtraEditors.XtraForm
    {
        public FormAddPrOne()
        {
            InitializeComponent();

            cbMonth.Properties.Items.AddRange(DbSklad.Months);
            cbMonth.EditValue = DbSklad.CurrentMonth;

            deDate.EditValue = DateTime.Now;
            cbTypeDoc.Properties.Items.AddRange(DbSklad.TypeDocs);

            luePrDoc.Properties.DataSource = DbSklad.SchFacts;
        }

        private void btAddPr_Click(object sender, EventArgs e)
        {
            var tovar = selTov.GetSelectedTovar();
            if (tovar != null)
            {
                var month = (Month)cbMonth.SelectedItem;
                var datePr = (DateTime)deDate.EditValue;
                var sf = (SFact) luePrDoc.EditValue;
                var p = DbSklad.AddPrihod(month, tovar, selTov.Count, datePr, cbTypeDoc.Text, sf);
                MainForm.Inst.UpdateTables();
                MainForm.Inst.ScrollTo(p);
                Close();
            }
        }

        private void luePrDoc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                luePrDoc.EditValue = null;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}