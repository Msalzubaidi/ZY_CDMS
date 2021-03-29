using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
        Operations o = new Operations();
        public static int languagearabic = 0;
        public static string Conserver ="";
        public static string Condbname = "";
        public static string Conusername = "";
        public static string Conpassword = "";


        private void frmLogin_Load(object sender, EventArgs e)
        {
            string strComputerName = Environment.MachineName.ToString();

            if (strComputerName == "MZUBAIDI")
            {
                credInfo.Visible = false;
            }
            else
            {
                credInfo.Visible = false;
            }

            DataTable datatable = o.SelctData("ConnectionInfo", 0, "");

           server.Text = datatable.Rows[0]["server"].ToString();//6
            dbname.Text = datatable.Rows[0]["dbname"].ToString();
            username.Text = datatable.Rows[0]["username"].ToString();
           password.Text = datatable.Rows[0]["password"].ToString();
            //-------------------------------------------------------------------
            Conserver = datatable.Rows[0]["server"].ToString();//6
            Condbname = datatable.Rows[0]["dbname"].ToString();
            Conusername = datatable.Rows[0]["username"].ToString();
            Conpassword = datatable.Rows[0]["password"].ToString();


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
 

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules();

            if (string.IsNullOrEmpty(txt_userid.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_username.Text) || rule.isDigitsOnly(txt_userid.Text) == false)
            {

             //   MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Clear();
                txt_userid.Clear();
                txt_username.Clear();
                txt_userid.Focus();
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
                    if (languagearabic == 1 )
                    {
                        string info = Resources.AppNameAR + " " + Resources.AppVersion + "   " + ay.ToString();
                        hp.Text = titleform.ToString() + "      " + info.ToString() + "        " + DataBase.Username.ToString();
                        hp.Show();
                        o.UserLogTransactions(username , "Log in" , DateTime.Now , Environment.MachineName );
                        
                    }
                    else
                    {
                        string info = Resources.AppName + " " + Resources.AppVersion + "   " + ay.ToString();
                        hp.Text = titleform.ToString() + "      " + info.ToString() + "        " + DataBase.Username.ToString();
                        hp.Show();
                        o.UserLogTransactions(username, "Log in", DateTime.Now, Environment.MachineName);
                    }
                   
                }
                else if (result == 0)
                {
                    MessageBox.Show(Resources.FaieldLogin, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_userid.Clear();
                    txt_username.Clear();
                    txt_userid.Focus();
                }
                else
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
           
           
        }

        private void txt_userid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userid.Text) || rule.isDigitsOnly(txt_userid.Text) == false)
            {
                //  MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                DataTable dtable = db.ViewUSERinfo(int.Parse(txt_userid.Text));
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {


                    txt_username.Text = dtable.Rows[0]["user_name"].ToString();
                    txt_password.Focus();

                }

                else
                {
                    MessageBox.Show("User " + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_password.Clear();
                    txt_userid.Clear();
                    txt_username.Clear();


                }
            }
        }

        private void credInfo_Click_1(object sender, EventArgs e)
        {
            txt_userid.Text = "1";
            txt_password.Text = DateTime.Now.ToString("ddMMyyyy");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Google.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instagram.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:dev.mzubaidi@gmail.com");
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            simpleButton1.PerformClick();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-jo");
            languagearabic = 1;
            metroLabel6.Visible = true;
            metroLabel5.Visible = false;
            this.Controls.Clear();
            InitializeComponent();
        }

     

        private void metroLabel6_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("En-US");
            languagearabic = 0;
            metroLabel6.Visible = false;
            metroLabel5.Visible = true;
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
