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
    public partial class frmDefineServices : Form
    {
        public frmDefineServices()
        {
            InitializeComponent();
        }
        String table = "Services";
        Rules r = new Rules();
        SysSettings si = new SysSettings();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            txt_sid.Clear();
            txt_sdesc.Clear();
            txt_scost.Clear();
            int s = r.FindMax(table);
            txt_sid.Text = s.ToString();
            txt_scost.Focus();

        }

        private void frmDefineServices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_sid.Text) || r.isDigitsOnly(txt_sid.Text) == false || string.IsNullOrEmpty(txt_sdesc.Text) || string.IsNullOrEmpty(txt_scost.Text) || r.isDigitsOnly(txt_scost.Text) == false)
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                int id = int.Parse(txt_sid.Text);
                int cost = int.Parse(txt_scost.Text);
                string name = txt_sdesc.Text;



                int rest = si.AddService(id, name, cost);
                if (rest <= 0)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
                else if (rest > 0)
                {
                    MessageBox.Show(table+Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();
                   

                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
            }

        }
    }
}
