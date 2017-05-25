namespace Sklad3.UI
{
    partial class FormSelectSFact
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
            this.gcSFact = new DevExpress.XtraGrid.GridControl();
            this.gvSFact = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.gcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPredp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcSFact
            // 
            this.gcSFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSFact.Location = new System.Drawing.Point(0, 0);
            this.gcSFact.MainView = this.gvSFact;
            this.gcSFact.Name = "gcSFact";
            this.gcSFact.Size = new System.Drawing.Size(462, 475);
            this.gcSFact.TabIndex = 0;
            this.gcSFact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSFact});
            // 
            // gvSFact
            // 
            this.gvSFact.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNumber,
            this.gcPredp,
            this.gcDate});
            this.gvSFact.GridControl = this.gcSFact;
            this.gvSFact.Name = "gvSFact";
            this.gvSFact.OptionsBehavior.Editable = false;
            this.gvSFact.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSFact.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSFact.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSFact.OptionsView.EnableAppearanceOddRow = true;
            this.gvSFact.OptionsView.ShowGroupPanel = false;
            this.gvSFact.OptionsView.ShowIndicator = false;
            this.gvSFact.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSFact.DoubleClick += new System.EventHandler(this.gvSFact_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbSelect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 475);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(462, 48);
            this.panelControl1.TabIndex = 1;
            // 
            // sbSelect
            // 
            this.sbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSelect.Location = new System.Drawing.Point(324, 8);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(128, 32);
            this.sbSelect.TabIndex = 0;
            this.sbSelect.Text = "Выбрать";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // gcNumber
            // 
            this.gcNumber.Caption = "Номер";
            this.gcNumber.FieldName = "Number";
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.Visible = true;
            this.gcNumber.VisibleIndex = 0;
            // 
            // gcPredp
            // 
            this.gcPredp.Caption = "Предприятие";
            this.gcPredp.FieldName = "Predp.Name";
            this.gcPredp.Name = "gcPredp";
            this.gcPredp.Visible = true;
            this.gcPredp.VisibleIndex = 1;
            this.gcPredp.Width = 258;
            // 
            // gcDate
            // 
            this.gcDate.Caption = "Дата";
            this.gcDate.FieldName = "Date";
            this.gcDate.Name = "gcDate";
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 2;
            // 
            // FormSelectSFact
            // 
            this.AcceptButton = this.sbSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 523);
            this.Controls.Add(this.gcSFact);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectSFact";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор документа";
            ((System.ComponentModel.ISupportInitialize)(this.gcSFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSFact;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSFact;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcPredp;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
    }
}