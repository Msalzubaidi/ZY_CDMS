namespace ZY_CDMS.Forms
{
    partial class frmSellCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellCar));
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.txt_transid = new System.Windows.Forms.TextBox();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_carinfo = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtp_date = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbo_paymethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_service = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_taxper = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_taxval = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_trantype = new System.Windows.Forms.TextBox();
            this.txt_carstatus = new System.Windows.Forms.TextBox();
            this.txt_custid = new System.Windows.Forms.TextBox();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_custaddress = new System.Windows.Forms.TextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_custmobile = new System.Windows.Forms.TextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paymethod.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.Location = new System.Drawing.Point(12, 9);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(54, 19);
            this.lic.TabIndex = 10;
            this.lic.Text = "Trans ID";
            this.lic.UseStyleColors = true;
            // 
            // txt_transid
            // 
            this.txt_transid.Enabled = false;
            this.txt_transid.Location = new System.Drawing.Point(12, 31);
            this.txt_transid.Name = "txt_transid";
            this.txt_transid.Size = new System.Drawing.Size(54, 20);
            this.txt_transid.TabIndex = 11;
            this.txt_transid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(72, 31);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(177, 20);
            this.txt_vin.TabIndex = 13;
            this.txt_vin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_vin.Leave += new System.EventHandler(this.simpleButton6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(145, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "VIN";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_carinfo
            // 
            this.txt_carinfo.Enabled = false;
            this.txt_carinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carinfo.Location = new System.Drawing.Point(275, 71);
            this.txt_carinfo.Multiline = true;
            this.txt_carinfo.Name = "txt_carinfo";
            this.txt_carinfo.Size = new System.Drawing.Size(185, 145);
            this.txt_carinfo.TabIndex = 15;
            this.txt_carinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(275, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Car Info";
            this.metroLabel2.UseStyleColors = true;
            // 
            // dtp_date
            // 
            this.dtp_date.EditValue = null;
            this.dtp_date.Location = new System.Drawing.Point(255, 31);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Size = new System.Drawing.Size(165, 20);
            this.dtp_date.TabIndex = 16;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(308, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Sell date";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.Location = new System.Drawing.Point(423, 9);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 73;
            this.metroLabel9.Text = " Payment Method";
            this.metroLabel9.UseStyleColors = true;
            // 
            // cbo_paymethod
            // 
            this.cbo_paymethod.Location = new System.Drawing.Point(423, 31);
            this.cbo_paymethod.Name = "cbo_paymethod";
            this.cbo_paymethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_paymethod.Size = new System.Drawing.Size(118, 20);
            this.cbo_paymethod.TabIndex = 72;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(87, 25);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(61, 20);
            this.txt_price.TabIndex = 75;
            this.txt_price.Text = "0";
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 74;
            this.metroLabel4.Text = "Price";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(87, 48);
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(61, 20);
            this.txt_service.TabIndex = 77;
            this.txt_service.Text = "0";
            this.txt_service.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 45);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Services";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txt_taxper
            // 
            this.txt_taxper.Location = new System.Drawing.Point(203, 92);
            this.txt_taxper.Name = "txt_taxper";
            this.txt_taxper.Size = new System.Drawing.Size(34, 20);
            this.txt_taxper.TabIndex = 79;
            this.txt_taxper.Text = "0";
            this.txt_taxper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_taxper.TextChanged += new System.EventHandler(this.txt_taxper_TextChanged);
            this.txt_taxper.Leave += new System.EventHandler(this.simpleButton4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 73);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(27, 19);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "Tax";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txt_taxval
            // 
            this.txt_taxval.Location = new System.Drawing.Point(87, 74);
            this.txt_taxval.Name = "txt_taxval";
            this.txt_taxval.Size = new System.Drawing.Size(61, 20);
            this.txt_taxval.TabIndex = 80;
            this.txt_taxval.Text = "0";
            this.txt_taxval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_taxval.Leave += new System.EventHandler(this.simpleButton5_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.Location = new System.Drawing.Point(155, 92);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 81;
            this.metroLabel7.Text = "Tax %";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Location = new System.Drawing.Point(87, 121);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(61, 20);
            this.txt_totalprice.TabIndex = 83;
            this.txt_totalprice.Text = "0";
            this.txt_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.CustomForeColor = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 124);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 82;
            this.metroLabel8.Text = "Total Price";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.CustomForeColor = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.Location = new System.Drawing.Point(643, 9);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(92, 15);
            this.metroLabel13.TabIndex = 88;
            this.metroLabel13.Text = "0 : new  1 : selled ";
            this.metroLabel13.UseStyleColors = true;
            this.metroLabel13.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.CustomForeColor = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.Location = new System.Drawing.Point(550, 9);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(55, 15);
            this.metroLabel12.TabIndex = 87;
            this.metroLabel12.Text = "CarStatus";
            this.metroLabel12.UseStyleColors = true;
            this.metroLabel12.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(604, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 15);
            this.metroLabel11.TabIndex = 86;
            this.metroLabel11.Text = "Type -Sell";
            this.metroLabel11.UseStyleColors = true;
            this.metroLabel11.Visible = false;
            // 
            // txt_trantype
            // 
            this.txt_trantype.Location = new System.Drawing.Point(664, 27);
            this.txt_trantype.Name = "txt_trantype";
            this.txt_trantype.Size = new System.Drawing.Size(26, 20);
            this.txt_trantype.TabIndex = 85;
            this.txt_trantype.Text = "1";
            this.txt_trantype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trantype.Visible = false;
            // 
            // txt_carstatus
            // 
            this.txt_carstatus.Location = new System.Drawing.Point(611, 4);
            this.txt_carstatus.Name = "txt_carstatus";
            this.txt_carstatus.Size = new System.Drawing.Size(26, 20);
            this.txt_carstatus.TabIndex = 84;
            this.txt_carstatus.Text = "1";
            this.txt_carstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_carstatus.Visible = false;
            // 
            // txt_custid
            // 
            this.txt_custid.Location = new System.Drawing.Point(60, 19);
            this.txt_custid.Name = "txt_custid";
            this.txt_custid.Size = new System.Drawing.Size(177, 20);
            this.txt_custid.TabIndex = 90;
            this.txt_custid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_custname
            // 
            this.txt_custname.Enabled = false;
            this.txt_custname.Location = new System.Drawing.Point(60, 44);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(177, 20);
            this.txt_custname.TabIndex = 92;
            this.txt_custname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel14.CustomBackground = true;
            this.metroLabel14.CustomForeColor = true;
            this.metroLabel14.Location = new System.Drawing.Point(2, 41);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(45, 19);
            this.metroLabel14.TabIndex = 91;
            this.metroLabel14.Text = "Name";
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel15.CustomBackground = true;
            this.metroLabel15.CustomForeColor = true;
            this.metroLabel15.Location = new System.Drawing.Point(2, 18);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(21, 19);
            this.metroLabel15.TabIndex = 93;
            this.metroLabel15.Text = "ID";
            this.metroLabel15.UseStyleColors = true;
            // 
            // txt_custaddress
            // 
            this.txt_custaddress.Enabled = false;
            this.txt_custaddress.Location = new System.Drawing.Point(60, 70);
            this.txt_custaddress.Name = "txt_custaddress";
            this.txt_custaddress.Size = new System.Drawing.Size(177, 20);
            this.txt_custaddress.TabIndex = 95;
            this.txt_custaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel16.CustomBackground = true;
            this.metroLabel16.CustomForeColor = true;
            this.metroLabel16.Location = new System.Drawing.Point(1, 70);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(56, 19);
            this.metroLabel16.TabIndex = 94;
            this.metroLabel16.Text = "Address";
            this.metroLabel16.UseStyleColors = true;
            // 
            // txt_custmobile
            // 
            this.txt_custmobile.Enabled = false;
            this.txt_custmobile.Location = new System.Drawing.Point(60, 96);
            this.txt_custmobile.Name = "txt_custmobile";
            this.txt_custmobile.Size = new System.Drawing.Size(177, 20);
            this.txt_custmobile.TabIndex = 97;
            this.txt_custmobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel17.CustomBackground = true;
            this.metroLabel17.CustomForeColor = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 95);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(50, 19);
            this.metroLabel17.TabIndex = 96;
            this.metroLabel17.Text = "Mobile";
            this.metroLabel17.UseStyleColors = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(587, 248);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 31);
            this.simpleButton3.TabIndex = 100;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(478, 248);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 31);
            this.simpleButton2.TabIndex = 99;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(87, 222);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(70, 23);
            this.simpleButton4.TabIndex = 101;
            this.simpleButton4.Text = "Tax Cal";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(163, 222);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(70, 23);
            this.simpleButton5.TabIndex = 102;
            this.simpleButton5.Text = "Total Cal";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(275, 222);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(56, 23);
            this.simpleButton6.TabIndex = 103;
            this.simpleButton6.Text = "Car info";
            this.simpleButton6.Visible = false;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(11, 222);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(70, 23);
            this.simpleButton7.TabIndex = 104;
            this.simpleButton7.Text = "Services";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(23, 118);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(70, 23);
            this.simpleButton8.TabIndex = 105;
            this.simpleButton8.Text = "Customer";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(99, 119);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(66, 22);
            this.simpleButton9.TabIndex = 106;
            this.simpleButton9.Text = "Add ";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(171, 119);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(66, 22);
            this.simpleButton11.TabIndex = 108;
            this.simpleButton11.Text = "Update";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.metroLabel18);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_service);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txt_taxper);
            this.groupBox1.Controls.Add(this.txt_taxval);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txt_totalprice);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 149);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Details";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(87, 97);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(61, 20);
            this.txt_discount.TabIndex = 85;
            this.txt_discount.Text = "0";
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discount.Leave += new System.EventHandler(this.simpleButton5_Click);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel18.CustomBackground = true;
            this.metroLabel18.CustomForeColor = true;
            this.metroLabel18.Location = new System.Drawing.Point(8, 96);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(61, 19);
            this.metroLabel18.TabIndex = 84;
            this.metroLabel18.Text = "DisCount";
            this.metroLabel18.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_custid);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.simpleButton8);
            this.groupBox2.Controls.Add(this.simpleButton11);
            this.groupBox2.Controls.Add(this.txt_custname);
            this.groupBox2.Controls.Add(this.simpleButton9);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.txt_custaddress);
            this.groupBox2.Controls.Add(this.metroLabel17);
            this.groupBox2.Controls.Add(this.txt_custmobile);
            this.groupBox2.Location = new System.Drawing.Point(466, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 149);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(369, 248);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 31);
            this.simpleButton1.TabIndex = 111;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.CustomForeColor = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(156, 14);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 75);
            this.metroLabel10.TabIndex = 86;
            this.metroLabel10.Text = "Please Type \r\nTax Percentage\r\n To calculate\r\n Value Of Tax\r\n";
            this.metroLabel10.UseStyleColors = true;
            // 
            // frmSellCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 291);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txt_trantype);
            this.Controls.Add(this.txt_carstatus);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cbo_paymethod);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_carinfo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_transid);
            this.Controls.Add(this.lic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSellCar";
            this.Text = "Sell Car";
            this.Load += new System.EventHandler(this.frmSellCar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSellCar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paymethod.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lic;
        private System.Windows.Forms.TextBox txt_transid;
        private System.Windows.Forms.TextBox txt_vin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_carinfo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevExpress.XtraEditors.DateEdit dtp_date;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_paymethod;
        private System.Windows.Forms.TextBox txt_price;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_service;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_taxper;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txt_taxval;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txt_totalprice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox txt_trantype;
        private System.Windows.Forms.TextBox txt_carstatus;
        private System.Windows.Forms.TextBox txt_custid;
        private System.Windows.Forms.TextBox txt_custname;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.TextBox txt_custaddress;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.TextBox txt_custmobile;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_discount;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}