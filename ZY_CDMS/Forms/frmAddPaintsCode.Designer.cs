namespace ZY_CDMS.Forms
{
    partial class frmAddPaintsCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPaintsCode));
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_pname = new System.Windows.Forms.MaskedTextBox();
            this.cbo_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pid
            // 
            this.txt_pid.Enabled = false;
            this.txt_pid.Location = new System.Drawing.Point(70, 41);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(81, 20);
            this.txt_pid.TabIndex = 22;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(284, 76);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(203, 76);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(122, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(70, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 25);
            this.metroLabel5.TabIndex = 57;
            this.metroLabel5.Text = "ID";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(157, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Paint Code";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(157, 41);
            this.txt_pname.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.PromptChar = ' ';
            this.txt_pname.Size = new System.Drawing.Size(245, 20);
            this.txt_pname.TabIndex = 0;
            // 
            // cbo_id
            // 
            this.cbo_id.Location = new System.Drawing.Point(12, 41);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_id.Size = new System.Drawing.Size(52, 20);
            this.cbo_id.TabIndex = 59;
            this.cbo_id.TextChanged += new System.EventHandler(this.cbo_id_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(28, 25);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "ID";
            this.metroLabel2.UseStyleColors = true;
            // 
            // frmAddPaintsCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 123);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_id);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_pid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAddPaintsCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Paints Code";
            this.Load += new System.EventHandler(this.frmAddPaintsCode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddPaintsCode_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_pid;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox txt_pname;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}