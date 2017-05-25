namespace Sklad3.UI
{
    partial class SelectTovar
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
            this.lcSum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceCount = new DevExpress.XtraEditors.CalcEdit();
            this.lcCount = new DevExpress.XtraEditors.LabelControl();
            this.chbNewTovar = new DevExpress.XtraEditors.CheckButton();
            this.plNewTov = new DevExpress.XtraEditors.PanelControl();
            this.cbName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbNsch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teInvn = new DevExpress.XtraEditors.TextEdit();
            this.cbEdism = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cePrice = new DevExpress.XtraEditors.CalcEdit();
            this.plExistTov = new DevExpress.XtraEditors.PanelControl();
            this.lcKmCount = new DevExpress.XtraEditors.LabelControl();
            this.lcKmCountTitle = new DevExpress.XtraEditors.LabelControl();
            this.lcPrice = new DevExpress.XtraEditors.LabelControl();
            this.lcEdism = new DevExpress.XtraEditors.LabelControl();
            this.lcInvn = new DevExpress.XtraEditors.LabelControl();
            this.lcNsch = new DevExpress.XtraEditors.LabelControl();
            this.glueTovar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gluevTovar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.validProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEdism = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInvn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNsch = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ceSum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plNewTov)).BeginInit();
            this.plNewTov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNsch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEdism.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plExistTov)).BeginInit();
            this.plExistTov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueTovar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevTovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ceSum
            // 
            this.ceSum.Location = new System.Drawing.Point(331, 138);
            this.ceSum.Margin = new System.Windows.Forms.Padding(4);
            this.ceSum.Name = "ceSum";
            this.ceSum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSum.Properties.Precision = 4;
            this.ceSum.Size = new System.Drawing.Size(107, 22);
            this.ceSum.TabIndex = 26;
            this.ceSum.EditValueChanged += new System.EventHandler(this.ceSum_EditValueChanged);
            // 
            // lcSum
            // 
            this.lcSum.Location = new System.Drawing.Point(331, 118);
            this.lcSum.Margin = new System.Windows.Forms.Padding(4);
            this.lcSum.Name = "lcSum";
            this.lcSum.Size = new System.Drawing.Size(37, 16);
            this.lcSum.TabIndex = 34;
            this.lcSum.Text = "Сумма";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(96, 118);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 16);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Цена";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 118);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 16);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Ед. изм.";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(213, 69);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 16);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Инв. номер";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 69);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 16);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Номер счета";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 20);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Наименование";
            // 
            // ceCount
            // 
            this.ceCount.Location = new System.Drawing.Point(213, 138);
            this.ceCount.Margin = new System.Windows.Forms.Padding(4);
            this.ceCount.Name = "ceCount";
            this.ceCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceCount.Properties.Precision = 4;
            this.ceCount.Size = new System.Drawing.Size(107, 22);
            this.ceCount.TabIndex = 25;
            this.ceCount.EditValueChanged += new System.EventHandler(this.ceCount_EditValueChanged);
            // 
            // lcCount
            // 
            this.lcCount.Location = new System.Drawing.Point(213, 118);
            this.lcCount.Margin = new System.Windows.Forms.Padding(4);
            this.lcCount.Name = "lcCount";
            this.lcCount.Size = new System.Drawing.Size(68, 16);
            this.lcCount.TabIndex = 21;
            this.lcCount.Text = "Количество";
            // 
            // chbNewTovar
            // 
            this.chbNewTovar.AllowFocus = false;
            this.chbNewTovar.Location = new System.Drawing.Point(267, 0);
            this.chbNewTovar.Margin = new System.Windows.Forms.Padding(4);
            this.chbNewTovar.Name = "chbNewTovar";
            this.chbNewTovar.Size = new System.Drawing.Size(171, 30);
            this.chbNewTovar.TabIndex = 33;
            this.chbNewTovar.TabStop = false;
            this.chbNewTovar.Text = "Новое наименование";
            this.chbNewTovar.CheckedChanged += new System.EventHandler(this.chbNewTovar_CheckedChanged);
            // 
            // plNewTov
            // 
            this.plNewTov.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.plNewTov.Controls.Add(this.cbName);
            this.plNewTov.Controls.Add(this.cbNsch);
            this.plNewTov.Controls.Add(this.teInvn);
            this.plNewTov.Controls.Add(this.cbEdism);
            this.plNewTov.Controls.Add(this.cePrice);
            this.plNewTov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plNewTov.Location = new System.Drawing.Point(0, 0);
            this.plNewTov.Margin = new System.Windows.Forms.Padding(4);
            this.plNewTov.Name = "plNewTov";
            this.plNewTov.Size = new System.Drawing.Size(445, 209);
            this.plNewTov.TabIndex = 23;
            // 
            // cbName
            // 
            this.cbName.Location = new System.Drawing.Point(11, 40);
            this.cbName.Margin = new System.Windows.Forms.Padding(4);
            this.cbName.Name = "cbName";
            this.cbName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbName.Properties.ImmediatePopup = true;
            this.cbName.Properties.MaxLength = 150;
            this.cbName.Properties.PopupSizeable = true;
            this.cbName.Properties.Sorted = true;
            this.cbName.Size = new System.Drawing.Size(427, 22);
            this.cbName.TabIndex = 0;
            // 
            // cbNsch
            // 
            this.cbNsch.Location = new System.Drawing.Point(11, 88);
            this.cbNsch.Margin = new System.Windows.Forms.Padding(4);
            this.cbNsch.Name = "cbNsch";
            this.cbNsch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNsch.Properties.ImmediatePopup = true;
            this.cbNsch.Properties.MaxLength = 10;
            this.cbNsch.Properties.Sorted = true;
            this.cbNsch.Size = new System.Drawing.Size(192, 22);
            this.cbNsch.TabIndex = 1;
            // 
            // teInvn
            // 
            this.teInvn.Location = new System.Drawing.Point(213, 88);
            this.teInvn.Margin = new System.Windows.Forms.Padding(4);
            this.teInvn.Name = "teInvn";
            this.teInvn.Properties.MaxLength = 15;
            this.teInvn.Size = new System.Drawing.Size(224, 22);
            this.teInvn.TabIndex = 2;
            // 
            // cbEdism
            // 
            this.cbEdism.Location = new System.Drawing.Point(11, 137);
            this.cbEdism.Margin = new System.Windows.Forms.Padding(4);
            this.cbEdism.Name = "cbEdism";
            this.cbEdism.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEdism.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.cbEdism.Properties.ImmediatePopup = true;
            this.cbEdism.Properties.MaxLength = 5;
            this.cbEdism.Properties.Sorted = true;
            this.cbEdism.Size = new System.Drawing.Size(75, 22);
            this.cbEdism.TabIndex = 3;
            // 
            // cePrice
            // 
            this.cePrice.Location = new System.Drawing.Point(96, 137);
            this.cePrice.Margin = new System.Windows.Forms.Padding(4);
            this.cePrice.Name = "cePrice";
            this.cePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cePrice.Properties.Precision = 4;
            this.cePrice.Size = new System.Drawing.Size(107, 22);
            this.cePrice.TabIndex = 4;
            this.cePrice.EditValueChanged += new System.EventHandler(this.cePrice_EditValueChanged);
            // 
            // plExistTov
            // 
            this.plExistTov.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.plExistTov.Controls.Add(this.lcKmCount);
            this.plExistTov.Controls.Add(this.lcKmCountTitle);
            this.plExistTov.Controls.Add(this.lcPrice);
            this.plExistTov.Controls.Add(this.lcEdism);
            this.plExistTov.Controls.Add(this.lcInvn);
            this.plExistTov.Controls.Add(this.lcNsch);
            this.plExistTov.Controls.Add(this.glueTovar);
            this.plExistTov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plExistTov.Location = new System.Drawing.Point(0, 0);
            this.plExistTov.Margin = new System.Windows.Forms.Padding(4);
            this.plExistTov.Name = "plExistTov";
            this.plExistTov.Size = new System.Drawing.Size(445, 209);
            this.plExistTov.TabIndex = 20;
            // 
            // lcKmCount
            // 
            this.lcKmCount.Location = new System.Drawing.Point(21, 183);
            this.lcKmCount.Margin = new System.Windows.Forms.Padding(4);
            this.lcKmCount.Name = "lcKmCount";
            this.lcKmCount.Size = new System.Drawing.Size(60, 16);
            this.lcKmCount.TabIndex = 40;
            this.lcKmCount.Text = "lcKmCount";
            // 
            // lcKmCountTitle
            // 
            this.lcKmCountTitle.Location = new System.Drawing.Point(11, 163);
            this.lcKmCountTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lcKmCountTitle.Name = "lcKmCountTitle";
            this.lcKmCountTitle.Size = new System.Drawing.Size(48, 16);
            this.lcKmCountTitle.TabIndex = 39;
            this.lcKmCountTitle.Text = "Остаток";
            // 
            // lcPrice
            // 
            this.lcPrice.Location = new System.Drawing.Point(107, 139);
            this.lcPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lcPrice.Name = "lcPrice";
            this.lcPrice.Size = new System.Drawing.Size(37, 16);
            this.lcPrice.TabIndex = 12;
            this.lcPrice.Text = "lcPrice";
            // 
            // lcEdism
            // 
            this.lcEdism.Location = new System.Drawing.Point(21, 139);
            this.lcEdism.Margin = new System.Windows.Forms.Padding(4);
            this.lcEdism.Name = "lcEdism";
            this.lcEdism.Size = new System.Drawing.Size(43, 16);
            this.lcEdism.TabIndex = 10;
            this.lcEdism.Text = "lcEdism";
            // 
            // lcInvn
            // 
            this.lcInvn.Location = new System.Drawing.Point(224, 90);
            this.lcInvn.Margin = new System.Windows.Forms.Padding(4);
            this.lcInvn.Name = "lcInvn";
            this.lcInvn.Size = new System.Drawing.Size(33, 16);
            this.lcInvn.TabIndex = 8;
            this.lcInvn.Text = "lcInvn";
            // 
            // lcNsch
            // 
            this.lcNsch.Location = new System.Drawing.Point(21, 90);
            this.lcNsch.Margin = new System.Windows.Forms.Padding(4);
            this.lcNsch.Name = "lcNsch";
            this.lcNsch.Size = new System.Drawing.Size(36, 16);
            this.lcNsch.TabIndex = 4;
            this.lcNsch.Text = "lcNsch";
            // 
            // glueTovar
            // 
            this.glueTovar.Location = new System.Drawing.Point(11, 39);
            this.glueTovar.Margin = new System.Windows.Forms.Padding(4);
            this.glueTovar.Name = "glueTovar";
            this.glueTovar.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.glueTovar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueTovar.Properties.DisplayMember = "Name";
            this.glueTovar.Properties.ImmediatePopup = true;
            this.glueTovar.Properties.NullText = "Выберите наименование";
            this.glueTovar.Properties.NullValuePrompt = "Выберите наименование";
            this.glueTovar.Properties.NullValuePromptShowForEmptyValue = true;
            this.glueTovar.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.glueTovar.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize;
            this.glueTovar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueTovar.Properties.View = this.gluevTovar;
            this.glueTovar.Size = new System.Drawing.Size(427, 22);
            this.glueTovar.TabIndex = 0;
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
            // validProvider
            // 
            this.validProvider.ValidateHiddenControls = false;
            this.validProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
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
            // SelectTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbNewTovar);
            this.Controls.Add(this.ceSum);
            this.Controls.Add(this.lcSum);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ceCount);
            this.Controls.Add(this.lcCount);
            this.Controls.Add(this.plExistTov);
            this.Controls.Add(this.plNewTov);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectTovar";
            this.Size = new System.Drawing.Size(445, 209);
            ((System.ComponentModel.ISupportInitialize)(this.ceSum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plNewTov)).EndInit();
            this.plNewTov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNsch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEdism.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plExistTov)).EndInit();
            this.plExistTov.ResumeLayout(false);
            this.plExistTov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueTovar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluevTovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcSum;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lcCount;
        private DevExpress.XtraEditors.PanelControl plNewTov;
        private DevExpress.XtraEditors.PanelControl plExistTov;
        private DevExpress.XtraEditors.LabelControl lcPrice;
        private DevExpress.XtraEditors.LabelControl lcEdism;
        private DevExpress.XtraEditors.LabelControl lcInvn;
        private DevExpress.XtraEditors.LabelControl lcNsch;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcEdism;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcInvn;
        private DevExpress.XtraGrid.Columns.GridColumn gcNsch;
        private DevExpress.XtraEditors.CalcEdit ceSum;
        private DevExpress.XtraEditors.CalcEdit ceCount;
        private DevExpress.XtraEditors.CheckButton chbNewTovar;
        private DevExpress.XtraEditors.ComboBoxEdit cbName;
        private DevExpress.XtraEditors.ComboBoxEdit cbNsch;
        private DevExpress.XtraEditors.TextEdit teInvn;
        private DevExpress.XtraEditors.ComboBoxEdit cbEdism;
        private DevExpress.XtraEditors.CalcEdit cePrice;
        private DevExpress.XtraGrid.Views.Grid.GridView gluevTovar;
        private DevExpress.XtraEditors.GridLookUpEdit glueTovar;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validProvider;
        private DevExpress.XtraEditors.LabelControl lcKmCount;
        private DevExpress.XtraEditors.LabelControl lcKmCountTitle;
    }
}
