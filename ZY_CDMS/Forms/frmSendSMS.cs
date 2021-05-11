using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "customersInfo";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            message.Clear();
            txt_cusmobile.Clear();
            cbo_cusid.ResetText();
            cbo_cusid.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, messagee;
                to = txt_cusmobile.Text;
                messagee = message.Text;
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=zisan94268&password=OYeNLVUHTNIHbD&api_id=3528011&to='" + to + "'&text='" + messagee + "'";
                client.OpenRead(baseURL);
                MessageBox.Show("Message Sent Successfully", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                simpleButton3.PerformClick();
            }
            

            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            
   
        }

        private void cust_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_cusid.Text))
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
              
                string cust = cbo_cusid.Text;
                string condition = "custid=" + "'" + @cust + "'";

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_custid.Text = dtable.Rows[0]["custid"].ToString();//2
                    txt_custname.Text = dtable.Rows[0]["custname"].ToString();//2
              
                    txt_cusmobile.Text = dtable.Rows[0]["mobilenum"].ToString();//2
                 
                }

                else
                {
                    MessageBox.Show("Please Enter Customer ID  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void frmSendSMS_Load(object sender, EventArgs e)
        {
            simpleButton3.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;

            SqlConnection con0 = new SqlConnection(connstring);
            SqlCommand cmd0;
            SqlDataReader dr0;

            string qry0 = "select * from customersInfo ";
            con0.Open();



            cmd0 = new SqlCommand(qry0, con0);
            dr0 = cmd0.ExecuteReader();

            while (dr0.Read())
            {
                string item1 = dr0.GetValue(0).ToString();
                cbo_cusid.Properties.Items.Add(item1);

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            message.TextAlign = HorizontalAlignment.Left; 
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            message.TextAlign = HorizontalAlignment.Right;
        }
    }
}
