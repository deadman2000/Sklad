namespace Sklad3.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNewMonth = new DevExpress.XtraBars.BarButtonItem();
            this.icSmallButtons = new DevExpress.Utils.ImageCollection(this.components);
            this.beiMonth = new DevExpress.XtraBars.BarEditItem();
            this.ricbMonth = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bbiAddMBeg = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddPrOne = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddPrSf = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddRsOne = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddRsDoc = new DevExpress.XtraBars.BarButtonItem();
            this.bchiFilter = new DevExpress.XtraBars.BarCheckItem();
            this.bbiPredp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDolj = new DevExpress.XtraBars.BarButtonItem();
            this.beiLocate = new DevExpress.XtraBars.BarEditItem();
            this.ribeLocate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bbiEdIsm = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRepOther = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRep210104 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRep210106 = new DevExpress.XtraBars.BarButtonItem();
            this.biSkin = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbiChangeTovar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRemoveMove = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangePrDoc = new DevExpress.XtraBars.BarButtonItem();
            this.icLargeButtons = new DevExpress.Utils.ImageCollection(this.components);
            this.rpMoves = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPrihod = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRashod = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDicts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMatReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.icFolders = new DevExpress.Utils.ImageCollection(this.components);
            this.tpSklad = new DevExpress.XtraTab.XtraTabPage();
            this.gcSklad = new DevExpress.XtraGrid.GridControl();
            this.gvSklad = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklTovId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklNsch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklInvn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklEdism = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklNmcount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklNmsum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklPrcount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklPrsum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklRscount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklRssum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklKmcount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSklKmsum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSklNmNote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tpPrihod = new DevExpress.XtraTab.XtraTabPage();
            this.gcPrihod = new DevExpress.XtraGrid.GridControl();
            this.gvPrihod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrNsch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrInvn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrEdIsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrDateSf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrPredp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpRashod = new DevExpress.XtraTab.XtraTabPage();
            this.gcRashod = new DevExpress.XtraGrid.GridControl();
            this.gvRashod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRasId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasNsch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasEdism = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasDateRs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasFio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasPodr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasNtreb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRasDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pmSklMoves = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pmSklRashod = new DevExpress.XtraBars.PopupMenu(this.components);
            this.pmSklPrihod = new DevExpress.XtraBars.PopupMenu(this.components);
            this.rpgRepSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beiPodrazdName = new DevExpress.XtraBars.BarEditItem();
            this.ritePodrazdName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.beiUserName = new DevExpress.XtraBars.BarEditItem();
            this.riteUserName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icSmallButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeLocate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icLargeButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).BeginInit();
            this.tpSklad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSklad)).BeginInit();
            this.tpPrihod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrihod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrihod)).BeginInit();
            this.tpRashod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRashod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRashod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSklMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmSklRashod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSklPrihod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePodrazdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ApplicationDocumentCaption = "Склад 3";
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.icSmallButtons;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.beiMonth,
            this.bbiAddMBeg,
            this.bbiAddPrOne,
            this.bbiAddPrSf,
            this.bbiAddRsOne,
            this.bbiAddRsDoc,
            this.bchiFilter,
            this.bbiPredp,
            this.bbiDolj,
            this.beiLocate,
            this.bbiEdIsm,
            this.bbiRepOther,
            this.bbiRep210104,
            this.bbiRep210106,
            this.bbiImport,
            this.biSkin,
            this.bbiNewMonth,
            this.bbiChangeTovar,
            this.bbiRemoveMove,
            this.bbiChangePrDoc,
            this.beiPodrazdName,
            this.beiUserName});
            this.ribbon.LargeImages = this.icLargeButtons;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.bchiFilter);
            this.ribbon.PageHeaderItemLinks.Add(this.beiLocate);
            this.ribbon.PageHeaderItemLinks.Add(this.beiMonth);
            this.ribbon.PageHeaderItemLinks.Add(this.ribbon.ExpandCollapseItem);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMoves,
            this.rpReports,
            this.rpSettings});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbMonth,
            this.ribeLocate,
            this.ritePodrazdName,
            this.riteUserName});
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1000, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.bbiImport);
            this.applicationMenu1.ItemLinks.Add(this.bbiNewMonth);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "Импорт из Interbase";
            this.bbiImport.Id = 31;
            this.bbiImport.ImageIndex = 6;
            this.bbiImport.LargeImageIndex = 6;
            this.bbiImport.Name = "bbiImport";
            this.bbiImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImport_ItemClick);
            // 
            // bbiNewMonth
            // 
            this.bbiNewMonth.Caption = "Новый месяц";
            this.bbiNewMonth.Id = 7;
            this.bbiNewMonth.ImageIndex = 0;
            this.bbiNewMonth.LargeImageIndex = 0;
            this.bbiNewMonth.Name = "bbiNewMonth";
            this.bbiNewMonth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNewMonth_ItemClick);
            // 
            // icSmallButtons
            // 
            this.icSmallButtons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icSmallButtons.ImageStream")));
            this.icSmallButtons.Images.SetKeyName(0, "icon-plus.png");
            this.icSmallButtons.Images.SetKeyName(1, "edit_add_4280.png");
            this.icSmallButtons.Images.SetKeyName(2, "application_form_add.png");
            this.icSmallButtons.Images.SetKeyName(3, "application_form_delete.png");
            this.icSmallButtons.Images.SetKeyName(4, "add.png");
            this.icSmallButtons.Images.SetKeyName(5, "edit_remove.png");
            this.icSmallButtons.Images.SetKeyName(6, "database_go.png");
            // 
            // beiMonth
            // 
            this.beiMonth.Caption = "Месяц:";
            this.beiMonth.Edit = this.ricbMonth;
            this.beiMonth.EditWidth = 160;
            this.beiMonth.Id = 3;
            this.beiMonth.Name = "beiMonth";
            this.beiMonth.EditValueChanged += new System.EventHandler(this.beiMonth_EditValueChanged);
            // 
            // ricbMonth
            // 
            this.ricbMonth.AllowFocused = false;
            this.ricbMonth.Appearance.Options.UseTextOptions = true;
            this.ricbMonth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ricbMonth.AppearanceDropDown.Options.UseTextOptions = true;
            this.ricbMonth.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ricbMonth.AutoHeight = false;
            this.ricbMonth.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricbMonth.Name = "ricbMonth";
            this.ricbMonth.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // bbiAddMBeg
            // 
            this.bbiAddMBeg.Caption = "В начало месяца";
            this.bbiAddMBeg.Id = 5;
            this.bbiAddMBeg.ImageIndex = 0;
            this.bbiAddMBeg.LargeImageIndex = 0;
            this.bbiAddMBeg.Name = "bbiAddMBeg";
            this.bbiAddMBeg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddMBeg_ItemClick);
            // 
            // bbiAddPrOne
            // 
            this.bbiAddPrOne.Caption = "Одна единица";
            this.bbiAddPrOne.Id = 6;
            this.bbiAddPrOne.ImageIndex = 1;
            this.bbiAddPrOne.LargeImageIndex = 1;
            this.bbiAddPrOne.Name = "bbiAddPrOne";
            this.bbiAddPrOne.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddPrOne_ItemClick);
            // 
            // bbiAddPrSf
            // 
            this.bbiAddPrSf.Caption = "По документу";
            this.bbiAddPrSf.Id = 7;
            this.bbiAddPrSf.ImageIndex = 2;
            this.bbiAddPrSf.LargeImageIndex = 2;
            this.bbiAddPrSf.Name = "bbiAddPrSf";
            this.bbiAddPrSf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddPrSf_ItemClick);
            // 
            // bbiAddRsOne
            // 
            this.bbiAddRsOne.Caption = "Одна единица";
            this.bbiAddRsOne.Id = 8;
            this.bbiAddRsOne.ImageIndex = 5;
            this.bbiAddRsOne.LargeImageIndex = 5;
            this.bbiAddRsOne.Name = "bbiAddRsOne";
            this.bbiAddRsOne.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddRsOne_ItemClick);
            // 
            // bbiAddRsDoc
            // 
            this.bbiAddRsDoc.Caption = "Требоваие накладная";
            this.bbiAddRsDoc.Id = 9;
            this.bbiAddRsDoc.ImageIndex = 3;
            this.bbiAddRsDoc.LargeImageIndex = 3;
            this.bbiAddRsDoc.Name = "bbiAddRsDoc";
            this.bbiAddRsDoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddRsDoc_ItemClick);
            // 
            // bchiFilter
            // 
            this.bchiFilter.Caption = "Фильтр";
            this.bchiFilter.Glyph = ((System.Drawing.Image)(resources.GetObject("bchiFilter.Glyph")));
            this.bchiFilter.Id = 12;
            this.bchiFilter.Name = "bchiFilter";
            this.bchiFilter.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bchiFilter.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bchiFilter_CheckedChanged);
            // 
            // bbiPredp
            // 
            this.bbiPredp.Caption = "Предприятия";
            this.bbiPredp.Id = 15;
            this.bbiPredp.Name = "bbiPredp";
            // 
            // bbiDolj
            // 
            this.bbiDolj.Caption = "Должностные лица";
            this.bbiDolj.Id = 16;
            this.bbiDolj.Name = "bbiDolj";
            // 
            // beiLocate
            // 
            this.beiLocate.Edit = this.ribeLocate;
            this.beiLocate.EditWidth = 150;
            this.beiLocate.Id = 17;
            this.beiLocate.Name = "beiLocate";
            // 
            // ribeLocate
            // 
            this.ribeLocate.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ribeLocate.AutoHeight = false;
            this.ribeLocate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("ribeLocate.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeLocate.Name = "ribeLocate";
            this.ribeLocate.NullText = "Быстрый поиск";
            this.ribeLocate.NullValuePrompt = "Быстрый поиск";
            this.ribeLocate.NullValuePromptShowForEmptyValue = true;
            this.ribeLocate.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeLocate_ButtonPressed);
            this.ribeLocate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ribeLocate_EditValueChanging);
            // 
            // bbiEdIsm
            // 
            this.bbiEdIsm.Caption = "Единицы измерения";
            this.bbiEdIsm.Id = 20;
            this.bbiEdIsm.Name = "bbiEdIsm";
            // 
            // bbiRepOther
            // 
            this.bbiRepOther.Caption = "Остальные";
            this.bbiRepOther.Id = 27;
            this.bbiRepOther.LargeImageIndex = 2;
            this.bbiRepOther.Name = "bbiRepOther";
            this.bbiRepOther.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRepOther_ItemClick);
            // 
            // bbiRep210104
            // 
            this.bbiRep210104.Caption = "210104";
            this.bbiRep210104.Id = 28;
            this.bbiRep210104.Name = "bbiRep210104";
            this.bbiRep210104.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRep210104_ItemClick);
            // 
            // bbiRep210106
            // 
            this.bbiRep210106.Caption = "210106";
            this.bbiRep210106.Id = 29;
            this.bbiRep210106.Name = "bbiRep210106";
            this.bbiRep210106.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRep210106_ItemClick);
            // 
            // biSkin
            // 
            this.biSkin.Caption = "Обложка";
            this.biSkin.Id = 3;
            this.biSkin.Name = "biSkin";
            // 
            // bbiChangeTovar
            // 
            this.bbiChangeTovar.Caption = "Другое наименование";
            this.bbiChangeTovar.Id = 9;
            this.bbiChangeTovar.Name = "bbiChangeTovar";
            this.bbiChangeTovar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangeTovar_ItemClick);
            // 
            // bbiRemoveMove
            // 
            this.bbiRemoveMove.Caption = "Удалить";
            this.bbiRemoveMove.Id = 1;
            this.bbiRemoveMove.ImageIndex = 5;
            this.bbiRemoveMove.Name = "bbiRemoveMove";
            this.bbiRemoveMove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRemoveMove_ItemClick);
            // 
            // bbiChangePrDoc
            // 
            this.bbiChangePrDoc.Caption = "Другой документ";
            this.bbiChangePrDoc.Id = 2;
            this.bbiChangePrDoc.Name = "bbiChangePrDoc";
            this.bbiChangePrDoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePrDoc_ItemClick);
            // 
            // icLargeButtons
            // 
            this.icLargeButtons.ImageSize = new System.Drawing.Size(32, 32);
            this.icLargeButtons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icLargeButtons.ImageStream")));
            this.icLargeButtons.Images.SetKeyName(0, "1288439624_Add.png");
            this.icLargeButtons.Images.SetKeyName(1, "1288439637_edit_add.png");
            this.icLargeButtons.Images.SetKeyName(2, "1288439860_application_form_add.png");
            this.icLargeButtons.Images.SetKeyName(3, "application_form_delete.png");
            this.icLargeButtons.Images.SetKeyName(4, "edit_add.png");
            this.icLargeButtons.Images.SetKeyName(5, "edit_remove.png");
            this.icLargeButtons.Images.SetKeyName(6, "database_go.png");
            // 
            // rpMoves
            // 
            this.rpMoves.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPrihod,
            this.rpgRashod,
            this.rpgDicts});
            this.rpMoves.Name = "rpMoves";
            this.rpMoves.Text = "Движение товаров";
            // 
            // rpgPrihod
            // 
            this.rpgPrihod.ItemLinks.Add(this.bbiAddMBeg);
            this.rpgPrihod.ItemLinks.Add(this.bbiAddPrOne, true);
            this.rpgPrihod.ItemLinks.Add(this.bbiAddPrSf);
            this.rpgPrihod.Name = "rpgPrihod";
            this.rpgPrihod.ShowCaptionButton = false;
            this.rpgPrihod.Text = "Приход";
            // 
            // rpgRashod
            // 
            this.rpgRashod.ItemLinks.Add(this.bbiAddRsOne);
            this.rpgRashod.ItemLinks.Add(this.bbiAddRsDoc);
            this.rpgRashod.Name = "rpgRashod";
            this.rpgRashod.ShowCaptionButton = false;
            this.rpgRashod.Text = "Расход";
            // 
            // rpgDicts
            // 
            this.rpgDicts.ItemLinks.Add(this.bbiEdIsm, true);
            this.rpgDicts.ItemLinks.Add(this.bbiDolj);
            this.rpgDicts.ItemLinks.Add(this.bbiPredp);
            this.rpgDicts.Name = "rpgDicts";
            this.rpgDicts.ShowCaptionButton = false;
            this.rpgDicts.Text = "Справочники";
            // 
            // rpReports
            // 
            this.rpReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMatReport});
            this.rpReports.Name = "rpReports";
            this.rpReports.Text = "Отчеты";
            // 
            // rpgMatReport
            // 
            this.rpgMatReport.AllowTextClipping = false;
            this.rpgMatReport.ItemLinks.Add(this.bbiRep210104);
            this.rpgMatReport.ItemLinks.Add(this.bbiRep210106);
            this.rpgMatReport.ItemLinks.Add(this.bbiRepOther);
            this.rpgMatReport.Name = "rpgMatReport";
            this.rpgMatReport.ShowCaptionButton = false;
            this.rpgMatReport.Text = "Материальный отчет";
            // 
            // rpSettings
            // 
            this.rpSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSkin,
            this.rpgRepSettings});
            this.rpSettings.Name = "rpSettings";
            this.rpSettings.Text = "Настройки";
            // 
            // rpgSkin
            // 
            this.rpgSkin.ItemLinks.Add(this.biSkin);
            this.rpgSkin.Name = "rpgSkin";
            this.rpgSkin.ShowCaptionButton = false;
            this.rpgSkin.Text = "Обложка";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 735);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1000, 32);
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Images = this.icFolders;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpSklad;
            this.tcMain.Size = new System.Drawing.Size(997, 588);
            this.tcMain.TabIndex = 5;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPrihod,
            this.tpRashod,
            this.tpSklad});
            // 
            // icFolders
            // 
            this.icFolders.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icFolders.ImageStream")));
            this.icFolders.Images.SetKeyName(0, "folder.png");
            this.icFolders.Images.SetKeyName(1, "folder_inbox.png");
            this.icFolders.Images.SetKeyName(2, "folder_outbox.png");
            // 
            // tpSklad
            // 
            this.tpSklad.Controls.Add(this.gcSklad);
            this.tpSklad.ImageIndex = 0;
            this.tpSklad.Margin = new System.Windows.Forms.Padding(0);
            this.tpSklad.Name = "tpSklad";
            this.tpSklad.Size = new System.Drawing.Size(991, 557);
            this.tpSklad.Text = "Склад";
            // 
            // gcSklad
            // 
            this.gcSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSklad.Location = new System.Drawing.Point(0, 0);
            this.gcSklad.MainView = this.gvSklad;
            this.gcSklad.Margin = new System.Windows.Forms.Padding(0);
            this.gcSklad.MenuManager = this.ribbon;
            this.gcSklad.Name = "gcSklad";
            this.gcSklad.Size = new System.Drawing.Size(991, 557);
            this.gcSklad.TabIndex = 0;
            this.gcSklad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSklad});
            // 
            // gvSklad
            // 
            this.gvSklad.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gvSklad.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gvSklad.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.gvSklad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvSklad.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSklTovId,
            this.colSklNsch,
            this.colSklInvn,
            this.colSklName,
            this.colSklEdism,
            this.colSklPrice,
            this.colSklNmcount,
            this.colSklNmsum,
            this.colSklPrcount,
            this.colSklPrsum,
            this.colSklRscount,
            this.colSklRssum,
            this.colSklKmcount,
            this.colSklKmsum,
            this.colSklNmNote});
            this.gvSklad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvSklad.GridControl = this.gcSklad;
            this.gvSklad.Name = "gvSklad";
            this.gvSklad.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvSklad.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSklad.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvSklad.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvSklad.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSklad.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSklad.OptionsView.EnableAppearanceOddRow = true;
            this.gvSklad.OptionsView.ShowGroupPanel = false;
            this.gvSklad.OptionsView.ShowIndicator = false;
            this.gvSklad.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSklad.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSklName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvSklad.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvSklad_PopupMenuShowing);
            this.gvSklad.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSklad_CellValueChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colSklTovId);
            this.gridBand1.Columns.Add(this.colSklNsch);
            this.gridBand1.Columns.Add(this.colSklInvn);
            this.gridBand1.Columns.Add(this.colSklName);
            this.gridBand1.Columns.Add(this.colSklEdism);
            this.gridBand1.Columns.Add(this.colSklPrice);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 347;
            // 
            // colSklTovId
            // 
            this.colSklTovId.Caption = "Id";
            this.colSklTovId.FieldName = "Tovar.Id";
            this.colSklTovId.Name = "colSklTovId";
            this.colSklTovId.Width = 40;
            // 
            // colSklNsch
            // 
            this.colSklNsch.AppearanceCell.Options.UseTextOptions = true;
            this.colSklNsch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSklNsch.Caption = "н/сч";
            this.colSklNsch.FieldName = "Tovar.Nsch";
            this.colSklNsch.Name = "colSklNsch";
            this.colSklNsch.OptionsColumn.AllowShowHide = false;
            this.colSklNsch.Visible = true;
            this.colSklNsch.Width = 40;
            // 
            // colSklInvn
            // 
            this.colSklInvn.AppearanceCell.Options.UseTextOptions = true;
            this.colSklInvn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSklInvn.Caption = "Инв. номер";
            this.colSklInvn.FieldName = "Tovar.Invn";
            this.colSklInvn.Name = "colSklInvn";
            this.colSklInvn.OptionsColumn.AllowShowHide = false;
            this.colSklInvn.Visible = true;
            this.colSklInvn.Width = 78;
            // 
            // colSklName
            // 
            this.colSklName.Caption = "Наименование";
            this.colSklName.FieldName = "Tovar.Name";
            this.colSklName.Name = "colSklName";
            this.colSklName.OptionsColumn.AllowShowHide = false;
            this.colSklName.Visible = true;
            this.colSklName.Width = 114;
            // 
            // colSklEdism
            // 
            this.colSklEdism.AppearanceCell.Options.UseTextOptions = true;
            this.colSklEdism.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSklEdism.Caption = "е.и";
            this.colSklEdism.FieldName = "Tovar.EdIsm.Name";
            this.colSklEdism.Name = "colSklEdism";
            this.colSklEdism.OptionsColumn.AllowShowHide = false;
            this.colSklEdism.Visible = true;
            this.colSklEdism.Width = 35;
            // 
            // colSklPrice
            // 
            this.colSklPrice.Caption = "Цена";
            this.colSklPrice.DisplayFormat.FormatString = "0.00##";
            this.colSklPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSklPrice.FieldName = "Tovar.Price";
            this.colSklPrice.Name = "colSklPrice";
            this.colSklPrice.OptionsColumn.AllowShowHide = false;
            this.colSklPrice.Visible = true;
            this.colSklPrice.Width = 80;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "На начало месяца";
            this.gridBand2.Columns.Add(this.colSklNmcount);
            this.gridBand2.Columns.Add(this.colSklNmsum);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 104;
            // 
            // colSklNmcount
            // 
            this.colSklNmcount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklNmcount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklNmcount.Caption = "Кол-во";
            this.colSklNmcount.DisplayFormat.FormatString = "0.####";
            this.colSklNmcount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSklNmcount.FieldName = "Nm.Count";
            this.colSklNmcount.Name = "colSklNmcount";
            this.colSklNmcount.OptionsColumn.AllowShowHide = false;
            this.colSklNmcount.Visible = true;
            this.colSklNmcount.Width = 54;
            // 
            // colSklNmsum
            // 
            this.colSklNmsum.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklNmsum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklNmsum.Caption = "Сумма";
            this.colSklNmsum.DisplayFormat.FormatString = "0.00##";
            this.colSklNmsum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSklNmsum.FieldName = "NmSum";
            this.colSklNmsum.Name = "colSklNmsum";
            this.colSklNmsum.OptionsColumn.AllowEdit = false;
            this.colSklNmsum.OptionsColumn.AllowShowHide = false;
            this.colSklNmsum.Visible = true;
            this.colSklNmsum.Width = 50;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Приход";
            this.gridBand3.Columns.Add(this.colSklPrcount);
            this.gridBand3.Columns.Add(this.colSklPrsum);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 104;
            // 
            // colSklPrcount
            // 
            this.colSklPrcount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklPrcount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklPrcount.Caption = "Кол-во";
            this.colSklPrcount.DisplayFormat.FormatString = "{0:0.####;;\"\"}";
            this.colSklPrcount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklPrcount.FieldName = "PrCount";
            this.colSklPrcount.Name = "colSklPrcount";
            this.colSklPrcount.OptionsColumn.AllowEdit = false;
            this.colSklPrcount.OptionsColumn.AllowShowHide = false;
            this.colSklPrcount.Visible = true;
            this.colSklPrcount.Width = 54;
            // 
            // colSklPrsum
            // 
            this.colSklPrsum.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklPrsum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklPrsum.Caption = "Сумма";
            this.colSklPrsum.DisplayFormat.FormatString = "{0:0.00##;;\"\"}";
            this.colSklPrsum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklPrsum.FieldName = "PrSum";
            this.colSklPrsum.Name = "colSklPrsum";
            this.colSklPrsum.OptionsColumn.AllowEdit = false;
            this.colSklPrsum.OptionsColumn.AllowShowHide = false;
            this.colSklPrsum.Visible = true;
            this.colSklPrsum.Width = 50;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Расход";
            this.gridBand4.Columns.Add(this.colSklRscount);
            this.gridBand4.Columns.Add(this.colSklRssum);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 104;
            // 
            // colSklRscount
            // 
            this.colSklRscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklRscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklRscount.Caption = "Кол-во";
            this.colSklRscount.DisplayFormat.FormatString = "{0:0.####;;\"\"}";
            this.colSklRscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklRscount.FieldName = "RsCount";
            this.colSklRscount.Name = "colSklRscount";
            this.colSklRscount.OptionsColumn.AllowEdit = false;
            this.colSklRscount.OptionsColumn.AllowShowHide = false;
            this.colSklRscount.Visible = true;
            this.colSklRscount.Width = 54;
            // 
            // colSklRssum
            // 
            this.colSklRssum.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklRssum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklRssum.Caption = "Сумма";
            this.colSklRssum.DisplayFormat.FormatString = "{0:0.00##;;\"\"}";
            this.colSklRssum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklRssum.FieldName = "RsSum";
            this.colSklRssum.Name = "colSklRssum";
            this.colSklRssum.OptionsColumn.AllowEdit = false;
            this.colSklRssum.OptionsColumn.AllowShowHide = false;
            this.colSklRssum.Visible = true;
            this.colSklRssum.Width = 50;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Остаток";
            this.gridBand5.Columns.Add(this.colSklKmcount);
            this.gridBand5.Columns.Add(this.colSklKmsum);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 104;
            // 
            // colSklKmcount
            // 
            this.colSklKmcount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklKmcount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklKmcount.Caption = "Кол-во";
            this.colSklKmcount.DisplayFormat.FormatString = "{0:0.####;;\"\"}";
            this.colSklKmcount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklKmcount.FieldName = "KmCount";
            this.colSklKmcount.Name = "colSklKmcount";
            this.colSklKmcount.OptionsColumn.AllowEdit = false;
            this.colSklKmcount.OptionsColumn.AllowShowHide = false;
            this.colSklKmcount.Visible = true;
            this.colSklKmcount.Width = 54;
            // 
            // colSklKmsum
            // 
            this.colSklKmsum.AppearanceHeader.Options.UseTextOptions = true;
            this.colSklKmsum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSklKmsum.Caption = "Сумма";
            this.colSklKmsum.DisplayFormat.FormatString = "{0:0.00##;;\"\"}";
            this.colSklKmsum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSklKmsum.FieldName = "KmSum";
            this.colSklKmsum.Name = "colSklKmsum";
            this.colSklKmsum.OptionsColumn.AllowEdit = false;
            this.colSklKmsum.OptionsColumn.AllowShowHide = false;
            this.colSklKmsum.Visible = true;
            this.colSklKmsum.Width = 50;
            // 
            // gridBand6
            // 
            this.gridBand6.Columns.Add(this.colSklNmNote);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.OptionsBand.ShowCaption = false;
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 313;
            // 
            // colSklNmNote
            // 
            this.colSklNmNote.Caption = "Примечание";
            this.colSklNmNote.FieldName = "Tovar.Note";
            this.colSklNmNote.Name = "colSklNmNote";
            this.colSklNmNote.Visible = true;
            this.colSklNmNote.Width = 313;
            // 
            // tpPrihod
            // 
            this.tpPrihod.Controls.Add(this.gcPrihod);
            this.tpPrihod.ImageIndex = 1;
            this.tpPrihod.Margin = new System.Windows.Forms.Padding(0);
            this.tpPrihod.Name = "tpPrihod";
            this.tpPrihod.Size = new System.Drawing.Size(991, 551);
            this.tpPrihod.Text = "Приход";
            // 
            // gcPrihod
            // 
            this.gcPrihod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrihod.Location = new System.Drawing.Point(0, 0);
            this.gcPrihod.MainView = this.gvPrihod;
            this.gcPrihod.Margin = new System.Windows.Forms.Padding(0);
            this.gcPrihod.MenuManager = this.ribbon;
            this.gcPrihod.Name = "gcPrihod";
            this.gcPrihod.Size = new System.Drawing.Size(991, 551);
            this.gcPrihod.TabIndex = 0;
            this.gcPrihod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrihod});
            // 
            // gvPrihod
            // 
            this.gvPrihod.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPrihod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrId,
            this.colPrNsch,
            this.colPrInvn,
            this.colPrName,
            this.colPrEdIsm,
            this.colPrPrice,
            this.colPrCount,
            this.colPrSum,
            this.colPrDate,
            this.colPrType,
            this.colPrNum,
            this.colPrDateSf,
            this.colPrPredp});
            this.gvPrihod.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvPrihod.GridControl = this.gcPrihod;
            this.gvPrihod.Name = "gvPrihod";
            this.gvPrihod.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvPrihod.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPrihod.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPrihod.OptionsView.ColumnAutoWidth = false;
            this.gvPrihod.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrihod.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrihod.OptionsView.ShowGroupPanel = false;
            this.gvPrihod.OptionsView.ShowIndicator = false;
            this.gvPrihod.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvPrihod.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPrId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPrihod.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPrihod_PopupMenuShowing);
            this.gvPrihod.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSklad_CellValueChanged);
            // 
            // colPrId
            // 
            this.colPrId.Caption = "#";
            this.colPrId.FieldName = "Id";
            this.colPrId.MinWidth = 40;
            this.colPrId.Name = "colPrId";
            this.colPrId.OptionsColumn.AllowEdit = false;
            this.colPrId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrId.OptionsColumn.AllowShowHide = false;
            this.colPrId.OptionsFilter.AllowAutoFilter = false;
            this.colPrId.OptionsFilter.AllowFilter = false;
            this.colPrId.Visible = true;
            this.colPrId.VisibleIndex = 0;
            this.colPrId.Width = 40;
            // 
            // colPrNsch
            // 
            this.colPrNsch.AppearanceCell.Options.UseTextOptions = true;
            this.colPrNsch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrNsch.Caption = "н/сч";
            this.colPrNsch.FieldName = "Tovar.Nsch";
            this.colPrNsch.Name = "colPrNsch";
            this.colPrNsch.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrNsch.OptionsColumn.AllowShowHide = false;
            this.colPrNsch.Visible = true;
            this.colPrNsch.VisibleIndex = 1;
            this.colPrNsch.Width = 37;
            // 
            // colPrInvn
            // 
            this.colPrInvn.AppearanceCell.Options.UseTextOptions = true;
            this.colPrInvn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrInvn.Caption = "Инв. номер";
            this.colPrInvn.FieldName = "Tovar.Invn";
            this.colPrInvn.Name = "colPrInvn";
            this.colPrInvn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrInvn.OptionsColumn.AllowShowHide = false;
            this.colPrInvn.Visible = true;
            this.colPrInvn.VisibleIndex = 2;
            this.colPrInvn.Width = 78;
            // 
            // colPrName
            // 
            this.colPrName.Caption = "Наименование";
            this.colPrName.FieldName = "Tovar.Name";
            this.colPrName.Name = "colPrName";
            this.colPrName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrName.OptionsColumn.AllowShowHide = false;
            this.colPrName.Visible = true;
            this.colPrName.VisibleIndex = 3;
            this.colPrName.Width = 114;
            // 
            // colPrEdIsm
            // 
            this.colPrEdIsm.AppearanceCell.Options.UseTextOptions = true;
            this.colPrEdIsm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrEdIsm.Caption = "е.и";
            this.colPrEdIsm.FieldName = "Tovar.EdIsm.Name";
            this.colPrEdIsm.Name = "colPrEdIsm";
            this.colPrEdIsm.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrEdIsm.OptionsColumn.AllowShowHide = false;
            this.colPrEdIsm.Visible = true;
            this.colPrEdIsm.VisibleIndex = 4;
            this.colPrEdIsm.Width = 30;
            // 
            // colPrPrice
            // 
            this.colPrPrice.Caption = "Цена";
            this.colPrPrice.DisplayFormat.FormatString = "0.00##";
            this.colPrPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrPrice.FieldName = "Tovar.Price";
            this.colPrPrice.Name = "colPrPrice";
            this.colPrPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrPrice.OptionsColumn.AllowShowHide = false;
            this.colPrPrice.Visible = true;
            this.colPrPrice.VisibleIndex = 5;
            this.colPrPrice.Width = 42;
            // 
            // colPrCount
            // 
            this.colPrCount.Caption = "Кол-во";
            this.colPrCount.DisplayFormat.FormatString = "0.####";
            this.colPrCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrCount.FieldName = "Count";
            this.colPrCount.Name = "colPrCount";
            this.colPrCount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrCount.OptionsColumn.AllowShowHide = false;
            this.colPrCount.Visible = true;
            this.colPrCount.VisibleIndex = 6;
            this.colPrCount.Width = 52;
            // 
            // colPrSum
            // 
            this.colPrSum.Caption = "Сумма";
            this.colPrSum.DisplayFormat.FormatString = "0.00##";
            this.colPrSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrSum.FieldName = "TotalPrice";
            this.colPrSum.Name = "colPrSum";
            this.colPrSum.OptionsColumn.AllowEdit = false;
            this.colPrSum.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrSum.OptionsColumn.AllowShowHide = false;
            this.colPrSum.Visible = true;
            this.colPrSum.VisibleIndex = 7;
            this.colPrSum.Width = 49;
            // 
            // colPrDate
            // 
            this.colPrDate.Caption = "Дата прихода";
            this.colPrDate.FieldName = "Date";
            this.colPrDate.Name = "colPrDate";
            this.colPrDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrDate.OptionsColumn.AllowShowHide = false;
            this.colPrDate.Visible = true;
            this.colPrDate.VisibleIndex = 8;
            this.colPrDate.Width = 93;
            // 
            // colPrType
            // 
            this.colPrType.Caption = "Тип";
            this.colPrType.FieldName = "TypeDoc";
            this.colPrType.Name = "colPrType";
            this.colPrType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrType.OptionsColumn.AllowShowHide = false;
            this.colPrType.Visible = true;
            this.colPrType.VisibleIndex = 9;
            this.colPrType.Width = 34;
            // 
            // colPrNum
            // 
            this.colPrNum.Caption = "Номер";
            this.colPrNum.FieldName = "SFact.Number";
            this.colPrNum.Name = "colPrNum";
            this.colPrNum.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrNum.OptionsColumn.AllowShowHide = false;
            this.colPrNum.Visible = true;
            this.colPrNum.VisibleIndex = 10;
            this.colPrNum.Width = 49;
            // 
            // colPrDateSf
            // 
            this.colPrDateSf.Caption = "Дата";
            this.colPrDateSf.FieldName = "SFact.Date";
            this.colPrDateSf.Name = "colPrDateSf";
            this.colPrDateSf.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrDateSf.OptionsColumn.AllowShowHide = false;
            this.colPrDateSf.Visible = true;
            this.colPrDateSf.VisibleIndex = 11;
            this.colPrDateSf.Width = 51;
            // 
            // colPrPredp
            // 
            this.colPrPredp.Caption = "Предприятие";
            this.colPrPredp.FieldName = "SFact.Predp.Name";
            this.colPrPredp.Name = "colPrPredp";
            this.colPrPredp.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPrPredp.OptionsColumn.AllowShowHide = false;
            this.colPrPredp.Visible = true;
            this.colPrPredp.VisibleIndex = 12;
            this.colPrPredp.Width = 89;
            // 
            // tpRashod
            // 
            this.tpRashod.Controls.Add(this.gcRashod);
            this.tpRashod.ImageIndex = 2;
            this.tpRashod.Name = "tpRashod";
            this.tpRashod.Size = new System.Drawing.Size(991, 551);
            this.tpRashod.Text = "Расход";
            // 
            // gcRashod
            // 
            this.gcRashod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRashod.Location = new System.Drawing.Point(0, 0);
            this.gcRashod.MainView = this.gvRashod;
            this.gcRashod.Margin = new System.Windows.Forms.Padding(0);
            this.gcRashod.MenuManager = this.ribbon;
            this.gcRashod.Name = "gcRashod";
            this.gcRashod.Size = new System.Drawing.Size(991, 551);
            this.gcRashod.TabIndex = 1;
            this.gcRashod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRashod});
            // 
            // gvRashod
            // 
            this.gvRashod.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvRashod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRasId,
            this.colRasNsch,
            this.colInvn,
            this.colRasName,
            this.colRasEdism,
            this.colRasPrice,
            this.colRasCount,
            this.colRasSum,
            this.colRasDateRs,
            this.colRasFio,
            this.colRasPodr,
            this.colRasNtreb,
            this.colRasDate});
            this.gvRashod.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvRashod.GridControl = this.gcRashod;
            this.gvRashod.Name = "gvRashod";
            this.gvRashod.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvRashod.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRashod.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvRashod.OptionsView.ColumnAutoWidth = false;
            this.gvRashod.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRashod.OptionsView.EnableAppearanceOddRow = true;
            this.gvRashod.OptionsView.ShowGroupPanel = false;
            this.gvRashod.OptionsView.ShowIndicator = false;
            this.gvRashod.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvRashod.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRasId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvRashod.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvRashod_PopupMenuShowing);
            this.gvRashod.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSklad_CellValueChanged);
            // 
            // colRasId
            // 
            this.colRasId.Caption = "#";
            this.colRasId.FieldName = "Id";
            this.colRasId.MinWidth = 40;
            this.colRasId.Name = "colRasId";
            this.colRasId.OptionsColumn.AllowEdit = false;
            this.colRasId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRasId.OptionsColumn.AllowShowHide = false;
            this.colRasId.OptionsFilter.AllowAutoFilter = false;
            this.colRasId.OptionsFilter.AllowFilter = false;
            this.colRasId.Visible = true;
            this.colRasId.VisibleIndex = 0;
            this.colRasId.Width = 40;
            // 
            // colRasNsch
            // 
            this.colRasNsch.AppearanceCell.Options.UseTextOptions = true;
            this.colRasNsch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRasNsch.Caption = "н/сч";
            this.colRasNsch.FieldName = "Tovar.Nsch";
            this.colRasNsch.Name = "colRasNsch";
            this.colRasNsch.OptionsColumn.AllowShowHide = false;
            this.colRasNsch.Visible = true;
            this.colRasNsch.VisibleIndex = 1;
            this.colRasNsch.Width = 48;
            // 
            // colInvn
            // 
            this.colInvn.AppearanceCell.Options.UseTextOptions = true;
            this.colInvn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvn.Caption = "Инв. номер";
            this.colInvn.FieldName = "Tovar.Invn";
            this.colInvn.Name = "colInvn";
            this.colInvn.OptionsColumn.AllowShowHide = false;
            this.colInvn.Visible = true;
            this.colInvn.VisibleIndex = 2;
            this.colInvn.Width = 92;
            // 
            // colRasName
            // 
            this.colRasName.Caption = "Наименование";
            this.colRasName.FieldName = "Tovar.Name";
            this.colRasName.Name = "colRasName";
            this.colRasName.OptionsColumn.AllowShowHide = false;
            this.colRasName.Visible = true;
            this.colRasName.VisibleIndex = 3;
            this.colRasName.Width = 114;
            // 
            // colRasEdism
            // 
            this.colRasEdism.AppearanceCell.Options.UseTextOptions = true;
            this.colRasEdism.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRasEdism.Caption = "е.и";
            this.colRasEdism.FieldName = "Tovar.EdIsm.Name";
            this.colRasEdism.Name = "colRasEdism";
            this.colRasEdism.OptionsColumn.AllowShowHide = false;
            this.colRasEdism.Visible = true;
            this.colRasEdism.VisibleIndex = 4;
            this.colRasEdism.Width = 30;
            // 
            // colRasPrice
            // 
            this.colRasPrice.Caption = "Цена";
            this.colRasPrice.DisplayFormat.FormatString = "0.00##";
            this.colRasPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRasPrice.FieldName = "Tovar.Price";
            this.colRasPrice.Name = "colRasPrice";
            this.colRasPrice.OptionsColumn.AllowShowHide = false;
            this.colRasPrice.Visible = true;
            this.colRasPrice.VisibleIndex = 5;
            this.colRasPrice.Width = 42;
            // 
            // colRasCount
            // 
            this.colRasCount.Caption = "Кол-во";
            this.colRasCount.DisplayFormat.FormatString = "0.####";
            this.colRasCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRasCount.FieldName = "Count";
            this.colRasCount.Name = "colRasCount";
            this.colRasCount.OptionsColumn.AllowShowHide = false;
            this.colRasCount.Visible = true;
            this.colRasCount.VisibleIndex = 6;
            this.colRasCount.Width = 59;
            // 
            // colRasSum
            // 
            this.colRasSum.Caption = "Сумма";
            this.colRasSum.DisplayFormat.FormatString = "0.00##";
            this.colRasSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRasSum.FieldName = "TotalPrice";
            this.colRasSum.Name = "colRasSum";
            this.colRasSum.OptionsColumn.AllowEdit = false;
            this.colRasSum.OptionsColumn.AllowShowHide = false;
            this.colRasSum.Visible = true;
            this.colRasSum.VisibleIndex = 7;
            this.colRasSum.Width = 72;
            // 
            // colRasDateRs
            // 
            this.colRasDateRs.Caption = "Дата расхода";
            this.colRasDateRs.FieldName = "Date";
            this.colRasDateRs.Name = "colRasDateRs";
            this.colRasDateRs.OptionsColumn.AllowShowHide = false;
            this.colRasDateRs.Visible = true;
            this.colRasDateRs.VisibleIndex = 8;
            this.colRasDateRs.Width = 92;
            // 
            // colRasFio
            // 
            this.colRasFio.Caption = "Получатель";
            this.colRasFio.FieldName = "Doc.Dolj.Name";
            this.colRasFio.Name = "colRasFio";
            this.colRasFio.OptionsColumn.AllowShowHide = false;
            this.colRasFio.Visible = true;
            this.colRasFio.VisibleIndex = 9;
            this.colRasFio.Width = 81;
            // 
            // colRasPodr
            // 
            this.colRasPodr.Caption = "Структурное подразделение";
            this.colRasPodr.FieldName = "Doc.Podr.Name";
            this.colRasPodr.Name = "colRasPodr";
            this.colRasPodr.OptionsColumn.AllowShowHide = false;
            this.colRasPodr.Visible = true;
            this.colRasPodr.VisibleIndex = 10;
            this.colRasPodr.Width = 179;
            // 
            // colRasNtreb
            // 
            this.colRasNtreb.Caption = "№ тр";
            this.colRasNtreb.FieldName = "Doc.Number";
            this.colRasNtreb.Name = "colRasNtreb";
            this.colRasNtreb.OptionsColumn.AllowShowHide = false;
            this.colRasNtreb.Visible = true;
            this.colRasNtreb.VisibleIndex = 11;
            this.colRasNtreb.Width = 44;
            // 
            // colRasDate
            // 
            this.colRasDate.Caption = "Дата";
            this.colRasDate.FieldName = "Doc.Date";
            this.colRasDate.Name = "colRasDate";
            this.colRasDate.OptionsColumn.AllowShowHide = false;
            this.colRasDate.Visible = true;
            this.colRasDate.VisibleIndex = 12;
            this.colRasDate.Width = 41;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // pmSklMoves
            // 
            this.pmSklMoves.ItemLinks.Add(this.bbiChangeTovar);
            this.pmSklMoves.Name = "pmSklMoves";
            this.pmSklMoves.Ribbon = this.ribbon;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.tcMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 144);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panelControl1.Size = new System.Drawing.Size(1000, 591);
            this.panelControl1.TabIndex = 4;
            // 
            // pmSklRashod
            // 
            this.pmSklRashod.ItemLinks.Add(this.bbiChangeTovar);
            this.pmSklRashod.ItemLinks.Add(this.bbiChangePrDoc);
            this.pmSklRashod.ItemLinks.Add(this.bbiRemoveMove);
            this.pmSklRashod.Name = "pmSklRashod";
            this.pmSklRashod.Ribbon = this.ribbon;
            // 
            // pmSklPrihod
            // 
            this.pmSklPrihod.ItemLinks.Add(this.bbiChangeTovar);
            this.pmSklPrihod.ItemLinks.Add(this.bbiChangePrDoc);
            this.pmSklPrihod.ItemLinks.Add(this.bbiRemoveMove);
            this.pmSklPrihod.Name = "pmSklPrihod";
            this.pmSklPrihod.Ribbon = this.ribbon;
            // 
            // rpgRepSettings
            // 
            this.rpgRepSettings.ItemLinks.Add(this.beiPodrazdName);
            this.rpgRepSettings.ItemLinks.Add(this.beiUserName);
            this.rpgRepSettings.Name = "rpgRepSettings";
            this.rpgRepSettings.Text = "Отчеты";
            // 
            // beiPodrazdName
            // 
            this.beiPodrazdName.Caption = "Подразделение";
            this.beiPodrazdName.Edit = this.ritePodrazdName;
            this.beiPodrazdName.EditWidth = 150;
            this.beiPodrazdName.Id = 4;
            this.beiPodrazdName.Name = "beiPodrazdName";
            this.beiPodrazdName.EditValueChanged += new System.EventHandler(this.beiPodrazdName_EditValueChanged);
            // 
            // ritePodrazdName
            // 
            this.ritePodrazdName.AutoHeight = false;
            this.ritePodrazdName.Name = "ritePodrazdName";
            // 
            // beiUserName
            // 
            this.beiUserName.Caption = "Пользователь";
            this.beiUserName.Edit = this.riteUserName;
            this.beiUserName.EditWidth = 150;
            this.beiUserName.Id = 5;
            this.beiUserName.Name = "beiUserName";
            this.beiUserName.EditValueChanged += new System.EventHandler(this.beiUserName_EditValueChanged);
            // 
            // riteUserName
            // 
            this.riteUserName.AutoHeight = false;
            this.riteUserName.Name = "riteUserName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 767);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Склад 3";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icSmallButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeLocate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icLargeButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).EndInit();
            this.tpSklad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSklad)).EndInit();
            this.tpPrihod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrihod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrihod)).EndInit();
            this.tpRashod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRashod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRashod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSklMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pmSklRashod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSklPrihod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePodrazdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMoves;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpPrihod;
        private DevExpress.XtraTab.XtraTabPage tpRashod;
        private DevExpress.XtraTab.XtraTabPage tpSklad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrihod;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRashod;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReports;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSettings;
        private DevExpress.XtraGrid.GridControl gcPrihod;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarEditItem beiMonth;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricbMonth;
        private DevExpress.XtraGrid.GridControl gcRashod;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRashod;
        private DevExpress.XtraGrid.Columns.GridColumn colRasId;
        private DevExpress.XtraGrid.Columns.GridColumn colRasNsch;
        private DevExpress.XtraGrid.Columns.GridColumn colRasName;
        private DevExpress.XtraGrid.Columns.GridColumn colRasEdism;
        private DevExpress.XtraGrid.Columns.GridColumn colRasPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRasCount;
        private DevExpress.XtraGrid.Columns.GridColumn colRasSum;
        private DevExpress.XtraGrid.Columns.GridColumn colRasDateRs;
        private DevExpress.XtraGrid.Columns.GridColumn colRasFio;
        private DevExpress.XtraGrid.Columns.GridColumn colRasPodr;
        private DevExpress.XtraGrid.Columns.GridColumn colRasNtreb;
        private DevExpress.XtraGrid.Columns.GridColumn colRasDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvn;
        private DevExpress.XtraGrid.GridControl gcSklad;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrihod;
        private DevExpress.XtraGrid.Columns.GridColumn colPrId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrNsch;
        private DevExpress.XtraGrid.Columns.GridColumn colPrInvn;
        private DevExpress.XtraGrid.Columns.GridColumn colPrName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrEdIsm;
        private DevExpress.XtraGrid.Columns.GridColumn colPrPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPrCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrSum;
        private DevExpress.XtraGrid.Columns.GridColumn colPrDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrNum;
        private DevExpress.XtraGrid.Columns.GridColumn colPrDateSf;
        private DevExpress.XtraGrid.Columns.GridColumn colPrPredp;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gvSklad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklInvn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklNsch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklEdism;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklNmcount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklNmsum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklPrcount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklPrsum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklRscount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklRssum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklKmcount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklKmsum;
        private DevExpress.XtraBars.BarButtonItem bbiAddMBeg;
        private DevExpress.XtraBars.BarButtonItem bbiAddPrOne;
        private DevExpress.XtraBars.BarButtonItem bbiAddPrSf;
        private DevExpress.XtraBars.BarButtonItem bbiAddRsOne;
        private DevExpress.XtraBars.BarButtonItem bbiAddRsDoc;
        private DevExpress.Utils.ImageCollection icFolders;
        private DevExpress.XtraBars.BarCheckItem bchiFilter;
        private DevExpress.XtraBars.BarButtonItem bbiPredp;
        private DevExpress.XtraBars.BarButtonItem bbiDolj;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDicts;
        private DevExpress.Utils.ImageCollection icLargeButtons;
        private DevExpress.XtraBars.BarEditItem beiLocate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeLocate;
        private DevExpress.XtraBars.BarButtonItem bbiEdIsm;
        private DevExpress.XtraBars.PopupMenu pmSklMoves;
        private DevExpress.XtraBars.BarButtonItem bbiRepOther;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMatReport;
        private DevExpress.XtraBars.BarButtonItem bbiRep210104;
        private DevExpress.XtraBars.BarButtonItem bbiRep210106;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem biSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem bbiNewMonth;
        private DevExpress.XtraBars.BarButtonItem bbiChangeTovar;
        private DevExpress.XtraBars.PopupMenu pmSklRashod;
        private DevExpress.XtraBars.PopupMenu pmSklPrihod;
        private DevExpress.XtraBars.BarButtonItem bbiRemoveMove;
        private DevExpress.Utils.ImageCollection icSmallButtons;
        private DevExpress.XtraBars.BarButtonItem bbiChangePrDoc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklTovId;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSklNmNote;
        private DevExpress.XtraBars.BarEditItem beiPodrazdName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritePodrazdName;
        private DevExpress.XtraBars.BarEditItem beiUserName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteUserName;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRepSettings;
    }
}