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
    public partial class frmAddPaintsCode : Form
    {
        public frmAddPaintsCode()
        {
            InitializeComponent();
        }

        String table = "Colors";
        SysSettings s = new SysSettings();
        Rules r = new Rules();
        private void frmAddPaintsCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmAddPaintsCode_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_pid.Clear();
            txt_pname.Clear();
            int v = r.FindMax(table);
            txt_pid.Text = v.ToString(); ;
            txt_pname.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pid.Text) || r.isDigitsOnly(txt_pid.Text) == false || string.IsNullOrEmpty(txt_pname.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                int id = int.Parse(txt_pid.Text);
                string name = txt_pname.Text;


                int rest = s.AddColor(id, name , table);
                if (rest == -1)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
                else if (rest > 0)
                {
                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);

                    simpleButton2.PerformClick();



                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
            }
        }
    }
}
