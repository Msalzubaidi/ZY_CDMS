namespace ZY_CDMS.Forms
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.credInfo = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.Name = "txt_username";
            this.toolTip4.SetToolTip(this.txt_username, resources.GetString("txt_username.ToolTip"));
            this.toolTip2.SetToolTip(this.txt_username, resources.GetString("txt_username.ToolTip1"));
            this.toolTip1.SetToolTip(this.txt_username, resources.GetString("txt_username.ToolTip2"));
            this.toolTip3.SetToolTip(this.txt_username, resources.GetString("txt_username.ToolTip3"));
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            this.toolTip4.SetToolTip(this.txt_password, resources.GetString("txt_password.ToolTip"));
            this.toolTip2.SetToolTip(this.txt_password, resources.GetString("txt_password.ToolTip1"));
            this.toolTip1.SetToolTip(this.txt_password, resources.GetString("txt_password.ToolTip2"));
            this.toolTip3.SetToolTip(this.txt_password, resources.GetString("txt_password.ToolTip3"));
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_userid
            // 
            resources.ApplyResources(this.txt_userid, "txt_userid");
            this.txt_userid.Name = "txt_userid";
            this.toolTip4.SetToolTip(this.txt_userid, resources.GetString("txt_userid.ToolTip"));
            this.toolTip2.SetToolTip(this.txt_userid, resources.GetString("txt_userid.ToolTip1"));
            this.toolTip1.SetToolTip(this.txt_userid, resources.GetString("txt_userid.ToolTip2"));
            this.toolTip3.SetToolTip(this.txt_userid, resources.GetString("txt_userid.ToolTip3"));
            this.txt_userid.TextChanged += new System.EventHandler(this.txt_userid_TextChanged);
            this.txt_userid.Leave += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip1"));
            this.toolTip3.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip2"));
            this.toolTip4.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip3"));
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip1"));
            this.toolTip3.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip2"));
            this.toolTip4.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip3"));
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip"));
            this.toolTip1.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip1"));
            this.toolTip3.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip2"));
            this.toolTip4.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip3"));
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Name = "simpleButton1";
            this.toolTip3.SetToolTip(this.simpleButton1, resources.GetString("simpleButton1.ToolTip"));
            this.toolTip1.SetToolTip(this.simpleButton1, resources.GetString("simpleButton1.ToolTip2"));
            this.toolTip2.SetToolTip(this.simpleButton1, resources.GetString("simpleButton1.ToolTip3"));
            this.toolTip4.SetToolTip(this.simpleButton1, resources.GetString("simpleButton1.ToolTip4"));
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Name = "simpleButton2";
            this.toolTip3.SetToolTip(this.simpleButton2, resources.GetString("simpleButton2.ToolTip"));
            this.toolTip1.SetToolTip(this.simpleButton2, resources.GetString("simpleButton2.ToolTip2"));
            this.toolTip2.SetToolTip(this.simpleButton2, resources.GetString("simpleButton2.ToolTip3"));
            this.toolTip4.SetToolTip(this.simpleButton2, resources.GetString("simpleButton2.ToolTip4"));
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
            this.toolTip1.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip1"));
            this.toolTip3.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip2"));
            this.toolTip4.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip3"));
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lic
            // 
            resources.ApplyResources(this.lic, "lic");
            this.lic.BackColor = System.Drawing.Color.White;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Name = "lic";
            this.toolTip2.SetToolTip(this.lic, resources.GetString("lic.ToolTip"));
            this.toolTip1.SetToolTip(this.lic, resources.GetString("lic.ToolTip1"));
            this.toolTip3.SetToolTip(this.lic, resources.GetString("lic.ToolTip2"));
            this.toolTip4.SetToolTip(this.lic, resources.GetString("lic.ToolTip3"));
            this.lic.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Name = "metroLabel1";
            this.toolTip2.SetToolTip(this.metroLabel1, resources.GetString("metroLabel1.ToolTip"));
            this.toolTip1.SetToolTip(this.metroLabel1, resources.GetString("metroLabel1.ToolTip1"));
            this.toolTip3.SetToolTip(this.metroLabel1, resources.GetString("metroLabel1.ToolTip2"));
            this.toolTip4.SetToolTip(this.metroLabel1, resources.GetString("metroLabel1.ToolTip3"));
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Name = "metroLabel2";
            this.toolTip2.SetToolTip(this.metroLabel2, resources.GetString("metroLabel2.ToolTip"));
            this.toolTip1.SetToolTip(this.metroLabel2, resources.GetString("metroLabel2.ToolTip1"));
            this.toolTip3.SetToolTip(this.metroLabel2, resources.GetString("metroLabel2.ToolTip2"));
            this.toolTip4.SetToolTip(this.metroLabel2, resources.GetString("metroLabel2.ToolTip3"));
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Name = "metroLabel3";
            this.toolTip2.SetToolTip(this.metroLabel3, resources.GetString("metroLabel3.ToolTip"));
            this.toolTip1.SetToolTip(this.metroLabel3, resources.GetString("metroLabel3.ToolTip1"));
            this.toolTip3.SetToolTip(this.metroLabel3, resources.GetString("metroLabel3.ToolTip2"));
            this.toolTip4.SetToolTip(this.metroLabel3, resources.GetString("metroLabel3.ToolTip3"));
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Name = "metroLabel4";
            this.toolTip2.SetToolTip(this.metroLabel4, resources.GetString("metroLabel4.ToolTip"));
            this.toolTip1.SetToolTip(this.metroLabel4, resources.GetString("metroLabel4.ToolTip1"));
            this.toolTip3.SetToolTip(this.metroLabel4, resources.GetString("metroLabel4.ToolTip2"));
            this.toolTip4.SetToolTip(this.metroLabel4, resources.GetString("metroLabel4.ToolTip3"));
            this.metroLabel4.UseStyleColors = true;
            // 
            // credInfo
            // 
            resources.ApplyResources(this.credInfo, "credInfo");
            this.credInfo.BackColor = System.Drawing.Color.White;
            this.credInfo.CustomBackground = true;
            this.credInfo.CustomForeColor = true;
            this.credInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.credInfo.Name = "credInfo";
            this.toolTip2.SetToolTip(this.credInfo, resources.GetString("credInfo.ToolTip"));
            this.toolTip1.SetToolTip(this.credInfo, resources.GetString("credInfo.ToolTip1"));
            this.toolTip3.SetToolTip(this.credInfo, resources.GetString("credInfo.ToolTip2"));
            this.toolTip4.SetToolTip(this.credInfo, resources.GetString("credInfo.ToolTip3"));
            this.credInfo.UseStyleColors = true;
            this.credInfo.Click += new System.EventHandler(this.credInfo_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Name = "metroLabel5";
            this.toolTip2.SetToolTip(this.metroLabel5, resources.GetString("metroLabel5.ToolTip"));
            this.toolTip1.SetToolTip(this.metroLabel5, resources.GetString("metroLabel5.ToolTip1"));
            this.toolTip3.SetToolTip(this.metroLabel5, resources.GetString("metroLabel5.ToolTip2"));
            this.toolTip4.SetToolTip(this.metroLabel5, resources.GetString("metroLabel5.ToolTip3"));
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.credInfo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.toolTip4.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolTip2.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            this.toolTip3.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip3"));
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroLabel lic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel credInfo;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}