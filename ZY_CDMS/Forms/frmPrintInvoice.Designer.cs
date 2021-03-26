namespace ZY_CDMS.Forms
{
    partial class frmPrintInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintInvoice));
            this.cbo_vin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.txt_carinfo = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_sellprice = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtp_selldate = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_services = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_selldate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_selldate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_vin
            // 
            this.cbo_vin.Location = new System.Drawing.Point(8, 31);
            this.cbo_vin.Name = "cbo_vin";
            this.cbo_vin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_vin.Size = new System.Drawing.Size(166, 20);
            this.cbo_vin.TabIndex = 108;
            this.cbo_vin.TextChanged += new System.EventHandler(this.cbo_vin_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 107;
            this.metroLabel1.Text = "VIN";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(191, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 109;
            this.metroLabel2.Text = "Invoice No.";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Enabled = false;
            this.txt_invoiceno.Location = new System.Drawing.Point(192, 31);
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(125, 20);
            this.txt_invoiceno.TabIndex = 110;
            // 
            // txt_carinfo
            // 
            this.txt_carinfo.Enabled = false;
            this.txt_carinfo.Location = new System.Drawing.Point(80, 93);
            this.txt_carinfo.Multiline = true;
            this.txt_carinfo.Name = "txt_carinfo";
            this.txt_carinfo.Size = new System.Drawing.Size(237, 78);
            this.txt_carinfo.TabIndex = 112;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 111;
            this.metroLabel3.Text = "Car Details";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(337, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 113;
            this.metroLabel4.Text = "Price Details ";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_sellprice
            // 
            this.txt_sellprice.Enabled = false;
            this.txt_sellprice.Location = new System.Drawing.Point(405, 73);
            this.txt_sellprice.Name = "txt_sellprice";
            this.txt_sellprice.Size = new System.Drawing.Size(48, 20);
            this.txt_sellprice.TabIndex = 115;
            this.txt_sellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.Location = new System.Drawing.Point(323, 73);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 114;
            this.metroLabel5.Text = "Sell Price";
            this.metroLabel5.UseStyleColors = true;
            // 
            // dtp_selldate
            // 
            this.dtp_selldate.EditValue = null;
            this.dtp_selldate.Enabled = false;
            this.dtp_selldate.Location = new System.Drawing.Point(349, 31);
            this.dtp_selldate.Name = "dtp_selldate";
            this.dtp_selldate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_selldate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_selldate.Size = new System.Drawing.Size(154, 20);
            this.dtp_selldate.TabIndex = 116;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.Location = new System.Drawing.Point(349, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 117;
            this.metroLabel6.Text = "Selled in ";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txt_services
            // 
            this.txt_services.Enabled = false;
            this.txt_services.Location = new System.Drawing.Point(405, 99);
            this.txt_services.Name = "txt_services";
            this.txt_services.Size = new System.Drawing.Size(48, 20);
            this.txt_services.TabIndex = 119;
            this.txt_services.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.Location = new System.Drawing.Point(323, 100);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 118;
            this.metroLabel7.Text = "Services";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txt_tax
            // 
            this.txt_tax.Enabled = false;
            this.txt_tax.Location = new System.Drawing.Point(404, 125);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(48, 20);
            this.txt_tax.TabIndex = 121;
            this.txt_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.CustomForeColor = true;
            this.metroLabel8.Location = new System.Drawing.Point(324, 126);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 120;
            this.metroLabel8.Text = "Tax Value";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(404, 151);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(48, 20);
            this.txt_total.TabIndex = 123;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.Location = new System.Drawing.Point(324, 152);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 19);
            this.metroLabel9.TabIndex = 122;
            this.metroLabel9.Text = "Total ";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.CustomForeColor = true;
            this.metroLabel10.Location = new System.Drawing.Point(8, 71);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.TabIndex = 124;
            this.metroLabel10.Text = "Customer";
            this.metroLabel10.UseStyleColors = true;
            // 
            // txt_customer
            // 
            this.txt_customer.Enabled = false;
            this.txt_customer.Location = new System.Drawing.Point(80, 71);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(237, 20);
            this.txt_customer.TabIndex = 125;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(186, 192);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 31);
            this.simpleButton1.TabIndex = 126;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(404, 192);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 31);
            this.simpleButton3.TabIndex = 128;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(295, 192);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 31);
            this.simpleButton2.TabIndex = 127;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmPrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 235);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txt_services);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dtp_selldate);
            this.Controls.Add(this.txt_sellprice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_carinfo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_invoiceno);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_vin);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrintInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.frmPrintInvoice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrintInvoice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_selldate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_selldate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbo_vin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.TextBox txt_carinfo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_sellprice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private DevExpress.XtraEditors.DateEdit dtp_selldate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txt_services;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txt_tax;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txt_total;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.TextBox txt_customer;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}