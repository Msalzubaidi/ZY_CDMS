namespace ZY_CDMS.Forms
{
    partial class frmAddCarTset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCarTset));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_cusid = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_custname = new System.Windows.Forms.TextBox();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_custaddress = new System.Windows.Forms.TextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txt_custmobile = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.cbo_makemodel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbo_year = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbo_color = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbo_paints = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_date = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_trantype = new System.Windows.Forms.TextBox();
            this.txt_dirty = new System.Windows.Forms.TextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_clean = new System.Windows.Forms.TextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_repair = new System.Windows.Forms.TextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txt_transid = new System.Windows.Forms.TextBox();
            this.imageA = new System.Windows.Forms.PictureBox();
            this.imageB = new System.Windows.Forms.PictureBox();
            this.imageC = new System.Windows.Forms.PictureBox();
            this.imageD = new System.Windows.Forms.PictureBox();
            this.cbo_tax = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cusid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_color.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paints.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tax.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_cusid);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.txt_custname);
            this.groupBox2.Controls.Add(this.simpleButton9);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.txt_custaddress);
            this.groupBox2.Controls.Add(this.metroLabel17);
            this.groupBox2.Controls.Add(this.txt_custmobile);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // cbo_cusid
            // 
            this.cbo_cusid.Location = new System.Drawing.Point(60, 21);
            this.cbo_cusid.Name = "cbo_cusid";
            this.cbo_cusid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_cusid.Size = new System.Drawing.Size(177, 20);
            this.cbo_cusid.TabIndex = 107;
            this.cbo_cusid.TextChanged += new System.EventHandler(this.cbo_cusid_TextChanged);
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
            // txt_custname
            // 
            this.txt_custname.Enabled = false;
            this.txt_custname.Location = new System.Drawing.Point(60, 44);
            this.txt_custname.Name = "txt_custname";
            this.txt_custname.Size = new System.Drawing.Size(177, 20);
            this.txt_custname.TabIndex = 92;
            this.txt_custname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton9
            // 
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(128, 119);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(109, 22);
            this.simpleButton9.TabIndex = 106;
            this.simpleButton9.Text = "Add  - Update";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
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
            // txt_custaddress
            // 
            this.txt_custaddress.Enabled = false;
            this.txt_custaddress.Location = new System.Drawing.Point(60, 70);
            this.txt_custaddress.Name = "txt_custaddress";
            this.txt_custaddress.Size = new System.Drawing.Size(177, 20);
            this.txt_custaddress.TabIndex = 95;
            this.txt_custaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txt_custmobile
            // 
            this.txt_custmobile.Enabled = false;
            this.txt_custmobile.Location = new System.Drawing.Point(60, 96);
            this.txt_custmobile.Name = "txt_custmobile";
            this.txt_custmobile.Size = new System.Drawing.Size(177, 20);
            this.txt_custmobile.TabIndex = 97;
            this.txt_custmobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(284, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 108;
            this.metroLabel1.Text = "Vin";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(284, 33);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(177, 20);
            this.txt_vin.TabIndex = 109;
            this.txt_vin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_makemodel
            // 
            this.cbo_makemodel.Location = new System.Drawing.Point(284, 79);
            this.cbo_makemodel.Name = "cbo_makemodel";
            this.cbo_makemodel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_makemodel.Size = new System.Drawing.Size(135, 20);
            this.cbo_makemodel.TabIndex = 108;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(284, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 110;
            this.metroLabel2.Text = "Make - Model";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(425, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 112;
            this.metroLabel3.Text = "Year";
            this.metroLabel3.UseStyleColors = true;
            // 
            // cbo_year
            // 
            this.cbo_year.Location = new System.Drawing.Point(423, 79);
            this.cbo_year.Name = "cbo_year";
            this.cbo_year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_year.Properties.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbo_year.Size = new System.Drawing.Size(65, 20);
            this.cbo_year.TabIndex = 111;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(496, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 114;
            this.metroLabel4.Text = "Color";
            this.metroLabel4.UseStyleColors = true;
            // 
            // cbo_color
            // 
            this.cbo_color.Location = new System.Drawing.Point(493, 79);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_color.Properties.Items.AddRange(new object[] {
            "White",
            "Yellow",
            "Blue",
            "Red",
            "Green",
            "Black",
            "Brown",
            "Azure",
            "Ivory",
            "Teal",
            "Silver",
            "Purple",
            "Navy blue",
            "Pea green",
            "Gray",
            "Orange",
            "Maroon",
            "Charcoal",
            "Aquamarine",
            "Coral",
            "Fuchsia",
            "Wheat",
            "Lime",
            "Crimson",
            "Khaki",
            "Hot pink",
            "Magenta",
            "Olden",
            "Plum",
            "Olive",
            "Cyan"});
            this.cbo_color.Size = new System.Drawing.Size(65, 20);
            this.cbo_color.TabIndex = 113;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.Location = new System.Drawing.Point(564, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 116;
            this.metroLabel5.Text = "Paint Code";
            this.metroLabel5.UseStyleColors = true;
            // 
            // cbo_paints
            // 
            this.cbo_paints.Location = new System.Drawing.Point(564, 79);
            this.cbo_paints.Name = "cbo_paints";
            this.cbo_paints.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_paints.Size = new System.Drawing.Size(108, 20);
            this.cbo_paints.TabIndex = 115;
            // 
            // dtp_date
            // 
            this.dtp_date.EditValue = null;
            this.dtp_date.Location = new System.Drawing.Point(467, 35);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Size = new System.Drawing.Size(205, 20);
            this.dtp_date.TabIndex = 117;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.Location = new System.Drawing.Point(467, 12);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 118;
            this.metroLabel6.Text = "Date";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.Location = new System.Drawing.Point(369, 107);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 19);
            this.metroLabel7.TabIndex = 119;
            this.metroLabel7.Text = "Balance";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(284, 129);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(79, 20);
            this.txt_pay.TabIndex = 120;
            this.txt_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.CustomForeColor = true;
            this.metroLabel8.Location = new System.Drawing.Point(284, 109);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 121;
            this.metroLabel8.Text = "Payment";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txt_bal
            // 
            this.txt_bal.Location = new System.Drawing.Point(369, 129);
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.Size = new System.Drawing.Size(79, 20);
            this.txt_bal.TabIndex = 122;
            this.txt_bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.Location = new System.Drawing.Point(454, 109);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 123;
            this.metroLabel9.Text = "GST/HST Tax";
            this.metroLabel9.UseStyleColors = true;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(542, 131);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(90, 20);
            this.txt_total.TabIndex = 126;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.CustomForeColor = true;
            this.metroLabel10.Location = new System.Drawing.Point(542, 109);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 19);
            this.metroLabel10.TabIndex = 125;
            this.metroLabel10.Text = "Total Payment";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.Location = new System.Drawing.Point(481, 163);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(57, 19);
            this.metroLabel11.TabIndex = 128;
            this.metroLabel11.Text = "TestType";
            this.metroLabel11.UseStyleColors = true;
            this.metroLabel11.Visible = false;
            // 
            // txt_trantype
            // 
            this.txt_trantype.Enabled = false;
            this.txt_trantype.Location = new System.Drawing.Point(542, 163);
            this.txt_trantype.Name = "txt_trantype";
            this.txt_trantype.Size = new System.Drawing.Size(68, 20);
            this.txt_trantype.TabIndex = 127;
            this.txt_trantype.Text = "2";
            this.txt_trantype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trantype.Visible = false;
            // 
            // txt_dirty
            // 
            this.txt_dirty.Location = new System.Drawing.Point(15, 189);
            this.txt_dirty.Multiline = true;
            this.txt_dirty.Name = "txt_dirty";
            this.txt_dirty.Size = new System.Drawing.Size(140, 66);
            this.txt_dirty.TabIndex = 129;
            this.txt_dirty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.CustomForeColor = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 167);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 19);
            this.metroLabel12.TabIndex = 130;
            this.metroLabel12.Text = "Car Dirty";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.CustomForeColor = true;
            this.metroLabel13.Location = new System.Drawing.Point(161, 167);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(67, 19);
            this.metroLabel13.TabIndex = 132;
            this.metroLabel13.Text = "Car Clean";
            this.metroLabel13.UseStyleColors = true;
            // 
            // txt_clean
            // 
            this.txt_clean.Location = new System.Drawing.Point(161, 189);
            this.txt_clean.Multiline = true;
            this.txt_clean.Name = "txt_clean";
            this.txt_clean.Size = new System.Drawing.Size(140, 66);
            this.txt_clean.TabIndex = 131;
            this.txt_clean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel18.CustomBackground = true;
            this.metroLabel18.CustomForeColor = true;
            this.metroLabel18.Location = new System.Drawing.Point(307, 167);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(116, 19);
            this.metroLabel18.TabIndex = 134;
            this.metroLabel18.Text = "Repair Description";
            this.metroLabel18.UseStyleColors = true;
            // 
            // txt_repair
            // 
            this.txt_repair.Location = new System.Drawing.Point(307, 189);
            this.txt_repair.Multiline = true;
            this.txt_repair.Name = "txt_repair";
            this.txt_repair.Size = new System.Drawing.Size(314, 66);
            this.txt_repair.TabIndex = 133;
            this.txt_repair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel19.CustomBackground = true;
            this.metroLabel19.CustomForeColor = true;
            this.metroLabel19.Location = new System.Drawing.Point(679, 39);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(18, 19);
            this.metroLabel19.TabIndex = 139;
            this.metroLabel19.Text = "A";
            this.metroLabel19.UseStyleColors = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel20.CustomBackground = true;
            this.metroLabel20.CustomForeColor = true;
            this.metroLabel20.Location = new System.Drawing.Point(778, 39);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(17, 19);
            this.metroLabel20.TabIndex = 140;
            this.metroLabel20.Text = "B";
            this.metroLabel20.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.CustomForeColor = true;
            this.metroLabel21.Location = new System.Drawing.Point(678, 236);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(18, 19);
            this.metroLabel21.TabIndex = 141;
            this.metroLabel21.Text = "C";
            this.metroLabel21.UseStyleColors = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel22.CustomBackground = true;
            this.metroLabel22.CustomForeColor = true;
            this.metroLabel22.Location = new System.Drawing.Point(777, 236);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(18, 19);
            this.metroLabel22.TabIndex = 142;
            this.metroLabel22.Text = "D";
            this.metroLabel22.UseStyleColors = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(552, 263);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 31);
            this.simpleButton1.TabIndex = 143;
            this.simpleButton1.Text = "Add";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(770, 263);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 31);
            this.simpleButton3.TabIndex = 145;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(661, 263);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 31);
            this.simpleButton2.TabIndex = 144;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel23.CustomBackground = true;
            this.metroLabel23.CustomForeColor = true;
            this.metroLabel23.Location = new System.Drawing.Point(687, 12);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(65, 19);
            this.metroLabel23.TabIndex = 147;
            this.metroLabel23.Text = "Invoice ID";
            this.metroLabel23.UseStyleColors = true;
            // 
            // txt_transid
            // 
            this.txt_transid.Enabled = false;
            this.txt_transid.Location = new System.Drawing.Point(758, 12);
            this.txt_transid.Name = "txt_transid";
            this.txt_transid.Size = new System.Drawing.Size(105, 20);
            this.txt_transid.TabIndex = 146;
            this.txt_transid.Text = "2";
            this.txt_transid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageA
            // 
            this.imageA.Image = ((System.Drawing.Image)(resources.GetObject("imageA.Image")));
            this.imageA.Location = new System.Drawing.Point(678, 61);
            this.imageA.Name = "imageA";
            this.imageA.Size = new System.Drawing.Size(94, 90);
            this.imageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageA.TabIndex = 148;
            this.imageA.TabStop = false;
            this.imageA.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageB
            // 
            this.imageB.Image = ((System.Drawing.Image)(resources.GetObject("imageB.Image")));
            this.imageB.Location = new System.Drawing.Point(777, 61);
            this.imageB.Name = "imageB";
            this.imageB.Size = new System.Drawing.Size(99, 91);
            this.imageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageB.TabIndex = 149;
            this.imageB.TabStop = false;
            this.imageB.Click += new System.EventHandler(this.imageB_Click);
            // 
            // imageC
            // 
            this.imageC.Image = ((System.Drawing.Image)(resources.GetObject("imageC.Image")));
            this.imageC.Location = new System.Drawing.Point(678, 154);
            this.imageC.Name = "imageC";
            this.imageC.Size = new System.Drawing.Size(94, 79);
            this.imageC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageC.TabIndex = 150;
            this.imageC.TabStop = false;
            this.imageC.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // imageD
            // 
            this.imageD.Image = ((System.Drawing.Image)(resources.GetObject("imageD.Image")));
            this.imageD.Location = new System.Drawing.Point(777, 154);
            this.imageD.Name = "imageD";
            this.imageD.Size = new System.Drawing.Size(99, 79);
            this.imageD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageD.TabIndex = 151;
            this.imageD.TabStop = false;
            this.imageD.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // cbo_tax
            // 
            this.cbo_tax.Location = new System.Drawing.Point(454, 131);
            this.cbo_tax.Name = "cbo_tax";
            this.cbo_tax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_tax.Size = new System.Drawing.Size(82, 20);
            this.cbo_tax.TabIndex = 152;
            // 
            // frmAddCarTset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 302);
            this.Controls.Add(this.cbo_tax);
            this.Controls.Add(this.imageD);
            this.Controls.Add(this.imageC);
            this.Controls.Add(this.imageB);
            this.Controls.Add(this.imageA);
            this.Controls.Add(this.metroLabel23);
            this.Controls.Add(this.txt_transid);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txt_repair);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txt_clean);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txt_dirty);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txt_trantype);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txt_bal);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbo_paints);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbo_color);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbo_year);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_makemodel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmAddCarTset";
            this.Text = "Add Car Test";
            this.Load += new System.EventHandler(this.frmAddCarTset_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddCarTset_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cusid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_color.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paints.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tax.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_cusid;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.TextBox txt_custname;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.TextBox txt_custaddress;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.TextBox txt_custmobile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_vin;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_makemodel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_year;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_color;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_paints;
        private DevExpress.XtraEditors.DateEdit dtp_date;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txt_pay;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txt_bal;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txt_total;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox txt_trantype;
        private System.Windows.Forms.TextBox txt_dirty;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.TextBox txt_clean;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.TextBox txt_repair;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private System.Windows.Forms.TextBox txt_transid;
        private System.Windows.Forms.PictureBox imageA;
        private System.Windows.Forms.PictureBox imageB;
        private System.Windows.Forms.PictureBox imageC;
        private System.Windows.Forms.PictureBox imageD;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_tax;
    }
}