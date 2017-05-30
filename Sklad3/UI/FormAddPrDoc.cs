using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormAddPrDoc : XtraForm
    {
        private readonly List<SklPr> _positions = new List<SklPr>();

        public FormAddPrDoc()
        {
            InitializeComponent();

            cbMonth.Properties.Items.AddRange(DbSklad.Months);
            cbMonth.EditValue = DbSklad.CurrentMonth;

            deDate.EditValue = DateTime.Now;
            cbTypeDoc.Properties.Items.AddRange(DbSklad.TypeDocs);

            deDateDoc.EditValue = DateTime.Now;

            cbPredp.Properties.Items.AddRange(DbSklad.Predp);

            gcTovars.DataSource = _positions;

            validProvider.SetValidationRule(cbPredp, new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Введите поставщика"
            });
        }

        private void cbAddTov_Click(object sender, EventArgs e)
        {
            if (selTov.SelectedTovar != null)
            {
                var pr = new SklPr(selTov.SelectedTovar, selTov.Count);
                _positions.Add(pr);
                gcTovars.RefreshDataSource();
                gvTovars.BestFitColumns();
                selTov.Clear();
            }
        }

        private void sbAddPrDoc_Click(object sender, EventArgs e)
        {
            if (_positions.Count == 0)
            {
                XtraMessageBox.Show("Добавьте наименования в список");
                return;
            }
            if (!validProvider.Validate())
                return;

            var predp = cbPredp.SelectedItem as Predpr ?? DbSklad.GetPredp(cbPredp.Text);
            var sf = DbSklad.AddSf(teNumDoc.Text, predp, (DateTime)deDateDoc.EditValue);

            var month = (Month)cbMonth.SelectedItem;
            var datePr = (DateTime)deDate.EditValue;

            SklPr last = null;
            foreach (var pr in _positions)
                last = DbSklad.AddPrihod(month, pr.Tovar, pr.Count, datePr, cbTypeDoc.Text, sf);

            MainForm.Inst.UpdateTables();
            MainForm.Inst.ScrollTo(last);
            Close();
        }
        
        private void gcTovars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var rows = gvTovars.GetSelectedRows();
                if (rows.Length == 0) return;
                var rs = gvTovars.GetRow(rows[0]) as SklPr;
                if (rs == null) return;
                _positions.Remove(rs);
                gcTovars.RefreshDataSource();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}