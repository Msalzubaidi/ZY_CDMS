namespace ZY_CDMS.Forms
{
    partial class frmEditServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditServices));
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sdesc = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_scost = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.cbo_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(300, 124);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(210, 124);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(124, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Update";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_sdesc
            // 
            this.txt_sdesc.Location = new System.Drawing.Point(105, 82);
            this.txt_sdesc.Name = "txt_sdesc";
            this.txt_sdesc.Size = new System.Drawing.Size(298, 20);
            this.txt_sdesc.TabIndex = 3;
            this.txt_sdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(5, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_scost
            // 
            this.txt_scost.Location = new System.Drawing.Point(287, 46);
            this.txt_scost.Name = "txt_scost";
            this.txt_scost.Size = new System.Drawing.Size(116, 20);
            this.txt_scost.TabIndex = 2;
            this.txt_scost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(236, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 25);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Cost";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(12, 10);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(87, 25);
            this.lic.TabIndex = 44;
            this.lic.Text = "Service ID";
            this.lic.UseStyleColors = true;
            // 
            // txt_sid
            // 
            this.txt_sid.Enabled = false;
            this.txt_sid.Location = new System.Drawing.Point(105, 46);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(116, 20);
            this.txt_sid.TabIndex = 0;
            this.txt_sid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sid.Leave += new System.EventHandler(this.simpleButton4_Click);
            // 
            // cbo_id
            // 
            this.cbo_id.Location = new System.Drawing.Point(105, 15);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_id.Size = new System.Drawing.Size(150, 20);
            this.cbo_id.TabIndex = 47;
            this.cbo_id.TextChanged += new System.EventHandler(this.cbo_id_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 25);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Service ID";
            this.metroLabel3.UseStyleColors = true;
            // 
            // frmEditServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 163);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbo_id);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_sdesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_scost);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.Controls.Add(this.txt_sid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEditServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Services";
            this.Load += new System.EventHandler(this.frmEditServices_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditServices_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_sdesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_scost;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lic;
        private System.Windows.Forms.TextBox txt_sid;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_id;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}