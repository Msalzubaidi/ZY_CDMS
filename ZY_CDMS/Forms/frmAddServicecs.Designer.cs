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
            this.cbo_cardetails = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_servicedetails = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_date = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cardetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_servicedetails.Properties)).BeginInit();
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
            this.metroLabel1.Location = new System.Drawing.Point(116, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Car";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.Location = new System.Drawing.Point(106, 65);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(51, 19);
            this.lic.TabIndex = 17;
            this.lic.Text = "Service";
            this.lic.UseStyleColors = true;
            // 
            // cbo_cardetails
            // 
            this.cbo_cardetails.Location = new System.Drawing.Point(12, 31);
            this.cbo_cardetails.Name = "cbo_cardetails";
            this.cbo_cardetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_cardetails.Size = new System.Drawing.Size(267, 20);
            this.cbo_cardetails.TabIndex = 20;
            // 
            // cbo_servicedetails
            // 
            this.cbo_servicedetails.Location = new System.Drawing.Point(12, 87);
            this.cbo_servicedetails.Name = "cbo_servicedetails";
            this.cbo_servicedetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_servicedetails.Size = new System.Drawing.Size(267, 20);
            this.cbo_servicedetails.TabIndex = 21;
            // 
            // dtp_date
            // 
            this.dtp_date.EditValue = null;
            this.dtp_date.Location = new System.Drawing.Point(311, 31);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_date.Size = new System.Drawing.Size(211, 20);
            this.dtp_date.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(388, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Date";
            this.metroLabel2.UseStyleColors = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(456, 85);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 28;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(375, 85);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(294, 85);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmAddServicecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 132);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cbo_servicedetails);
            this.Controls.Add(this.cbo_cardetails);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAddServicecs";
            this.Text = "Add Servicecs";
            this.Load += new System.EventHandler(this.frmAddServicecs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddServicecs_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cardetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_servicedetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lic;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_cardetails;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_servicedetails;
        private DevExpress.XtraEditors.DateEdit dtp_date;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}