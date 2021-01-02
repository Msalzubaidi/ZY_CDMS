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
    public partial class frmAppSettings : Form
    {
        public frmAppSettings()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        string table = "SystemInfo";
        Rules r = new Rules();
            


        private void frmAppSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAppSettings_Load(object sender, EventArgs e)
        {

            simpleButton5.PerformClick();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
     
            o.UpdateVersion(txt_comversion.Text);
            MessageBox.Show(" Version Updated ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_comno.Text);
            DateTime sta = from.Value;
            DateTime ends = to.Value;
            string st = sta.ToShortDateString();
            string en = ends.ToShortDateString();



           
            int rest = o.updatelicence(id, st, en);

            if (rest > 0)
            {
                MessageBox.Show("Updated Licence untill " + en.ToString(), Resources.MessageTitle, 0, MessageBoxIcon.Information);

                simpleButton5.PerformClick();
            }
            else
            {
                MessageBox.Show("Please Try Again ", Resources.MessageTitle, 0, MessageBoxIcon.Hand);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Change Data", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (r.isDigitsOnly(txt_comno.Text) == false || r.isDigitsOnly(txt_newcomno.Text) == false || string.IsNullOrWhiteSpace(txt_newcomno.Text) || string.IsNullOrWhiteSpace(txt_comname.Text) || string.IsNullOrEmpty(txt_activeyear.Text))
                {
                    MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {

                    string oid = txt_comno.Text;
                    string nid = txt_newcomno.Text;
                    string otitle = txt_comname.Text;
                    string year = txt_activeyear.Text;

                   
                    int x = o.changesysinfo(oid, nid, otitle, year);

                    if (x > 0)
                    {
                        MessageBox.Show(Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                        simpleButton5.PerformClick();

                    }
                    else if (x < 0)
                    {
                        MessageBox.Show(" No Changes Happened ", Resources.MessageTitle, 0, MessageBoxIcon.Error);
                        simpleButton5.PerformClick();
                    }

                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled by User", Resources.MessageTitle, 0, MessageBoxIcon.Error);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DataTable dtable = o.SelctData(table, 0, "");

            txt_comno.Text = dtable.Rows[0]["id"].ToString();
            txt_newcomno.Text = dtable.Rows[0]["id"].ToString();
            txt_comname.Text = dtable.Rows[0]["name"].ToString();
            txt_from.Text = dtable.Rows[0]["licencefrom"].ToString();
            txt_to.Text = dtable.Rows[0]["licenceto"].ToString();
            txt_activeyear.Text = dtable.Rows[0]["activeyear"].ToString();

            int version = int.Parse(dtable.Rows[0]["version"].ToString());
            txt_comversion.Text = version.ToString();

            txt_server.Text = DataBase.servercon.ToString();
            txt_db.Text = DataBase.dbnamecon.ToString();
            txt_dbuser.Text = DataBase.usernamecon.ToString();
            txt_dbpass.Text = DataBase.passwordcon.ToString();
        }
    }
}
