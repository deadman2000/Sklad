namespace Sklad3.UI
{
    partial class FormAddMBeg
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
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.selTov = new Sklad3.UI.SelectTovar();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.cbMonth.TabIndex = 0;
            this.cbMonth.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Месяц";
            // 
            // btAdd
            // 
            this.btAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdd.Location = new System.Drawing.Point(177, 217);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(93, 30);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(280, 217);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(93, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // selTov
            // 
            this.selTov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selTov.Location = new System.Drawing.Point(9, 39);
            this.selTov.Margin = new System.Windows.Forms.Padding(5);
            this.selTov.Name = "selTov";
            this.selTov.Size = new System.Drawing.Size(413, 217);
            this.selTov.TabIndex = 0;
            // 
            // FormAddMBeg
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(413, 264);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.selTov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddMBeg";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "В начало месяца";
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private SelectTovar selTov;
    }
}