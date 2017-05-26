namespace Sklad3.UI
{
    partial class FormAddRsDoc
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
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcTovars = new DevExpress.XtraGrid.GridControl();
            this.gvTovars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbDolj = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deDateDoc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcAddDoc = new DevExpress.XtraEditors.PanelControl();
            this.seNumDoc = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbPodr = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbDocType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chbAddToDoc = new DevExpress.XtraEditors.CheckButton();
            this.chbNewDoc = new DevExpress.XtraEditors.CheckButton();
            this.pcSelDoc = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lcPodr = new DevExpress.XtraEditors.LabelControl();
            this.lcDolj = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.glueRsDoc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gluevRsDoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbAddTov = new DevExpress.XtraEditors.SimpleButton();
            this.selExistTov = new Sklad3.UI.SelectExistTovar();
            this.validProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDolj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddDoc)).BeginInit();
            this.pcAddDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNumDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPodr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSelDoc)).BeginInit();
            this.pcSelDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueRsDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevRsDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(256, 360);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Отмена";
            // 
            // gcTovars
            // 
            this.gcTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTovars.Location = new System.Drawing.Point(352, 0);
            this.gcTovars.MainView = this.gvTovars;
            this.gcTovars.Name = "gcTovars";
            this.gcTovars.Size = new System.Drawing.Size(562, 390);
            this.gcTovars.TabIndex = 4;
            this.gcTovars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTovars});
            this.gcTovars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcTovars_KeyDown);
            // 
            // gvTovars
            // 
            this.gvTovars.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvTovars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvTovars.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvTovars.GridControl = this.gcTovars;
            this.gvTovars.Name = "gvTovars";
            this.gvTovars.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTovars.OptionsView.ShowGroupPanel = false;
            this.gvTovars.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "н/сч";
            this.gridColumn2.FieldName = "Tovar.Nsch";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 40;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "и/н";
            this.gridColumn3.FieldName = "Tovar.Invn";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 35;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наименование";
            this.gridColumn1.FieldName = "Tovar.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 92;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "е.и";
            this.gridColumn4.FieldName = "Tovar.EdIsm";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 35;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Цена";
            this.gridColumn5.FieldName = "Tovar.Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 45;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Количество";
            this.gridColumn6.FieldName = "Count";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 79;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(176, 360);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "Готово";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Должностное лицо";
            // 
            // cbDolj
            // 
            this.cbDolj.Location = new System.Drawing.Point(8, 64);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDolj.Properties.ImmediatePopup = true;
            this.cbDolj.Properties.MaxLength = 50;
            this.cbDolj.Properties.Sorted = true;
            this.cbDolj.Size = new System.Drawing.Size(320, 20);
            this.cbDolj.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(224, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Дата документа";
            // 
            // deDateDoc
            // 
            this.deDateDoc.EditValue = null;
            this.deDateDoc.Location = new System.Drawing.Point(224, 24);
            this.deDateDoc.Name = "deDateDoc";
            this.deDateDoc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDateDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateDoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDateDoc.Size = new System.Drawing.Size(104, 20);
            this.deDateDoc.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Номер документа";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(240, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Дата расхода";
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(240, 24);
            this.deDate.Name = "deDate";
            this.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDate.Size = new System.Drawing.Size(96, 20);
            this.deDate.TabIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pcAddDoc);
            this.panelControl1.Controls.Add(this.chbAddToDoc);
            this.panelControl1.Controls.Add(this.chbNewDoc);
            this.panelControl1.Controls.Add(this.pcSelDoc);
            this.panelControl1.Controls.Add(this.btCancel);
            this.panelControl1.Controls.Add(this.btAdd);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.deDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbMonth);
            this.panelControl1.Controls.Add(this.cbAddTov);
            this.panelControl1.Controls.Add(this.selExistTov);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(352, 390);
            this.panelControl1.TabIndex = 3;
            // 
            // pcAddDoc
            // 
            this.pcAddDoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcAddDoc.Controls.Add(this.seNumDoc);
            this.pcAddDoc.Controls.Add(this.labelControl3);
            this.pcAddDoc.Controls.Add(this.cbPodr);
            this.pcAddDoc.Controls.Add(this.labelControl4);
            this.pcAddDoc.Controls.Add(this.labelControl6);
            this.pcAddDoc.Controls.Add(this.deDateDoc);
            this.pcAddDoc.Controls.Add(this.cbDocType);
            this.pcAddDoc.Controls.Add(this.cbDolj);
            this.pcAddDoc.Controls.Add(this.labelControl5);
            this.pcAddDoc.Location = new System.Drawing.Point(8, 72);
            this.pcAddDoc.Name = "pcAddDoc";
            this.pcAddDoc.Size = new System.Drawing.Size(336, 128);
            this.pcAddDoc.TabIndex = 23;
            // 
            // seNumDoc
            // 
            this.seNumDoc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seNumDoc.Location = new System.Drawing.Point(8, 24);
            this.seNumDoc.Name = "seNumDoc";
            this.seNumDoc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seNumDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seNumDoc.Properties.IsFloatValue = false;
            this.seNumDoc.Properties.Mask.EditMask = "N00";
            this.seNumDoc.Size = new System.Drawing.Size(72, 20);
            this.seNumDoc.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Структурное подразделение";
            // 
            // cbPodr
            // 
            this.cbPodr.Location = new System.Drawing.Point(8, 104);
            this.cbPodr.Name = "cbPodr";
            this.cbPodr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPodr.Properties.ImmediatePopup = true;
            this.cbPodr.Properties.MaxLength = 50;
            this.cbPodr.Properties.Sorted = true;
            this.cbPodr.Size = new System.Drawing.Size(320, 20);
            this.cbPodr.TabIndex = 18;
            // 
            // cbDocType
            // 
            this.cbDocType.Location = new System.Drawing.Point(86, 24);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDocType.Properties.ImmediatePopup = true;
            this.cbDocType.Properties.MaxLength = 50;
            this.cbDocType.Properties.NullValuePrompt = "Выберите тип";
            this.cbDocType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cbDocType.Properties.Sorted = true;
            this.cbDocType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDocType.Size = new System.Drawing.Size(132, 20);
            this.cbDocType.TabIndex = 18;
            // 
            // chbAddToDoc
            // 
            this.chbAddToDoc.Location = new System.Drawing.Point(136, 48);
            this.chbAddToDoc.Name = "chbAddToDoc";
            this.chbAddToDoc.Size = new System.Drawing.Size(152, 23);
            this.chbAddToDoc.TabIndex = 27;
            this.chbAddToDoc.Text = "Прикрепить к документу";
            this.chbAddToDoc.CheckedChanged += new System.EventHandler(this.chbAddToDoc_CheckedChanged);
            // 
            // chbNewDoc
            // 
            this.chbNewDoc.Checked = true;
            this.chbNewDoc.Location = new System.Drawing.Point(16, 48);
            this.chbNewDoc.Name = "chbNewDoc";
            this.chbNewDoc.Size = new System.Drawing.Size(112, 23);
            this.chbNewDoc.TabIndex = 26;
            this.chbNewDoc.Text = "Новый документ";
            this.chbNewDoc.CheckedChanged += new System.EventHandler(this.chbNewDoc_CheckedChanged);
            // 
            // pcSelDoc
            // 
            this.pcSelDoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSelDoc.Controls.Add(this.labelControl9);
            this.pcSelDoc.Controls.Add(this.lcPodr);
            this.pcSelDoc.Controls.Add(this.lcDolj);
            this.pcSelDoc.Controls.Add(this.labelControl8);
            this.pcSelDoc.Controls.Add(this.labelControl7);
            this.pcSelDoc.Controls.Add(this.glueRsDoc);
            this.pcSelDoc.Location = new System.Drawing.Point(8, 72);
            this.pcSelDoc.Name = "pcSelDoc";
            this.pcSelDoc.Size = new System.Drawing.Size(336, 128);
            this.pcSelDoc.TabIndex = 25;
            this.pcSelDoc.Visible = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 80);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(149, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Структурное подразделение";
            // 
            // lcPodr
            // 
            this.lcPodr.Location = new System.Drawing.Point(16, 96);
            this.lcPodr.Name = "lcPodr";
            this.lcPodr.Size = new System.Drawing.Size(29, 13);
            this.lcPodr.TabIndex = 1;
            this.lcPodr.Text = "lcPodr";
            // 
            // lcDolj
            // 
            this.lcDolj.Location = new System.Drawing.Point(16, 64);
            this.lcDolj.Name = "lcDolj";
            this.lcDolj.Size = new System.Drawing.Size(25, 13);
            this.lcDolj.TabIndex = 1;
            this.lcDolj.Text = "lcDolj";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Должностное лицо";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(8, 8);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Документ";
            // 
            // glueRsDoc
            // 
            this.glueRsDoc.Location = new System.Drawing.Point(8, 24);
            this.glueRsDoc.Name = "glueRsDoc";
            this.glueRsDoc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.glueRsDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueRsDoc.Properties.NullText = "Выберите документ";
            this.glueRsDoc.Properties.NullValuePrompt = "Выберите документ";
            this.glueRsDoc.Properties.View = this.gluevRsDoc;
            this.glueRsDoc.Size = new System.Drawing.Size(320, 20);
            this.glueRsDoc.TabIndex = 0;
            this.glueRsDoc.EditValueChanged += new System.EventHandler(this.glueRsDoc_EditValueChanged);
            // 
            // gluevRsDoc
            // 
            this.gluevRsDoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn12,
            this.gridColumn10,
            this.gridColumn11});
            this.gluevRsDoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gluevRsDoc.Name = "gluevRsDoc";
            this.gluevRsDoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gluevRsDoc.OptionsView.ShowGroupPanel = false;
            this.gluevRsDoc.OptionsView.ShowIndicator = false;
            this.gluevRsDoc.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "№";
            this.gridColumn9.FieldName = "Number";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Дата";
            this.gridColumn12.FieldName = "Date";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Должностное лицо";
            this.gridColumn10.FieldName = "Dolj";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Подразделение";
            this.gridColumn11.FieldName = "Podr";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Месяц";
            // 
            // cbMonth
            // 
            this.cbMonth.Location = new System.Drawing.Point(16, 24);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Properties.AllowFocused = false;
            this.cbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMonth.Size = new System.Drawing.Size(128, 20);
            this.cbMonth.TabIndex = 8;
            this.cbMonth.TabStop = false;
            // 
            // cbAddTov
            // 
            this.cbAddTov.Location = new System.Drawing.Point(240, 328);
            this.cbAddTov.Name = "cbAddTov";
            this.cbAddTov.Size = new System.Drawing.Size(91, 23);
            this.cbAddTov.TabIndex = 4;
            this.cbAddTov.Text = "Добавить >>";
            this.cbAddTov.Click += new System.EventHandler(this.cbAddTov_Click);
            // 
            // selExistTov
            // 
            this.selExistTov.Location = new System.Drawing.Point(8, 200);
            this.selExistTov.Margin = new System.Windows.Forms.Padding(4);
            this.selExistTov.Name = "selExistTov";
            this.selExistTov.Size = new System.Drawing.Size(334, 153);
            this.selExistTov.TabIndex = 22;
            // 
            // validProvider
            // 
            this.validProvider.ValidateHiddenControls = false;
            this.validProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // FormAddRsDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(914, 390);
            this.Controls.Add(this.gcTovars);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormAddRsDoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расход по документу";
            ((System.ComponentModel.ISupportInitialize)(this.gcTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDolj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddDoc)).EndInit();
            this.pcAddDoc.ResumeLayout(false);
            this.pcAddDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNumDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPodr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSelDoc)).EndInit();
            this.pcSelDoc.ResumeLayout(false);
            this.pcSelDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueRsDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevRsDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraGrid.GridControl gcTovars;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTovars;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbDolj;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateDoc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private DevExpress.XtraEditors.SimpleButton cbAddTov;
        private SelectExistTovar selExistTov;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validProvider;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbPodr;
        private DevExpress.XtraEditors.PanelControl pcAddDoc;
        private DevExpress.XtraEditors.PanelControl pcSelDoc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lcPodr;
        private DevExpress.XtraEditors.LabelControl lcDolj;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit glueRsDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gluevRsDoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.SpinEdit seNumDoc;
        private DevExpress.XtraEditors.CheckButton chbAddToDoc;
        private DevExpress.XtraEditors.CheckButton chbNewDoc;
        private DevExpress.XtraEditors.ComboBoxEdit cbDocType;
    }
}