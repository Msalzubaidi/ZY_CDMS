using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select* from Users";

            con.Open();
            //MessageBox.Show("Connected ... ");

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                users.Properties.Items.Add(dr.GetValue(1).ToString());

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void users_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(users.Text))
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                Operations o = new Operations();
                string user = users.Text;
                string condition = "user_name=" + "'" + @user + "'";

                DataTable dtable = o.SelctData("Users", 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txtemail.Text = dtable.Rows[0]["email"].ToString();//2
                    txtpassword.Text = dtable.Rows[0]["password"].ToString();//2


                }

                else
                {
                    MessageBox.Show("Please Select Username  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailbeg.Text) || string.IsNullOrEmpty(users.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtpaswordsender.Text) || string.IsNullOrEmpty(txtsender.Text))
            {
                MessageBox.Show("Please Fill Required Text Boxes ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
            else
            {
                MailMessage myMsg = new MailMessage();
                string senderemail = emailbeg.Text.Trim() + txtsender.Text.Trim();
                myMsg.From = new MailAddress(senderemail);

                myMsg.To.Add(txtemail.Text);
                myMsg.Subject = "ZY TECH APP - CDMS 2021";
                myMsg.Body = "Hi " + users.Text + " Your password is  " + "( " + txtpassword.Text + " ) " + "Please Don't Share it with other.";


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential(txtsender.Text, txtpaswordsender.Text);
                    smtp.EnableSsl = true;
                    smtp.Send(myMsg);
                    MessageBox.Show("Please Check Your Inbox", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }


        }
    }
}
