namespace ZY_CDMS.Forms
{
    partial class frmDefineServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefineServices));
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_scost = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_sdesc = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(22, 9);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(87, 25);
            this.lic.TabIndex = 34;
            this.lic.Text = "Service ID";
            this.lic.UseStyleColors = true;
            // 
            // txt_sid
            // 
            this.txt_sid.Enabled = false;
            this.txt_sid.Location = new System.Drawing.Point(12, 37);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(116, 20);
            this.txt_sid.TabIndex = 33;
            this.txt_sid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(196, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 25);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Cost";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_scost
            // 
            this.txt_scost.Location = new System.Drawing.Point(163, 37);
            this.txt_scost.Name = "txt_scost";
            this.txt_scost.Size = new System.Drawing.Size(116, 20);
            this.txt_scost.TabIndex = 0;
            this.txt_scost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(96, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_sdesc
            // 
            this.txt_sdesc.Location = new System.Drawing.Point(12, 100);
            this.txt_sdesc.Name = "txt_sdesc";
            this.txt_sdesc.Size = new System.Drawing.Size(267, 20);
            this.txt_sdesc.TabIndex = 1;
            this.txt_sdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(109, 135);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(206, 135);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(22, 136);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 38;
            this.simpleButton4.Text = "Add";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // frmDefineServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 171);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txt_sdesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_scost);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.Controls.Add(this.txt_sid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDefineServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define Services";
            this.Load += new System.EventHandler(this.simpleButton2_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDefineServices_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lic;
        private System.Windows.Forms.TextBox txt_sid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_scost;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_sdesc;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}