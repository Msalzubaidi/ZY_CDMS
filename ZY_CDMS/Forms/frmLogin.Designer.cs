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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dbname = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(92, 136);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(179, 20);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(92, 162);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(179, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(92, 110);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(179, 20);
            this.txt_userid.TabIndex = 0;
            this.txt_userid.TextChanged += new System.EventHandler(this.txt_userid_TextChanged);
            this.txt_userid.Leave += new System.EventHandler(this.simpleButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, "ZY Tech Instagram Page");
            this.toolTip3.SetToolTip(this.pictureBox1, "ZY Tech Instagram Page");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(630, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox2, "ZY Tech Web Site");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(706, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox3, "Send Mail To ZY Tech");
            this.toolTip4.SetToolTip(this.pictureBox3, "Send Mail To ZY Tech");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(69, 205);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 36);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(188, 205);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(106, 36);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(592, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox4, "ZY Tech Facebook Page");
            this.toolTip1.SetToolTip(this.pictureBox4, "ZY Tech Facebook Page");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.Color.White;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(145, 76);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(59, 25);
            this.lic.TabIndex = 46;
            this.lic.Text = "Log in";
            this.lic.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(371, 278);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(205, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "ZY Technologies Solutions © 2021";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "User ID";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "User Name";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 50;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.UseStyleColors = true;
            // 
            // credInfo
            // 
            this.credInfo.AutoSize = true;
            this.credInfo.BackColor = System.Drawing.Color.White;
            this.credInfo.CustomBackground = true;
            this.credInfo.CustomForeColor = true;
            this.credInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.credInfo.Location = new System.Drawing.Point(12, 9);
            this.credInfo.Name = "credInfo";
            this.credInfo.Size = new System.Drawing.Size(109, 25);
            this.credInfo.TabIndex = 51;
            this.credInfo.Text = "Admin Login";
            this.credInfo.UseStyleColors = true;
            this.credInfo.Click += new System.EventHandler(this.credInfo_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(86, 280);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 25);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "اللغة العربية";
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Visible = false;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(179, 280);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 30);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "English";
            this.metroLabel6.UseStyleColors = true;
            this.metroLabel6.Visible = false;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click_1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.dbname);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.server);
            this.groupBox1.Location = new System.Drawing.Point(377, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 133);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionString";
            this.groupBox1.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "DataBase";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Server";
            // 
            // dbname
            // 
            this.dbname.Location = new System.Drawing.Point(61, 45);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(285, 20);
            this.dbname.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(61, 97);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(285, 20);
            this.password.TabIndex = 2;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(61, 71);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(285, 20);
            this.username.TabIndex = 1;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(61, 19);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(285, 20);
            this.server.TabIndex = 0;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(115, 257);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(109, 13);
            this.hyperlinkLabelControl1.TabIndex = 55;
            this.hyperlinkLabelControl1.Text = "Forget My Password ? ";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 317);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox dbname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox server;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}