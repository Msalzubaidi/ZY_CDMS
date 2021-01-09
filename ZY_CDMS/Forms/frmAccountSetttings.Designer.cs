namespace ZY_CDMS.Forms
{
    partial class frmAccountSetttings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSetttings));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_userid
            // 
            resources.ApplyResources(this.txt_userid, "txt_userid");
            this.txt_userid.Name = "txt_userid";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.Name = "txt_username";
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txt_oldpass
            // 
            resources.ApplyResources(this.txt_oldpass, "txt_oldpass");
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.UseSystemPasswordChar = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_newpass
            // 
            resources.ApplyResources(this.txt_newpass, "txt_newpass");
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.UseSystemPasswordChar = true;
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmAccountSetttings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_userid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmAccountSetttings";
            this.Load += new System.EventHandler(this.frmAccountSetttings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountSetttings_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_userid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_username;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txt_oldpass;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_newpass;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}