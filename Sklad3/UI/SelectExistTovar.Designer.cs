namespace Sklad3.UI
{
    partial class SelectExistTovar
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ceSum = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceCount = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.validProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lcPrice = new DevExpress.XtraEditors.LabelControl();
            this.lcEdism = new DevExpress.XtraEditors.LabelControl();
            this.lcInvn = new DevExpress.XtraEditors.LabelControl();
            this.lcNsch = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lcKmCount = new DevExpress.XtraEditors.LabelControl();
            this.glueTovar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gluevTovar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEdism = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInvn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNsch = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ceSum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueTovar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // ceSum
            // 
            this.ceSum.Location = new System.Drawing.Point(331, 118);
            this.ceSum.Margin = new System.Windows.Forms.Padding(4);
            this.ceSum.Name = "ceSum";
            this.ceSum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSum.Properties.Precision = 4;
            this.ceSum.Size = new System.Drawing.Size(107, 22);
            this.ceSum.TabIndex = 26;
            this.ceSum.EditValueChanged += new System.EventHandler(this.ceSum_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(331, 98);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(37, 16);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Сумма";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(96, 98);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 16);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Цена";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 98);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 16);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Ед. изм.";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(213, 49);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 16);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Инв. номер";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 49);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 16);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Номер счета";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 0);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Наименование";
            // 
            // ceCount
            // 
            this.ceCount.Location = new System.Drawing.Point(213, 118);
            this.ceCount.Margin = new System.Windows.Forms.Padding(4);
            this.ceCount.Name = "ceCount";
            this.ceCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceCount.Properties.Precision = 4;
            this.ceCount.Size = new System.Drawing.Size(107, 22);
            this.ceCount.TabIndex = 25;
            this.ceCount.EditValueChanged += new System.EventHandler(this.ceCount_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(213, 98);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Количество";
            // 
            // validProvider
            // 
            this.validProvider.ValidateHiddenControls = false;
            this.validProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lcPrice
            // 
            this.lcPrice.Location = new System.Drawing.Point(107, 118);
            this.lcPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lcPrice.Name = "lcPrice";
            this.lcPrice.Size = new System.Drawing.Size(37, 16);
            this.lcPrice.TabIndex = 39;
            this.lcPrice.Text = "lcPrice";
            // 
            // lcEdism
            // 
            this.lcEdism.Location = new System.Drawing.Point(21, 118);
            this.lcEdism.Margin = new System.Windows.Forms.Padding(4);
            this.lcEdism.Name = "lcEdism";
            this.lcEdism.Size = new System.Drawing.Size(43, 16);
            this.lcEdism.TabIndex = 38;
            this.lcEdism.Text = "lcEdism";
            // 
            // lcInvn
            // 
            this.lcInvn.Location = new System.Drawing.Point(224, 69);
            this.lcInvn.Margin = new System.Windows.Forms.Padding(4);
            this.lcInvn.Name = "lcInvn";
            this.lcInvn.Size = new System.Drawing.Size(33, 16);
            this.lcInvn.TabIndex = 37;
            this.lcInvn.Text = "lcInvn";
            // 
            // lcNsch
            // 
            this.lcNsch.Location = new System.Drawing.Point(21, 69);
            this.lcNsch.Margin = new System.Windows.Forms.Padding(4);
            this.lcNsch.Name = "lcNsch";
            this.lcNsch.Size = new System.Drawing.Size(36, 16);
            this.lcNsch.TabIndex = 36;
            this.lcNsch.Text = "lcNsch";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 138);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Остаток";
            // 
            // lcKmCount
            // 
            this.lcKmCount.Location = new System.Drawing.Point(21, 158);
            this.lcKmCount.Margin = new System.Windows.Forms.Padding(4);
            this.lcKmCount.Name = "lcKmCount";
            this.lcKmCount.Size = new System.Drawing.Size(60, 16);
            this.lcKmCount.TabIndex = 38;
            this.lcKmCount.Text = "lcKmCount";
            // 
            // glueTovar
            // 
            this.glueTovar.Location = new System.Drawing.Point(11, 20);
            this.glueTovar.Margin = new System.Windows.Forms.Padding(4);
            this.glueTovar.Name = "glueTovar";
            this.glueTovar.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.glueTovar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueTovar.Properties.ImmediatePopup = true;
            this.glueTovar.Properties.NullText = "Выберите наименование";
            this.glueTovar.Properties.NullValuePrompt = "Выберите наименование";
            this.glueTovar.Properties.NullValuePromptShowForEmptyValue = true;
            this.glueTovar.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.glueTovar.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize;
            this.glueTovar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueTovar.Properties.View = this.gluevTovar;
            this.glueTovar.Size = new System.Drawing.Size(427, 22);
            this.glueTovar.TabIndex = 40;
            this.glueTovar.EditValueChanged += new System.EventHandler(this.glueTovar_EditValueChanged);
            // 
            // gluevTovar
            // 
            this.gluevTovar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gluevTovar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcEdism,
            this.gcPrice,
            this.gcInvn,
            this.gcNsch});
            this.gluevTovar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gluevTovar.Name = "gluevTovar";
            this.gluevTovar.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gluevTovar.OptionsBehavior.Editable = false;
            this.gluevTovar.OptionsCustomization.AllowQuickHideColumns = false;
            this.gluevTovar.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gluevTovar.OptionsView.ShowGroupPanel = false;
            this.gluevTovar.OptionsView.ShowIndicator = false;
            this.gluevTovar.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gluevTovar.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcName
            // 
            this.gcName.Caption = "Наименование";
            this.gcName.FieldName = "Name";
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            // 
            // gcEdism
            // 
            this.gcEdism.Caption = "е.и";
            this.gcEdism.FieldName = "EdIsm";
            this.gcEdism.MinWidth = 30;
            this.gcEdism.Name = "gcEdism";
            this.gcEdism.Visible = true;
            this.gcEdism.VisibleIndex = 1;
            // 
            // gcPrice
            // 
            this.gcPrice.Caption = "Цена";
            this.gcPrice.DisplayFormat.FormatString = "0.00##";
            this.gcPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gcPrice.FieldName = "Price";
            this.gcPrice.MinWidth = 60;
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.Visible = true;
            this.gcPrice.VisibleIndex = 2;
            // 
            // gcInvn
            // 
            this.gcInvn.Caption = "инв/н";
            this.gcInvn.FieldName = "Invn";
            this.gcInvn.Name = "gcInvn";
            this.gcInvn.Visible = true;
            this.gcInvn.VisibleIndex = 3;
            // 
            // gcNsch
            // 
            this.gcNsch.Caption = "н/сч";
            this.gcNsch.FieldName = "Nsch";
            this.gcNsch.Name = "gcNsch";
            this.gcNsch.Visible = true;
            this.gcNsch.VisibleIndex = 4;
            // 
            // SelectExistTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.glueTovar);
            this.Controls.Add(this.lcPrice);
            this.Controls.Add(this.lcKmCount);
            this.Controls.Add(this.lcEdism);
            this.Controls.Add(this.lcInvn);
            this.Controls.Add(this.lcNsch);
            this.Controls.Add(this.ceSum);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ceCount);
            this.Controls.Add(this.labelControl3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectExistTovar";
            this.Size = new System.Drawing.Size(445, 181);
            ((System.ComponentModel.ISupportInitialize)(this.ceSum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueTovar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit ceSum;
        private DevExpress.XtraEditors.CalcEdit ceCount;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validProvider;
        private DevExpress.XtraEditors.LabelControl lcPrice;
        private DevExpress.XtraEditors.LabelControl lcEdism;
        private DevExpress.XtraEditors.LabelControl lcInvn;
        private DevExpress.XtraEditors.LabelControl lcNsch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lcKmCount;
        private DevExpress.XtraEditors.GridLookUpEdit glueTovar;
        private DevExpress.XtraGrid.Views.Grid.GridView gluevTovar;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdism;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcInvn;
        private DevExpress.XtraGrid.Columns.GridColumn gcNsch;
    }
}
