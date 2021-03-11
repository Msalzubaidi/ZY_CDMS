namespace ZY_CDMS.Forms
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.cbo_makemodel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_vin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.selled = new System.Windows.Forms.CheckBox();
            this.newcar = new System.Windows.Forms.CheckBox();
            this.pricefrom = new System.Windows.Forms.TextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.priceto = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.CheckBox();
            this.cheq = new System.Windows.Forms.CheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.millto = new System.Windows.Forms.TextBox();
            this.millfrom = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_makemodel
            // 
            this.cbo_makemodel.Location = new System.Drawing.Point(431, 14);
            this.cbo_makemodel.Name = "cbo_makemodel";
            this.cbo_makemodel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_makemodel.Size = new System.Drawing.Size(244, 20);
            this.cbo_makemodel.TabIndex = 0;
            this.cbo_makemodel.TextChanged += new System.EventHandler(this.cbo_makemodel_TextChanged);
            // 
            // cbo_vin
            // 
            this.cbo_vin.Location = new System.Drawing.Point(61, 14);
            this.cbo_vin.Name = "cbo_vin";
            this.cbo_vin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_vin.Size = new System.Drawing.Size(244, 20);
            this.cbo_vin.TabIndex = 47;
            this.cbo_vin.TextChanged += new System.EventHandler(this.cbo_vin_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "By vin";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.Location = new System.Drawing.Point(324, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "By Make Model";
            this.metroLabel2.UseStyleColors = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(799, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 52;
            this.simpleButton1.Text = "Clear";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(799, 46);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 53;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // selled
            // 
            this.selled.AutoSize = true;
            this.selled.Location = new System.Drawing.Point(110, 41);
            this.selled.Name = "selled";
            this.selled.Size = new System.Drawing.Size(54, 17);
            this.selled.TabIndex = 54;
            this.selled.Text = "Selled";
            this.selled.UseVisualStyleBackColor = true;
            // 
            // newcar
            // 
            this.newcar.AutoSize = true;
            this.newcar.Location = new System.Drawing.Point(110, 64);
            this.newcar.Name = "newcar";
            this.newcar.Size = new System.Drawing.Size(67, 17);
            this.newcar.TabIndex = 55;
            this.newcar.Text = "New Car";
            this.newcar.UseVisualStyleBackColor = true;
            // 
            // pricefrom
            // 
            this.pricefrom.Location = new System.Drawing.Point(352, 39);
            this.pricefrom.Name = "pricefrom";
            this.pricefrom.Size = new System.Drawing.Size(92, 20);
            this.pricefrom.TabIndex = 110;
            this.pricefrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel19.CustomBackground = true;
            this.metroLabel19.CustomForeColor = true;
            this.metroLabel19.Location = new System.Drawing.Point(262, 46);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(84, 19);
            this.metroLabel19.TabIndex = 109;
            this.metroLabel19.Text = "Price Btween";
            this.metroLabel19.UseStyleColors = true;
            // 
            // priceto
            // 
            this.priceto.Location = new System.Drawing.Point(352, 62);
            this.priceto.Name = "priceto";
            this.priceto.Size = new System.Drawing.Size(92, 20);
            this.priceto.TabIndex = 112;
            this.priceto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(192, 64);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(50, 17);
            this.cash.TabIndex = 114;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            // 
            // cheq
            // 
            this.cheq.AutoSize = true;
            this.cheq.Location = new System.Drawing.Point(192, 41);
            this.cheq.Name = "cheq";
            this.cheq.Size = new System.Drawing.Size(51, 17);
            this.cheq.TabIndex = 113;
            this.cheq.Text = "Cheq";
            this.cheq.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.Location = new System.Drawing.Point(450, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 119;
            this.metroLabel3.Text = "Millages Between";
            this.metroLabel3.UseStyleColors = true;
            // 
            // millto
            // 
            this.millto.Location = new System.Drawing.Point(566, 61);
            this.millto.Name = "millto";
            this.millto.Size = new System.Drawing.Size(92, 20);
            this.millto.TabIndex = 121;
            this.millto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // millfrom
            // 
            this.millfrom.Location = new System.Drawing.Point(566, 38);
            this.millfrom.Name = "millfrom";
            this.millfrom.Size = new System.Drawing.Size(92, 20);
            this.millfrom.TabIndex = 120;
            this.millfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Enabled = false;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(686, 46);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 125;
            this.simpleButton3.Text = "Search";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 46);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 126;
            this.metroLabel4.Text = "By Filters";
            this.metroLabel4.UseStyleColors = true;
            // 
            // MyGrid
            // 
            this.MyGrid.Location = new System.Drawing.Point(3, 89);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.Size = new System.Drawing.Size(871, 240);
            this.MyGrid.TabIndex = 127;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 341);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.millto);
            this.Controls.Add(this.millfrom);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.cheq);
            this.Controls.Add(this.priceto);
            this.Controls.Add(this.pricefrom);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.newcar);
            this.Controls.Add(this.selled);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbo_vin);
            this.Controls.Add(this.cbo_makemodel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_makemodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_vin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbo_makemodel;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_vin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.CheckBox selled;
        private System.Windows.Forms.CheckBox newcar;
        private System.Windows.Forms.TextBox pricefrom;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private System.Windows.Forms.TextBox priceto;
        private System.Windows.Forms.CheckBox cash;
        private System.Windows.Forms.CheckBox cheq;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox millto;
        private System.Windows.Forms.TextBox millfrom;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}