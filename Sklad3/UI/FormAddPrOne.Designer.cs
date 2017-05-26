namespace Sklad3.UI
{
    partial class FormAddPrOne
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTypeDoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.luePrDoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.selTov = new Sklad3.UI.SelectTovar();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePrDoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(168, 267);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(80, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.Click += new System.EventHandler(this.btAddPr_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 3;
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
            this.cbMonth.TabIndex = 2;
            this.cbMonth.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(256, 267);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(152, 24);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDate.Size = new System.Drawing.Size(100, 20);
            this.deDate.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(152, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Дата прихода";
            // 
            // cbTypeDoc
            // 
            this.cbTypeDoc.Location = new System.Drawing.Point(264, 24);
            this.cbTypeDoc.Name = "cbTypeDoc";
            this.cbTypeDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypeDoc.Properties.MaxLength = 3;
            this.cbTypeDoc.Size = new System.Drawing.Size(72, 20);
            this.cbTypeDoc.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Тип";
            // 
            // luePrDoc
            // 
            this.luePrDoc.Location = new System.Drawing.Point(16, 235);
            this.luePrDoc.Name = "luePrDoc";
            this.luePrDoc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.luePrDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Очистить", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, "", null, null, true)});
            this.luePrDoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Номер"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Date", "Дата"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Predp", "Организация")});
            this.luePrDoc.Properties.DropDownRows = 15;
            this.luePrDoc.Properties.ImmediatePopup = true;
            this.luePrDoc.Properties.NullText = "[Без прикрепления]";
            this.luePrDoc.Properties.ShowFooter = false;
            this.luePrDoc.Properties.ShowLines = false;
            this.luePrDoc.Size = new System.Drawing.Size(320, 20);
            this.luePrDoc.TabIndex = 9;
            this.luePrDoc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luePrDoc_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 219);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Приходный документ";
            // 
            // selTov
            // 
            this.selTov.Location = new System.Drawing.Point(8, 48);
            this.selTov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selTov.Name = "selTov";
            this.selTov.Size = new System.Drawing.Size(339, 165);
            this.selTov.TabIndex = 0;
            this.selTov.UseCount = true;
            // 
            // FormAddPrOne
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(350, 306);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.luePrDoc);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbTypeDoc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.deDate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.selTov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddPrOne";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приход";
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePrDoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SelectTovar selTov;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbTypeDoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit luePrDoc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}