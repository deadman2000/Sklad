namespace Sklad3.UI
{
    partial class FormSelectRasDoc
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
            this.gcRas = new DevExpress.XtraGrid.GridControl();
            this.gvRas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDolj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPodr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcRas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcRas
            // 
            this.gcRas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRas.Location = new System.Drawing.Point(0, 0);
            this.gcRas.MainView = this.gvRas;
            this.gcRas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRas.Name = "gcRas";
            this.gcRas.Size = new System.Drawing.Size(535, 452);
            this.gcRas.TabIndex = 0;
            this.gcRas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRas});
            // 
            // gvRas
            // 
            this.gvRas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcType,
            this.gcDolj,
            this.gcPodr,
            this.gcNumber,
            this.gcDate});
            this.gvRas.GridControl = this.gcRas;
            this.gvRas.Name = "gvRas";
            this.gvRas.OptionsBehavior.Editable = false;
            this.gvRas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvRas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRas.OptionsView.EnableAppearanceOddRow = true;
            this.gvRas.OptionsView.ShowGroupPanel = false;
            this.gvRas.OptionsView.ShowIndicator = false;
            this.gvRas.DoubleClick += new System.EventHandler(this.gvRas_DoubleClick);
            // 
            // gcType
            // 
            this.gcType.Caption = "Тип";
            this.gcType.FieldName = "Type.Name";
            this.gcType.Name = "gcType";
            this.gcType.Visible = true;
            this.gcType.VisibleIndex = 0;
            // 
            // gcDolj
            // 
            this.gcDolj.Caption = "Получатель";
            this.gcDolj.FieldName = "Dolj.Name";
            this.gcDolj.Name = "gcDolj";
            this.gcDolj.Visible = true;
            this.gcDolj.VisibleIndex = 1;
            // 
            // gcPodr
            // 
            this.gcPodr.Caption = "Подразделение";
            this.gcPodr.FieldName = "Podr.Name";
            this.gcPodr.Name = "gcPodr";
            this.gcPodr.Visible = true;
            this.gcPodr.VisibleIndex = 2;
            // 
            // gcNumber
            // 
            this.gcNumber.Caption = "Номер";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.Name = "gcNumber";
            // 
            // gcDate
            // 
            this.gcDate.Caption = "Дата";
            this.gcDate.FieldName = "Date";
            this.gcDate.Name = "gcDate";
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbSelect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 452);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(535, 48);
            this.panelControl1.TabIndex = 1;
            // 
            // sbSelect
            // 
            this.sbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSelect.Location = new System.Drawing.Point(395, 7);
            this.sbSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(120, 32);
            this.sbSelect.TabIndex = 0;
            this.sbSelect.Text = "Выбрать";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // FormSelectRasDoc
            // 
            this.AcceptButton = this.sbSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 500);
            this.Controls.Add(this.gcRas);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectRasDoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор документа";
            ((System.ComponentModel.ISupportInitialize)(this.gcRas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcRas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRas;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gcDolj;
        private DevExpress.XtraGrid.Columns.GridColumn gcPodr;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcType;
    }
}