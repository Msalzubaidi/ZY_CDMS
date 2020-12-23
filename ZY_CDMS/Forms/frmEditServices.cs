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
    public partial class frmEditServices : Form
    {
        public frmEditServices()
        {
            InitializeComponent();
        }
        SysSettings s = new SysSettings();
        Rules r = new Rules();
        Operations o = new Operations();
        string table = "Services";
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_sid.Clear();
            txt_sdesc.Clear();
            txt_scost.Clear();
            txt_sid.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_sid.Text) || r.isDigitsOnly(txt_sid.Text) == false || string.IsNullOrWhiteSpace(txt_sdesc.Text) || string.IsNullOrWhiteSpace(txt_scost.Text) || r.isDigitsOnly(txt_scost.Text) == false)
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
              
                int id = int.Parse(txt_sid.Text);
                int cost = int.Parse(txt_scost.Text);
                string name = txt_sdesc.Text;



                int rest = s.UpdateService(id, name, cost);
                if (rest > 0)
                {
                    MessageBox.Show(table + Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();
                }
                else if (rest <= 0)
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();



                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }


            }
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_sid.Text) || r.isDigitsOnly(txt_sid.Text) == false)
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }
            else
            {
                string condition = "id=" + int.Parse(txt_sid.Text);

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_sdesc.Text = dtable.Rows[0]["name"].ToString();//1
                    txt_scost.Text = dtable.Rows[0]["cost"].ToString();//2

                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void frmEditServices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
