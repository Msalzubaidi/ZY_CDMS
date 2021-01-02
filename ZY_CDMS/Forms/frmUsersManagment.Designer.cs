namespace ZY_CDMS.Forms
{
    partial class frmUsersManagment
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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Define Make Model");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Edit Make Model");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Define Services");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Edit Services");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Define Pay Methods");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Define Source Car");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Define Paint Code");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Define Tax Categories");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Buy Car");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Sell Car");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Print Invoice");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Car Maintainance View");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Customers");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Add Services To CAR");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Operations", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Cars");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Search", new System.Windows.Forms.TreeNode[] {
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("System info");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Users Managment");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("System Manage", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("My Account Settings");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("My Account", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Exit");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagment));
            this.cbo_userid = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_userid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_userid
            // 
            this.cbo_userid.Location = new System.Drawing.Point(12, 33);
            this.cbo_userid.Name = "cbo_userid";
            this.cbo_userid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_userid.Size = new System.Drawing.Size(236, 20);
            this.cbo_userid.TabIndex = 0;
            this.cbo_userid.TextChanged += new System.EventHandler(this.cbo_userid_TextChanged);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(12, 93);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(175, 20);
            this.txt_userid.TabIndex = 46;
            this.txt_userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "User ID";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 25);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "User ID";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 25);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "User Name";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 159);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(236, 20);
            this.txt_username.TabIndex = 49;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(12, 185);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 25);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(12, 213);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(236, 20);
            this.txt_pass.TabIndex = 51;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(272, 4);
            this.treeView1.Name = "treeView1";
            treeNode27.Name = "Node1";
            treeNode27.Text = "Define Make Model";
            treeNode28.Name = "Node2";
            treeNode28.Text = "Edit Make Model";
            treeNode29.Name = "Node3";
            treeNode29.Text = "Define Services";
            treeNode30.Name = "Node4";
            treeNode30.Text = "Edit Services";
            treeNode31.Name = "Node5";
            treeNode31.Text = "Define Pay Methods";
            treeNode32.Name = "Node6";
            treeNode32.Text = "Define Source Car";
            treeNode33.Name = "Node11";
            treeNode33.Text = "Define Paint Code";
            treeNode34.Name = "Node12";
            treeNode34.Text = "Define Tax Categories";
            treeNode35.BackColor = System.Drawing.Color.Transparent;
            treeNode35.Name = "settings";
            treeNode35.Text = "Settings";
            treeNode36.Name = "Node14";
            treeNode36.Text = "Buy Car";
            treeNode37.Name = "Node16";
            treeNode37.Text = "Sell Car";
            treeNode38.Name = "Node17";
            treeNode38.Text = "Print Invoice";
            treeNode39.Name = "Node18";
            treeNode39.Text = "Car Maintainance View";
            treeNode40.Name = "Node19";
            treeNode40.Text = "Customers";
            treeNode41.Name = "Node20";
            treeNode41.Text = "Add Services To CAR";
            treeNode42.Name = "operations";
            treeNode42.Text = "Operations";
            treeNode43.Name = "Node26";
            treeNode43.Text = "Cars";
            treeNode44.Name = "search";
            treeNode44.Text = "Search";
            treeNode45.Name = "Node27";
            treeNode45.Text = "Reports";
            treeNode46.Name = "reports";
            treeNode46.Text = "Reports";
            treeNode47.Name = "Node28";
            treeNode47.Text = "System info";
            treeNode48.Name = "Node29";
            treeNode48.Text = "Users Managment";
            treeNode49.Name = "systemmanage";
            treeNode49.Text = "System Manage";
            treeNode50.Checked = true;
            treeNode50.Name = "Node30";
            treeNode50.Text = "My Account Settings";
            treeNode51.Checked = true;
            treeNode51.Name = "myaccount";
            treeNode51.Text = "My Account";
            treeNode52.Name = "exit";
            treeNode52.Text = "Exit";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode42,
            treeNode44,
            treeNode46,
            treeNode49,
            treeNode51,
            treeNode52});
            this.treeView1.Size = new System.Drawing.Size(215, 331);
            this.treeView1.TabIndex = 53;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(193, 96);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(55, 17);
            this.adminCheck.TabIndex = 54;
            this.adminCheck.Text = "Admin";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(44, 263);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Save";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(125, 292);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 56;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(44, 292);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 57;
            this.simpleButton3.Text = "Clear";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(125, 263);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 58;
            this.simpleButton4.Text = "Delete";
            // 
            // frmUsersManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 340);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.adminCheck);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbo_userid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmUsersManagment";
            this.Text = "Users Managment";
            this.Load += new System.EventHandler(this.frmUsersManagment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsersManagment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_userid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbo_userid;
        private System.Windows.Forms.TextBox txt_userid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txt_username;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox adminCheck;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}