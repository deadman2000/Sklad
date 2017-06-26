using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Sklad3.Objects;
using Sklad3.Reports;
using Sklad3.Properties;

namespace Sklad3.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static MainForm Inst;

        private readonly FormHolder<FormAddMBeg> _frmAddBeg = new FormHolder<FormAddMBeg>();
        private readonly FormHolder<FormAddPrOne> _frmAddPrOne = new FormHolder<FormAddPrOne>();
        private readonly FormHolder<FormAddPrDoc> _frmAddPrSf = new FormHolder<FormAddPrDoc>();
        private readonly FormHolder<FormAddRsOne> _frmAddRsOne = new FormHolder<FormAddRsOne>();
        private readonly FormHolder<FormAddRsDoc> _frmAddRsDoc = new FormHolder<FormAddRsDoc>();

        public MainForm()
        {
            InitializeComponent();

            Inst = this;

            if (DbSklad.Months.Count == 0)
                DbSklad.AddMonth(DateTime.Now);
            ricbMonth.Items.AddRange(DbSklad.Months);
            beiMonth.EditValue = DbSklad.Months.Last();

            beiPodrazdName.EditValue = Settings.Default.Podrazd;
            beiUserName.EditValue = Settings.Default.UserName;
        }

        public void UpdateTables()
        {
            gcPrihod.DataSource = DbSklad.Prihod;
            gcPrihod.RefreshDataSource();
            gcRashod.DataSource = DbSklad.Rashod;
            gcRashod.RefreshDataSource();
            gcSklad.DataSource = DbSklad.Sklad;
        }

        public void ScrollTo(SklRs r)
        {
            var row = gvRashod.LocateByValue("Id", r.Id);
            if (row != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                gvRashod.MakeRowVisible(row);
        }

        public void ScrollTo(SklPr p)
        {
            int row = gvPrihod.LocateByValue("Id", p.Id);
            if (row != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                gvPrihod.MakeRowVisible(row);
        }

        public void ScrollTo(SklNm b)
        {
            int row = gvSklad.LocateByValue("Tovar.Id", b.Tovar.Id);
            if (row != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                gvSklad.MakeRowVisible(row);
        }

        private void gvSklad_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gvPrihod.RefreshData();
            gvRashod.RefreshData();
            gvSklad.RefreshData();
        }

        #region Месяцы

        private void beiMonth_EditValueChanged(object sender, EventArgs e)
        {
            DbSklad.CurrentMonth = (Month)beiMonth.EditValue;
            ribbon.ApplicationCaption = DbSklad.CurrentMonth.ToString();

            gcPrihod.DataSource = DbSklad.Prihod;
            gvPrihod.BestFitColumns();
            gcRashod.DataSource = DbSklad.Rashod;
            gvRashod.BestFitColumns();
            gcSklad.DataSource = DbSklad.Sklad;
            gvSklad.BestFitColumns();
        }

        private void bbiNewMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Вы действительно хотите добавить новый месяц?", "Новый месяц", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var month = DbSklad.NewMonth();
                ricbMonth.Items.Clear();
                ricbMonth.Items.AddRange(DbSklad.Months);
                beiMonth.EditValue = month;
            }
        }

        #endregion

        #region Forms

        private void bbiAddMBeg_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frmAddBeg.Show();
        }

        private void bbiAddPrOne_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frmAddPrOne.Show();
        }

        private void bbiAddPrSf_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frmAddPrSf.Show();
        }

        private void bbiAddRsOne_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frmAddRsOne.Show();
        }

        private void bbiAddRsDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frmAddRsDoc.Show();
        }

        #endregion

        #region Search

        private void bchiFilter_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            gvPrihod.OptionsView.ShowAutoFilterRow = bchiFilter.Checked;
            gvRashod.OptionsView.ShowAutoFilterRow = bchiFilter.Checked;
            gvSklad.OptionsView.ShowAutoFilterRow = bchiFilter.Checked;

            if (!bchiFilter.Checked)
            {
                gvPrihod.ClearColumnsFilter();
                gvRashod.ClearColumnsFilter();
                gvSklad.ClearColumnsFilter();
            }
        }

        class SearchValue
        {
            private readonly string _val;
            public SearchValue(string searchVal)
            {
                _val = searchVal;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                return obj.ToString().StartsWith(_val, true, System.Globalization.CultureInfo.InvariantCulture);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        private void Locate(string locate)
        {
            switch (tcMain.SelectedTabPageIndex)
            {
                case 0:
                    gvPrihod.BeginUpdate();
                    try
                    {
                        DevExpress.XtraGrid.Columns.GridColumn col = gvPrihod.Columns["name"];
                        var rowHandle = gvPrihod.LocateByValue(0, col, new SearchValue(locate));
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            gvPrihod.FocusedRowHandle = rowHandle;
                            gvPrihod.TopRowIndex = rowHandle;
                        }
                    }
                    finally { gvPrihod.EndUpdate(); }
                    break;
                case 1:
                    gvRashod.BeginUpdate();
                    try
                    {
                        DevExpress.XtraGrid.Columns.GridColumn col = gvRashod.Columns["name"];
                        var rowHandle = gvRashod.LocateByValue(0, col, new SearchValue(locate));
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            gvRashod.FocusedRowHandle = rowHandle;
                            gvRashod.TopRowIndex = rowHandle;
                        }
                    }
                    finally { gvRashod.EndUpdate(); }
                    break;
                case 2:
                    gvSklad.BeginUpdate();
                    try
                    {
                        DevExpress.XtraGrid.Columns.GridColumn col = gvSklad.Columns["name"];
                        var rowHandle = gvSklad.LocateByValue(0, col, new SearchValue(locate));
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        {
                            gvSklad.FocusedRowHandle = rowHandle;
                            gvSklad.TopRowIndex = rowHandle;
                        }
                    }
                    finally { gvSklad.EndUpdate(); }
                    break;
                default:
                    return;
            }
        }

        private void ribeLocate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            string locate = e.NewValue.ToString();
            if (locate == "")
            {
                e.NewValue = null;
                return;
            }
            Locate(locate);
        }

        private void ribeLocate_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (beiLocate.EditValue != null)
                Locate(beiLocate.EditValue.ToString());
        }

        #endregion

        #region Reports

        private void bbiRepMat_ItemClick(object sender, ItemClickEventArgs e)
        {
            new MatReport(DbSklad.Sklad.FindAll(s => !String.IsNullOrEmpty(s.Tovar.Invn))).Build();
        }

        private void bbiRepOther_ItemClick(object sender, ItemClickEventArgs e)
        {
            new MatReport(DbSklad.Sklad.FindAll(s => String.IsNullOrEmpty(s.Tovar.Invn))).Build();
        }

        private void bbiRasReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormSelectRasDoc(DbSklad.RasDocs.Where(d => d.Type != null).ToList());
            if (form.ShowDialog() == DialogResult.OK)
            {
                var doc = form.SelectedRasDoc;
                new RasReport(doc).Build();
            }
        }

        #endregion

        private void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("Импортирование");
                    Importer.Import(ofd.FileName);
                    XtraMessageBox.Show("Готово");
                }
            }
        }


        #region Popup

        private object _popupObject;

        private void gvSklad_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                _popupObject = gvSklad.GetRow(e.HitInfo.RowHandle);
                e.Allow = false;
                pmSklMoves.ShowPopup(gcSklad.PointToScreen(e.Point));
            }
        }

        private void gvPrihod_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                _popupObject = (SklBase)gvPrihod.GetRow(e.HitInfo.RowHandle);
                e.Allow = false;
                pmSklPrihod.ShowPopup(gcPrihod.PointToScreen(e.Point));
            }
        }

        private void gvRashod_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                _popupObject = (SklBase)gvRashod.GetRow(e.HitInfo.RowHandle);
                e.Allow = false;
                pmSklRashod.ShowPopup(gcRashod.PointToScreen(e.Point));
            }
        }

        private void bbiChangeTovar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormSelectTovar();
            if (form.ShowDialog() != DialogResult.OK) return;

            var sklBase = _popupObject as SklBase;
            if (sklBase != null)
            {
                sklBase.Tovar = form.Tovar;
            }
            else
            {
                DbSklad.Replace(((SklMoves)_popupObject).Tovar, form.Tovar);
            }
        }

        private void bbiRemoveMove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var sklBase = _popupObject as SklBase;
            if (sklBase == null) return;

            sklBase.Delete();
            UpdateTables();
        }

        private void bbiChangePrDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var pr = _popupObject as SklPr;
            if (pr != null)
            {
                var form = new FormSelectSFact();
                if (form.ShowDialog() != DialogResult.OK) return;

                pr.SFact = form.SelectedSFact;
                gcPrihod.RefreshDataSource();
                return;
            }

            var rs = _popupObject as SklRs;
            if (rs != null)
            {
                var form = new FormSelectRasDoc(DbSklad.RasDocs);
                if (form.ShowDialog() != DialogResult.OK) return;

                rs.Doc = form.SelectedRasDoc;
                gcRashod.RefreshDataSource();
            }
        }

        #endregion

        #region Settings

        private void beiPodrazdName_EditValueChanged(object sender, EventArgs e)
        {
            if (Settings.Default.Podrazd != beiPodrazdName.EditValue.ToString())
            {
                Settings.Default.Podrazd = beiPodrazdName.EditValue.ToString();
                Settings.Default.Save();
            }
        }

        private void beiUserName_EditValueChanged(object sender, EventArgs e)
        {
            if (Settings.Default.UserName != beiUserName.EditValue.ToString())
            {
                Settings.Default.UserName = beiUserName.EditValue.ToString();
                Settings.Default.Save();
            }
        }

        #endregion
    }
}