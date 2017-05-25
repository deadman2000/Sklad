namespace Sklad3.UI
{
    partial class FormAddPrDoc
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
            this.selTov = new Sklad3.UI.SelectTovar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddPrDoc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbPredp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deDateDoc = new DevExpress.XtraEditors.DateEdit();
            this.teNumDoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTypeDoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbAddTov = new DevExpress.XtraEditors.SimpleButton();
            this.gcTovars = new DevExpress.XtraGrid.GridControl();
            this.gvTovars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // selTov
            // 
            this.selTov.Location = new System.Drawing.Point(9, 158);
            this.selTov.Margin = new System.Windows.Forms.Padding(5);
            this.selTov.Name = "selTov";
            this.selTov.Size = new System.Drawing.Size(395, 213);
            this.selTov.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btCancel);
            this.panelControl1.Controls.Add(this.sbAddPrDoc);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cbPredp);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.deDateDoc);
            this.panelControl1.Controls.Add(this.teNumDoc);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbTypeDoc);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.deDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbMonth);
            this.panelControl1.Controls.Add(this.cbAddTov);
            this.panelControl1.Controls.Add(this.selTov);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(406, 418);
            this.panelControl1.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(299, 374);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(87, 28);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Отмена";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // sbAddPrDoc
            // 
            this.sbAddPrDoc.Location = new System.Drawing.Point(205, 374);
            this.sbAddPrDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbAddPrDoc.Name = "sbAddPrDoc";
            this.sbAddPrDoc.Size = new System.Drawing.Size(87, 28);
            this.sbAddPrDoc.TabIndex = 20;
            this.sbAddPrDoc.Text = "Готово";
            this.sbAddPrDoc.Click += new System.EventHandler(this.sbAddPrDoc_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 108);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Поставщик";
            // 
            // cbPredp
            // 
            this.cbPredp.Location = new System.Drawing.Point(19, 128);
            this.cbPredp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPredp.Name = "cbPredp";
            this.cbPredp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPredp.Properties.ImmediatePopup = true;
            this.cbPredp.Properties.MaxLength = 50;
            this.cbPredp.Size = new System.Drawing.Size(373, 22);
            this.cbPredp.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(271, 59);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Дата документа";
            // 
            // deDateDoc
            // 
            this.deDateDoc.EditValue = null;
            this.deDateDoc.Location = new System.Drawing.Point(271, 79);
            this.deDateDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deDateDoc.Name = "deDateDoc";
            this.deDateDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateDoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDateDoc.Size = new System.Drawing.Size(121, 22);
            this.deDateDoc.TabIndex = 16;
            // 
            // teNumDoc
            // 
            this.teNumDoc.Location = new System.Drawing.Point(19, 79);
            this.teNumDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teNumDoc.Name = "teNumDoc";
            this.teNumDoc.Properties.MaxLength = 15;
            this.teNumDoc.Size = new System.Drawing.Size(243, 22);
            this.teNumDoc.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 59);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 16);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Номер документа";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(308, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Тип";
            // 
            // cbTypeDoc
            // 
            this.cbTypeDoc.Location = new System.Drawing.Point(308, 30);
            this.cbTypeDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTypeDoc.Name = "cbTypeDoc";
            this.cbTypeDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypeDoc.Properties.MaxLength = 3;
            this.cbTypeDoc.Size = new System.Drawing.Size(84, 22);
            this.cbTypeDoc.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(177, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Дата прихода";
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(177, 30);
            this.deDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDate.Size = new System.Drawing.Size(117, 22);
            this.deDate.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Месяц";
            // 
            // cbMonth
            // 
            this.cbMonth.Location = new System.Drawing.Point(19, 30);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Properties.AllowFocused = false;
            this.cbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMonth.Size = new System.Drawing.Size(149, 22);
            this.cbMonth.TabIndex = 8;
            this.cbMonth.TabStop = false;
            // 
            // cbAddTov
            // 
            this.cbAddTov.Location = new System.Drawing.Point(280, 335);
            this.cbAddTov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAddTov.Name = "cbAddTov";
            this.cbAddTov.Size = new System.Drawing.Size(106, 28);
            this.cbAddTov.TabIndex = 4;
            this.cbAddTov.Text = "Добавить >>";
            this.cbAddTov.Click += new System.EventHandler(this.cbAddTov_Click);
            // 
            // gcTovars
            // 
            this.gcTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTovars.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTovars.Location = new System.Drawing.Point(406, 0);
            this.gcTovars.MainView = this.gvTovars;
            this.gcTovars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTovars.Name = "gcTovars";
            this.gcTovars.Size = new System.Drawing.Size(660, 418);
            this.gcTovars.TabIndex = 2;
            this.gcTovars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTovars});
            this.gcTovars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcTovars_KeyDown);
            // 
            // gvTovars
            // 
            this.gvTovars.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvTovars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn8,
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
            // gridColumn7
            // 
            this.gridColumn7.Caption = "id";
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 20;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "н/сч";
            this.gridColumn2.FieldName = "Tovar.Nsch";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 30;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "и/н";
            this.gridColumn3.FieldName = "Tovar.Invn";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 25;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наименование";
            this.gridColumn1.FieldName = "Tovar.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 82;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "gridColumn8";
            this.gridColumn8.FieldName = "idedism";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 68;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "е.и";
            this.gridColumn4.FieldName = "Tovar.EdIsm";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 25;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Цена";
            this.gridColumn5.FieldName = "Tovar.Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 35;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Количество";
            this.gridColumn6.FieldName = "Count";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 69;
            // 
            // validProvider
            // 
            this.validProvider.ValidateHiddenControls = false;
            this.validProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // FormAddPrDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 418);
            this.Controls.Add(this.gcTovars);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddPrDoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приход по документу";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SelectTovar selTov;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcTovars;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTovars;
        private DevExpress.XtraEditors.SimpleButton cbAddTov;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton sbAddPrDoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbPredp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateDoc;
        private DevExpress.XtraEditors.TextEdit teNumDoc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTypeDoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validProvider;
    }
}