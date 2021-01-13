namespace ZY_CDMS.Forms
{
    partial class frmAddServicecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddServicecs));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.cbo_vin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_service = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_date = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_carinfo = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_serviceinfo = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_sercost = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_transid = new System.Windows.Forms.TextBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_service.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Vin";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.Location = new System.Drawing.Point(226, 20);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(51, 19);
            this.lic.TabIndex = 17;
            this.lic.Text = "Service";
            this.lic.UseStyleColors = true;
            // 
            // cbo_vin
            // 
            this.cbo_vin.Location = new System.Drawing.Point(93, 42);
            this.cbo_vin.Name = "cbo_vin";
            this.cbo_vin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_vin.Size = new System.Drawing.Size(127, 20);
            this.cbo_vin.TabIndex = 20;
            this.cbo_vin.TextChanged += new System.EventHandler(this.simpleButton4_Click);
            // 
            // cbo_service
            // 
            this.cbo_service.Location = new System.Drawing.Point(226, 42);
            this.cbo_service.Name = "cbo_service";
            this.cbo_service.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_service.Size = new System.Drawing.Size(127, 20);
            this.cbo_service.TabIndex = 21;
            this.cbo_service.TextChanged += new System.EventHandler(this.simpleButton5_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.EditValue = null;
            this.dtp_date.Location = new System.Drawing.Point(359, 42);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Size = new System.Drawing.Size(147, 20);
            this.dtp_date.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(359, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Date";
            this.metroLabel2.UseStyleColors = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(434, 111);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 28;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(356, 111);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(251, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 23);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_carinfo
            // 
            this.txt_carinfo.Location = new System.Drawing.Point(12, 92);
            this.txt_carinfo.Name = "txt_carinfo";
            this.txt_carinfo.Size = new System.Drawing.Size(203, 20);
            this.txt_carinfo.TabIndex = 29;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(434, 140);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 30;
            this.simpleButton4.Text = "View";
            this.simpleButton4.Visible = false;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Car Details ";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(120, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Service Description";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_serviceinfo
            // 
            this.txt_serviceinfo.Location = new System.Drawing.Point(12, 137);
            this.txt_serviceinfo.Name = "txt_serviceinfo";
            this.txt_serviceinfo.Size = new System.Drawing.Size(203, 20);
            this.txt_serviceinfo.TabIndex = 32;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Service Coast";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txt_sercost
            // 
            this.txt_sercost.Location = new System.Drawing.Point(12, 181);
            this.txt_sercost.Name = "txt_sercost";
            this.txt_sercost.Size = new System.Drawing.Size(203, 20);
            this.txt_sercost.TabIndex = 34;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(434, 168);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 36;
            this.simpleButton5.Text = "viewServcie";
            this.simpleButton5.Visible = false;
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 18);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Trans ID";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txt_transid
            // 
            this.txt_transid.Enabled = false;
            this.txt_transid.Location = new System.Drawing.Point(12, 40);
            this.txt_transid.Name = "txt_transid";
            this.txt_transid.Size = new System.Drawing.Size(64, 20);
            this.txt_transid.TabIndex = 38;
            this.txt_transid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(251, 160);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(102, 23);
            this.simpleButton6.TabIndex = 39;
            this.simpleButton6.Text = "Save and Print";
            this.simpleButton6.Visible = false;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // frmAddServicecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 212);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.txt_transid);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_sercost);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_serviceinfo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.txt_carinfo);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cbo_service);
            this.Controls.Add(this.cbo_vin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAddServicecs";
            this.Text = "Add Servicecs";
            this.Load += new System.EventHandler(this.frmAddServicecs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddServicecs_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_service.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lic;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_vin;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_service;
        private DevExpress.XtraEditors.DateEdit dtp_date;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_carinfo;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_serviceinfo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_sercost;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txt_transid;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}