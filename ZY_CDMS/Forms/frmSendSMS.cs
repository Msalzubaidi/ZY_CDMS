using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            message.Clear();
            mobile.Clear();
            cust.ResetText();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, messagee;
                to = mobile.Text;
                messagee = message.Text;
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=zisan94268&password=OYeNLVUHTNIHbD&api_id=3528011&to='" + to + "'&text='" + messagee + "'";
                client.OpenRead(baseURL);
                MessageBox.Show("Message Sent Successfully", Resources.MessageTitle, 0, MessageBoxIcon.Information);
            }
            

            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            
   
        }
    }
}
