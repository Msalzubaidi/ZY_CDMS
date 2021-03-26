namespace ZY_CDMS.Forms
{
    partial class frmUpdateBrandInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBrandInfo));
            this.txt_model = new System.Windows.Forms.MaskedTextBox();
            this.txt_make = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_id = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(68, 73);
            this.txt_model.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.txt_model.Name = "txt_model";
            this.txt_model.PromptChar = ' ';
            this.txt_model.Size = new System.Drawing.Size(247, 20);
            this.txt_model.TabIndex = 2;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(68, 45);
            this.txt_make.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.txt_make.Name = "txt_make";
            this.txt_make.PromptChar = ' ';
            this.txt_make.Size = new System.Drawing.Size(247, 20);
            this.txt_make.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(11, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 25);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Model";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(11, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 25);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Make";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(11, 7);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(28, 25);
            this.lic.TabIndex = 29;
            this.lic.Text = "ID";
            this.lic.UseStyleColors = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(240, 106);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 35;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(159, 106);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(78, 106);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "Update";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbo_id
            // 
            this.cbo_id.Location = new System.Drawing.Point(68, 14);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_id.Size = new System.Drawing.Size(100, 20);
            this.cbo_id.TabIndex = 37;
            this.cbo_id.TextChanged += new System.EventHandler(this.cbo_id_TextChanged);
            // 
            // frmUpdateBrandInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 144);
            this.Controls.Add(this.cbo_id);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_make);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmUpdateBrandInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Brand Info";
            this.Load += new System.EventHandler(this.frmUpdateBrandInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUpdateBrandInfo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_model;
        private System.Windows.Forms.MaskedTextBox txt_make;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lic;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_id;
    }
}