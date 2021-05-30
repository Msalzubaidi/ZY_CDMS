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
    public partial class frmActivationApp : Form
    {
        public frmActivationApp()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        string table = "SystemInfo";
        string imglocation = "";

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmActivationApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            if (master.Text == "ZYTech2020" + DataBase.MasterPassword && string.IsNullOrEmpty (master.Text)==false)
            {
                db.ActivaApp();

                MessageBox.Show("Activated Done Successfully", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.KeyAdd(key.Text);
                this.Hide();
                frmLogin l = new frmLogin();
                l.Show();
            }
            else
            {
                MessageBox.Show("Try Again - Invalid Master Key or License", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivationApp_Load(object sender, EventArgs e)
        {
            string condition = "";

            DataTable dtable = o.SelctData(table, 0, condition);

            DataTable dtable2 = o.SelctData("ActivationApp", 0, condition);

            string comname = dtable.Rows[0]["name"].ToString();
            int  ActiveStatus = int.Parse(dtable2.Rows[0]["Activated"].ToString());
            txt_comname.Text = dtable.Rows[0]["name"].ToString();
            from.Text = dtable.Rows[0]["licencefrom"].ToString();
            to.Text = dtable.Rows[0]["licenceto"].ToString();

            string date = DateTime.Now.ToString("ddMMyyyy");
            string day = date[0] + "" + date[1];
            string month = date[2] + "" + date[3];
            string f = date[4] + "";
            string s = date[5] + "";
            string t = date[6] + "";
            string fth = date[7] + "";
            StringBuilder sb = new StringBuilder();

            sb.Append('Z');
            sb.Append(day);
            sb.Append('Y');
            sb.Append(month);
            sb.Append('C');
            sb.Append(f);
            sb.Append('D');
            sb.Append(s);
            sb.Append('M');
            sb.Append(t);
            sb.Append('S');
            sb.Append(fth);

            string newcomname = comname.Replace(" ", String.Empty);
          
            key.Text = sb.ToString() + newcomname.ToString();

            if(ActiveStatus == 0 )
            {
                toggleSwitch1.IsOn = false; 
            }
            if (ActiveStatus == 1)
            {
                toggleSwitch1.IsOn = true;
            }

            master.Visible = false;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            metroLabel1.Visible = false;


        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == DataBase.MasterPassword )
            {
                MessageBox.Show("ZYTech2020" + DataBase.MasterPassword , "Activation Key - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                master.Visible = true;
                simpleButton1.Visible = true;
                simpleButton2.Visible = true;
                metroLabel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Try Again After 1 Miniute ", "Activation Key - تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
