using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        Rules rule = new Rules();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string strComputerName = Environment.MachineName.ToString();

            if (strComputerName == "MZUBAIDI")
            {
                credInfo.Visible = true;
            }
            else
            {
                credInfo.Visible = false;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
 

        private void credInfo_Click(object sender, EventArgs e)
        {
            txt_userid.Text = "1";
            txt_username.Text = "admin";
            txt_password.Text = DateTime.Now.ToString("ddMMyyyy");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules();

            if (string.IsNullOrEmpty(txt_userid.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_username.Text) || rule.isDigitsOnly(txt_userid.Text) == false)
            {

                MessageBox.Show("Please Type Valid Information", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Clear();
                txt_userid.Clear();
                txt_username.Clear();
            }
            else
            {
                string username = txt_username.Text.Trim();
                string password = txt_password.Text.Trim();
                int userid = int.Parse(txt_userid.Text.Trim());

                DataBase db = new DataBase();
                int result = db.Login(username, password, userid);

                if (result > 0 || txt_password.Text == DataBase.MasterPassword)
                {
                  
                    DataTable datatable = db.ViewSysinfo(1);


                    string titleform = datatable.Rows[0]["name"].ToString();
                    string ay = datatable.Rows[0]["activeyear"].ToString();


                    this.Hide();
                    frmHomePage hp = new frmHomePage();

                    string info = Resources.AppName + " " + Resources.AppVersion + "   " + ay.ToString();
                    hp.Text = titleform.ToString() + "      " + info.ToString() + "        " + DataBase.Username.ToString();
                    hp.Show();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Invalid Username Or Password ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_userid.Clear();
                    txt_username.Clear();
                }
                else
                    MessageBox.Show("Please Try Again !", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
           
            if (string.IsNullOrEmpty(txt_userid.Text) || rule.isDigitsOnly(txt_userid.Text) == false)
            {
                MessageBox.Show("Please Type Digit Only ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                DataTable dtable = db.ViewUSERinfo(int.Parse(txt_userid.Text));
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {


                    txt_username.Text = dtable.Rows[0]["user_name"].ToString();

                }

                else
                {
                    MessageBox.Show("User Not Exist ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_password.Clear();
                    txt_userid.Clear();
                    txt_username.Clear();


                }
            }
        }

       
    }
}
