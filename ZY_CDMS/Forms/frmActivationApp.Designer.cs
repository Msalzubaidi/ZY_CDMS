namespace ZY_CDMS.Forms
{
    partial class frmActivationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivationApp));
            this.key = new System.Windows.Forms.TextBox();
            this.txt_comname = new System.Windows.Forms.TextBox();
            this.lic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.master = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.from = new MetroFramework.Controls.MetroLabel();
            this.to = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Enabled = false;
            this.key.Location = new System.Drawing.Point(225, 37);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(220, 20);
            this.key.TabIndex = 15;
            // 
            // txt_comname
            // 
            this.txt_comname.Enabled = false;
            this.txt_comname.Location = new System.Drawing.Point(12, 37);
            this.txt_comname.Name = "txt_comname";
            this.txt_comname.Size = new System.Drawing.Size(207, 20);
            this.txt_comname.TabIndex = 13;
            // 
            // lic
            // 
            this.lic.AutoSize = true;
            this.lic.BackColor = System.Drawing.SystemColors.Control;
            this.lic.CustomBackground = true;
            this.lic.CustomForeColor = true;
            this.lic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lic.Location = new System.Drawing.Point(12, 9);
            this.lic.Name = "lic";
            this.lic.Size = new System.Drawing.Size(136, 25);
            this.lic.TabIndex = 21;
            this.lic.Text = "Company Name";
            this.lic.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(225, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 25);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Activation Key";
            this.metroLabel2.UseStyleColors = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(225, 161);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 23);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Activate Now";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(324, 161);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(95, 23);
            this.simpleButton2.TabIndex = 26;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(258, 78);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "NotActivated";
            this.toggleSwitch1.Properties.OnText = "Activated";
            this.toggleSwitch1.Size = new System.Drawing.Size(157, 23);
            this.toggleSwitch1.TabIndex = 27;
            // 
            // master
            // 
            this.master.Location = new System.Drawing.Point(106, 81);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(127, 20);
            this.master.TabIndex = 28;
            this.master.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Master Key";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(146, 25);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Licencse Duration";
            this.metroLabel3.UseStyleColors = true;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.BackColor = System.Drawing.SystemColors.Control;
            this.from.CustomBackground = true;
            this.from.CustomForeColor = true;
            this.from.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.from.Location = new System.Drawing.Point(12, 128);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(48, 25);
            this.from.TabIndex = 31;
            this.from.Text = "from";
            this.from.UseStyleColors = true;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.BackColor = System.Drawing.SystemColors.Control;
            this.to.CustomBackground = true;
            this.to.CustomForeColor = true;
            this.to.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.to.Location = new System.Drawing.Point(258, 128);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(27, 25);
            this.to.TabIndex = 32;
            this.to.Text = "to";
            this.to.UseStyleColors = true;
            // 
            // frmActivationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 195);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.master);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lic);
            this.Controls.Add(this.key);
            this.Controls.Add(this.txt_comname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmActivationApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivationApp";
            this.Load += new System.EventHandler(this.frmActivationApp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmActivationApp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox txt_comname;
        private MetroFramework.Controls.MetroLabel lic;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.TextBox master;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel from;
        private MetroFramework.Controls.MetroLabel to;
    }
}