namespace ZY_CDMS.Forms
{
    partial class frmAddNewCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewCar));
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_transid = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbo_makemodel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbo_color = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbo_year = new DevExpress.XtraEditors.ComboBoxEdit();
            this.nud_millages = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.dtp_datein = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbo_paymethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cbo_source = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_carstatus = new System.Windows.Forms.TextBox();
            this.txt_trantype = new System.Windows.Forms.TextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_vin = new System.Windows.Forms.MaskedTextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_color.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_millages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_datein.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_datein.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paymethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_source.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Trans ID ";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txt_transid
            // 
            this.txt_transid.Enabled = false;
            this.txt_transid.Location = new System.Drawing.Point(9, 36);
            this.txt_transid.Name = "txt_transid";
            this.txt_transid.Size = new System.Drawing.Size(63, 20);
            this.txt_transid.TabIndex = 55;
            this.txt_transid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(78, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "VIN ";
            this.metroLabel1.UseStyleColors = true;
            // 
            // cbo_makemodel
            // 
            this.cbo_makemodel.Location = new System.Drawing.Point(9, 88);
            this.cbo_makemodel.Name = "cbo_makemodel";
            this.cbo_makemodel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_makemodel.Size = new System.Drawing.Size(142, 20);
            this.cbo_makemodel.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Make / Model ";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(157, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Color";
            this.metroLabel3.UseStyleColors = true;
            // 
            // cbo_color
            // 
            this.cbo_color.Location = new System.Drawing.Point(157, 88);
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
            this.cbo_color.Size = new System.Drawing.Size(109, 20);
            this.cbo_color.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(272, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 63;
            this.metroLabel4.Text = "Year";
            this.metroLabel4.UseStyleColors = true;
            // 
            // cbo_year
            // 
            this.cbo_year.Location = new System.Drawing.Point(271, 88);
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
            this.cbo_year.Size = new System.Drawing.Size(109, 20);
            this.cbo_year.TabIndex = 4;
            // 
            // nud_millages
            // 
            this.nud_millages.Location = new System.Drawing.Point(386, 88);
            this.nud_millages.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_millages.Name = "nud_millages";
            this.nud_millages.Size = new System.Drawing.Size(79, 20);
            this.nud_millages.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.Location = new System.Drawing.Point(386, 66);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 65;
            this.metroLabel6.Text = "Millages";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 115);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 67;
            this.metroLabel7.Text = "Perchase Price";
            this.metroLabel7.UseStyleColors = true;
            // 
            // nud_price
            // 
            this.nud_price.Location = new System.Drawing.Point(9, 137);
            this.nud_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(79, 20);
            this.nud_price.TabIndex = 6;
            // 
            // dtp_datein
            // 
            this.dtp_datein.EditValue = null;
            this.dtp_datein.Location = new System.Drawing.Point(260, 36);
            this.dtp_datein.Name = "dtp_datein";
            this.dtp_datein.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_datein.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_datein.Properties.Mask.BeepOnError = true;
            this.dtp_datein.Size = new System.Drawing.Size(144, 20);
            this.dtp_datein.TabIndex = 1;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.CustomForeColor = true;
            this.metroLabel8.Location = new System.Drawing.Point(260, 14);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 69;
            this.metroLabel8.Text = "Date In";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.Location = new System.Drawing.Point(134, 115);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = " Payment Method";
            this.metroLabel9.UseStyleColors = true;
            // 
            // cbo_paymethod
            // 
            this.cbo_paymethod.Location = new System.Drawing.Point(134, 137);
            this.cbo_paymethod.Name = "cbo_paymethod";
            this.cbo_paymethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_paymethod.Size = new System.Drawing.Size(146, 20);
            this.cbo_paymethod.TabIndex = 7;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.CustomForeColor = true;
            this.metroLabel10.Location = new System.Drawing.Point(298, 115);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(128, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "Source Of Purchase ";
            this.metroLabel10.UseStyleColors = true;
            // 
            // cbo_source
            // 
            this.cbo_source.Location = new System.Drawing.Point(298, 137);
            this.cbo_source.Name = "cbo_source";
            this.cbo_source.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_source.Size = new System.Drawing.Size(167, 20);
            this.cbo_source.TabIndex = 8;
            // 
            // txt_carstatus
            // 
            this.txt_carstatus.Location = new System.Drawing.Point(73, 172);
            this.txt_carstatus.Name = "txt_carstatus";
            this.txt_carstatus.Size = new System.Drawing.Size(26, 20);
            this.txt_carstatus.TabIndex = 74;
            this.txt_carstatus.Text = "0";
            this.txt_carstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_carstatus.Visible = false;
            // 
            // txt_trantype
            // 
            this.txt_trantype.Location = new System.Drawing.Point(463, 9);
            this.txt_trantype.Name = "txt_trantype";
            this.txt_trantype.Size = new System.Drawing.Size(26, 20);
            this.txt_trantype.TabIndex = 75;
            this.txt_trantype.Text = "0";
            this.txt_trantype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trantype.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(398, 12);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(59, 15);
            this.metroLabel11.TabIndex = 76;
            this.metroLabel11.Text = "Type - Buy";
            this.metroLabel11.UseStyleColors = true;
            this.metroLabel11.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.CustomForeColor = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.Location = new System.Drawing.Point(6, 176);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(55, 15);
            this.metroLabel12.TabIndex = 77;
            this.metroLabel12.Text = "CarStatus";
            this.metroLabel12.UseStyleColors = true;
            this.metroLabel12.Visible = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.CustomForeColor = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.Location = new System.Drawing.Point(104, 176);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(92, 15);
            this.metroLabel13.TabIndex = 78;
            this.metroLabel13.Text = "0 : new  1 : selled ";
            this.metroLabel13.UseStyleColors = true;
            this.metroLabel13.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(236, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Add ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(78, 36);
            this.txt_vin.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.PromptChar = ' ';
            this.txt_vin.Size = new System.Drawing.Size(176, 20);
            this.txt_vin.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(400, 172);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 103;
            this.simpleButton4.Text = "Cancel";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click_1);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(319, 172);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 102;
            this.simpleButton5.Text = "Clear";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // frmAddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 207);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txt_trantype);
            this.Controls.Add(this.txt_carstatus);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.cbo_source);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cbo_paymethod);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtp_datein);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.nud_millages);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbo_year);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbo_color);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_makemodel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_transid);
            this.Controls.Add(this.metroLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAddNewCar";
            this.Text = "Add New Car";
            this.Load += new System.EventHandler(this.frmAddNewCar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewCar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_color.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_millages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_datein.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_datein.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_paymethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_source.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_transid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_makemodel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_color;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_year;
        private System.Windows.Forms.NumericUpDown nud_millages;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown nud_price;
        private DevExpress.XtraEditors.DateEdit dtp_datein;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_paymethod;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_source;
        private System.Windows.Forms.TextBox txt_carstatus;
        private System.Windows.Forms.TextBox txt_trantype;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.MaskedTextBox txt_vin;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}