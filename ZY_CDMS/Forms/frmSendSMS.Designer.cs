namespace ZY_CDMS.Forms
{
    partial class frmSendSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendSMS));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.message = new System.Windows.Forms.TextBox();
            this.txt_cusmobile = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbo_cusid = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_custid = new System.Windows.Forms.TextBox();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cusid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(336, 204);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 23);
            this.simpleButton2.TabIndex = 32;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(192, 204);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(63, 23);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "Send";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 25);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Message Body";
            this.metroLabel2.UseStyleColors = true;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(16, 81);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(112, 25);
            this.lic.TabIndex = 29;
            this.lic.Text = "Mobile Num ";
            this.lic.UseStyleColors = true;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(158, 106);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(269, 79);
            this.message.TabIndex = 28;
            // 
            // txt_cusmobile
            // 
            this.txt_cusmobile.Location = new System.Drawing.Point(158, 75);
            this.txt_cusmobile.Name = "txt_cusmobile";
            this.txt_cusmobile.Size = new System.Drawing.Size(269, 20);
            this.txt_cusmobile.TabIndex = 27;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(264, 204);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(63, 23);
            this.simpleButton3.TabIndex = 33;
            this.simpleButton3.Text = "Clear";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 25);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Customer Info";
            this.metroLabel1.UseStyleColors = true;
            // 
            // cbo_cusid
            // 
            this.cbo_cusid.Location = new System.Drawing.Point(158, 14);
            this.cbo_cusid.Name = "cbo_cusid";
            this.cbo_cusid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_cusid.Size = new System.Drawing.Size(207, 20);
            this.cbo_cusid.TabIndex = 36;
            this.cbo_cusid.TextChanged += new System.EventHandler(this.cust_TextChanged);
            // 
            // txt_custid
            // 
            this.txt_custid.Enabled = false;
            this.txt_custid.Location = new System.Drawing.Point(371, 14);
            this.txt_custid.Name = "txt_custid";
            this.txt_custid.Size = new System.Drawing.Size(56, 20);
            this.txt_custid.TabIndex = 37;
            this.txt_custid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_custname
            // 
            this.txt_custname.Enabled = false;
            this.txt_custname.Location = new System.Drawing.Point(158, 40);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(269, 20);
            this.txt_custname.TabIndex = 38;
            this.txt_custname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(16, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 25);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Name";
            this.metroLabel3.UseStyleColors = true;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(16, 162);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(63, 23);
            this.simpleButton4.TabIndex = 40;
            this.simpleButton4.Text = "English ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(85, 162);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(63, 23);
            this.simpleButton5.TabIndex = 41;
            this.simpleButton5.Text = "عربي";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // frmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_custname);
            this.Controls.Add(this.txt_custid);
            this.Controls.Add(this.cbo_cusid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lic);
            this.Controls.Add(this.message);
            this.Controls.Add(this.txt_cusmobile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSendSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS ";
            this.Load += new System.EventHandler(this.frmSendSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cusid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lic;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox txt_cusmobile;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_cusid;
        private System.Windows.Forms.TextBox txt_custid;
        private System.Windows.Forms.TextBox txt_custname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}