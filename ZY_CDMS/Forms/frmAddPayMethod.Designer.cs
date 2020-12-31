namespace ZY_CDMS.Forms
{
    partial class frmAddPayMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPayMethod));
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pname = new System.Windows.Forms.MaskedTextBox();
            this.cbo_id = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pid
            // 
            this.txt_pid.Enabled = false;
            this.txt_pid.Location = new System.Drawing.Point(84, 37);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(37, 20);
            this.txt_pid.TabIndex = 0;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(12, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 25);
            this.metroLabel5.TabIndex = 53;
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
            this.metroLabel1.Location = new System.Drawing.Point(206, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.UseStyleColors = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(233, 72);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(63, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Cancel";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(164, 72);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Clear";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(95, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(63, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(127, 37);
            this.txt_pname.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.PromptChar = ' ';
            this.txt_pname.Size = new System.Drawing.Size(224, 20);
            this.txt_pname.TabIndex = 1;
            // 
            // cbo_id
            // 
            this.cbo_id.Location = new System.Drawing.Point(12, 37);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_id.Size = new System.Drawing.Size(66, 20);
            this.cbo_id.TabIndex = 55;
            this.cbo_id.TextChanged += new System.EventHandler(this.cbo_id_TextChanged);
            // 
            // frmAddPayMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 104);
            this.Controls.Add(this.cbo_id);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_pid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAddPayMethod";
            this.Text = "Add Pay Method";
            this.Load += new System.EventHandler(this.frmAddPayMethod_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddPayMethod_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_id.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_pid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.MaskedTextBox txt_pname;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_id;
    }
}