namespace ZY_CDMS.Forms
{
    partial class frmWhatsNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhatsNew));
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.showagain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "In this Version ";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(333, 114);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            this.metroLabel1.UseStyleColors = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(317, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "OK, Close";
            // 
            // showagain
            // 
            this.showagain.AutoSize = true;
            this.showagain.Location = new System.Drawing.Point(24, 179);
            this.showagain.Name = "showagain";
            this.showagain.Size = new System.Drawing.Size(111, 17);
            this.showagain.TabIndex = 35;
            this.showagain.Text = "Don\'t Show Again";
            this.showagain.UseVisualStyleBackColor = true;
            // 
            // frmWhatsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.showagain);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWhatsNew";
            this.Text = "Whats New";
            this.Load += new System.EventHandler(this.frmWhatsNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.CheckBox showagain;
    }
}