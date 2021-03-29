namespace ZY_CDMS.Forms
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.cbo_reports = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtp_from = new DevExpress.XtraEditors.DateEdit();
            this.dtp_to = new DevExpress.XtraEditors.DateEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_reports.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_reports
            // 
            resources.ApplyResources(this.cbo_reports, "cbo_reports");
            this.cbo_reports.Name = "cbo_reports";
            this.cbo_reports.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbo_reports.Properties.Buttons"))))});
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.UseStyleColors = true;
            // 
            // dtp_from
            // 
            resources.ApplyResources(this.dtp_from, "dtp_from");
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtp_from.Properties.Buttons"))))});
            this.dtp_from.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtp_from.Properties.CalendarTimeProperties.Buttons"))))});
            // 
            // dtp_to
            // 
            resources.ApplyResources(this.dtp_to, "dtp_to");
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtp_to.Properties.Buttons"))))});
            this.dtp_to.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtp_to.Properties.CalendarTimeProperties.Buttons"))))});
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.UseStyleColors = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // MyGrid
            // 
            resources.ApplyResources(this.MyGrid, "MyGrid");
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton5, "simpleButton5");
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            resources.ApplyResources(this.simpleButton6, "simpleButton6");
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // frmReports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbo_reports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_reports.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbo_reports;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.DateEdit dtp_from;
        private DevExpress.XtraEditors.DateEdit dtp_to;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}