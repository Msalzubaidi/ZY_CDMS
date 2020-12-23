using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmAddPayMethod : Form
    {
        public frmAddPayMethod()
        {
            InitializeComponent();
        }

        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "PayMethods";
        private void frmAddPayMethod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            int x = r.FindMax(table);
            txt_pid.Text = x.ToString();
            txt_pname.Clear();
            txt_pname.Focus();
            toggleSwitch1.IsOn = true; 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_pid.Text) || r.isDigitsOnly(txt_pid.Text) == false || string.IsNullOrWhiteSpace(txt_pname.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txt_pid.Text);
                string name = txt_pname.Text;
                


                int rest = s.AddPM(id , name , table);
                if (rest <= 0)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
                else if (rest > 0)
                {
                    MessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();


                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                simpleButton4.Enabled = false;
                simpleButton5.Enabled = false;
                simpleButton6.Enabled = false;

            }
            if (toggleSwitch1.IsOn == false)
            {
                simpleButton4.Enabled = false;
                simpleButton5.Enabled = false;
                simpleButton6.Enabled = false;
            }
        }
    }
}
