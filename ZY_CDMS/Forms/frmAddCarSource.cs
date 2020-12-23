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
    public partial class frmAddCarSource : Form
    {
        public frmAddCarSource()
        {
            InitializeComponent();
        }

        String table = "SourceCar";
        Rules r = new Rules();
        SysSettings s = new SysSettings();
        Operations o = new Operations();

        private void frmAddCarSource_KeyDown(object sender, KeyEventArgs e)
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
            txt_sid.Text = x.ToString();
            txt_sname.Clear();
            txt_sname.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_id.Focus();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_sid.Text) || r.isDigitsOnly(txt_sid.Text) == false || string.IsNullOrEmpty(txt_sname.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txt_sid.Text);
                string name = txt_sname.Text;



                int rest = s.AddSOC(id, name, table);
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

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) || r.isDigitsOnly(txt_id.Text) == false)
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton4.PerformClick();
            }

            else
            {


               
                string condition = "id=" + int.Parse(txt_id.Text);

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_name.Text = dtable.Rows[0]["name"].ToString();//1
                   

                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton4.PerformClick();
                }

            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                simpleButton4.Enabled = true;
                simpleButton5.Enabled = true;
                simpleButton6.Enabled = true;

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
