namespace Sklad3.UI
{
    partial class FormSelectTovar
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
            this.selectTovar = new Sklad3.UI.SelectTovar();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // selectTovar
            // 
            this.selectTovar.Location = new System.Drawing.Point(13, 13);
            this.selectTovar.Margin = new System.Windows.Forms.Padding(4);
            this.selectTovar.Name = "selectTovar";
            this.selectTovar.Size = new System.Drawing.Size(393, 160);
            this.selectTovar.TabIndex = 0;
            this.selectTovar.UseCount = false;
            // 
            // sbSelect
            // 
            this.sbSelect.Location = new System.Drawing.Point(296, 144);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(98, 32);
            this.sbSelect.TabIndex = 1;
            this.sbSelect.Text = "Выбрать";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // FormSelectTovar
            // 
            this.AcceptButton = this.sbSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 192);
            this.Controls.Add(this.sbSelect);
            this.Controls.Add(this.selectTovar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectTovar";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор товара";
            this.ResumeLayout(false);

        }

        #endregion

        private SelectTovar selectTovar;
        private DevExpress.XtraEditors.SimpleButton sbSelect;
    }
}