using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmAddServicecs : Form
    {
        public frmAddServicecs()
        {
            InitializeComponent();
        }
        string table = "TransServices";
        string carstable = "Cars";
        Operations o = new Operations();
        Rules r = new Rules();
    


        private void frmAddServicecs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbo_cardetails.EditValue = "";
            cbo_servicedetails.EditValue = "";
            dtp_date.EditValue = DateTime.Now;
            cbo_cardetails.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddServicecs_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Cars";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(3).ToString();
                string item2 = dr3.GetValue(11).ToString();
                string itemtoadd = item1 + " " + item2; 
                cbo_cardetails.Properties.Items.Add(itemtoadd);

            }


            SqlConnection con4 = new SqlConnection(connstring);
            SqlCommand cmd4;
            SqlDataReader dr4;

            string qry4 = "select * from Services";
            con4.Open();



            cmd4 = new SqlCommand(qry4, con4);
            dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                string item1 = dr4.GetValue(0).ToString();
                string item2 = dr4.GetValue(1).ToString();
                string item3 = dr4.GetValue(2).ToString();

                string itemtoadd = item1 + " " + item2 + " " + item3;
                cbo_servicedetails.Properties.Items.Add(itemtoadd);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_cardetails.SelectedItem.ToString()) || string.IsNullOrEmpty(cbo_servicedetails.SelectedItem.ToString()))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string carinfo = cbo_cardetails.SelectedItem.ToString();
                DateTime date = DateTime.Parse(dtp_date.EditValue.ToString());
                string servdesc = cbo_servicedetails.SelectedItem.ToString();
                int servid = 0;
                int cost = 0;
                string vin = "";            
                MessageBox.Show(vin.ToString());






            }
        }
    }
}
