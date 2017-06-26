using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sklad3.Objects;

namespace Sklad3.UI
{
    public partial class FormAddRsDoc : XtraForm
    {
        private readonly BindingSource _bsRsDoc = new BindingSource();
        private readonly List<SklRs> _positions = new List<SklRs>();

        public FormAddRsDoc()
        {
            InitializeComponent();

            cbMonth.Properties.Items.AddRange(DbSklad.Months);
            cbMonth.EditValue = DbSklad.CurrentMonth;

            deDate.EditValue = DateTime.Now;

            deDateDoc.EditValue = DateTime.Now;

            _bsRsDoc.DataSource = DbSklad.RasDocs;
            glueRsDoc.Properties.DataSource = _bsRsDoc;
            gluevRsDoc.BestFitColumns();
            gluevRsDoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gcTovars.DataSource = _positions;
            cbDolj.Properties.Items.AddRange(DbSklad.Dolj);
            cbPodr.Properties.Items.AddRange(DbSklad.Podrazd);
            cbDocType.Properties.Items.Add("Не задан");
            cbDocType.Properties.Items.AddRange(RasDocPattern.Patterns);

            selExistTov.RsPositions = _positions;
        }

        private void glueRsDoc_EditValueChanged(object sender, EventArgs e)
        {
            Ras doc = glueRsDoc.EditValue as Ras;
            if (doc != null)
            {
                lcDolj.Text = doc.Dolj.Name;
                lcPodr.Text = doc.Podr.Name;
            }
            else
            {
                lcDolj.Text = "";
                lcPodr.Text = "";
            }
        }

        private void cbAddTov_Click(object sender, EventArgs e)
        {
            Tovar tov = selExistTov.SelectedTovar;
            if (tov == null) return;

            if (selExistTov.Count > selExistTov.GetTotalCount(tov))
            {
                XtraMessageBox.Show("Количество больше чем в остатке!");
                return;
            }

            _positions.Add(new SklRs(tov, selExistTov.Count));
            gcTovars.RefreshDataSource();
            gvTovars.BestFitColumns();
            selExistTov.Clear();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (_positions.Count == 0)
            {
                XtraMessageBox.Show("Добавьте наименования в список");
                return;
            }
            if (!validProvider.Validate())
                return;

            Ras doc;
            if (chbAddToDoc.Checked)
            {
                doc = glueRsDoc.EditValue as Ras;
                if (doc == null) return;
            }
            else
            {
                var dolj = cbDolj.EditValue as People ?? DbSklad.GetDolj(cbDolj.Text);
                var podr = cbPodr.EditValue as Podrazd ?? DbSklad.GetPodrazd(cbPodr.Text);
                var type = cbDocType.EditValue as RasDocPattern;
                doc = DbSklad.GetRasDoc(dolj, podr, 0, deDateDoc.DateTime, type);
            }

            var month = (Month)cbMonth.SelectedItem;
            var dateRs = (DateTime)deDate.EditValue;

            SklRs last = null;
            foreach (var rs in _positions)
                last = DbSklad.AddRashod(month, rs.Tovar, rs.Count, dateRs, doc);

            MainForm.Inst.UpdateTables();
            MainForm.Inst.ScrollTo(last);

            Close();
        }

        private void chbNewDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNewDoc.Checked)
            {
                pcAddDoc.Visible = true;
                pcSelDoc.Visible = false;
                chbAddToDoc.Checked = false;
            }
        }

        private void chbAddToDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddToDoc.Checked)
            {
                pcAddDoc.Visible = false;
                pcSelDoc.Visible = true;
                chbNewDoc.Checked = false;
            }
        }

        private void gcTovars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var rows = gvTovars.GetSelectedRows();
                if (rows.Length == 0) return;
                var rs = gvTovars.GetRow(rows[0]) as SklRs;
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