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
        string servicetable = "Services";
        public static string nl = "\r\n";


        private void frmAddServicecs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbo_vin.EditValue = "";
            cbo_service.EditValue = "";
            txt_carinfo.Clear();
            txt_sercost.Clear();
            txt_serviceinfo.Clear();
            dtp_date.EditValue = DateTime.Now;
            cbo_vin.Focus();
            int et = r.FindMax(table);
            txt_transid.Text = et.ToString();


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
                cbo_vin.Properties.Items.Add(item1);

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
              
                cbo_service.Properties.Items.Add(item1);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_vin.SelectedItem.ToString()) || string.IsNullOrEmpty(cbo_service.SelectedItem.ToString()))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string carinfo = txt_carinfo.Text;
                DateTime date = DateTime.Parse(dtp_date.EditValue.ToString());
                string servdesc = txt_serviceinfo.Text;
                int servid = int.Parse(cbo_service.SelectedItem.ToString());
                double cost = double.Parse(txt_sercost.Text);
                string vin = cbo_vin.SelectedItem.ToString();
                int tr_id = int.Parse(txt_transid.Text);

                int u = o.newService(servid, cost, vin, servdesc, date , tr_id);

                if (u > 0)
                {
                    MessageBox.Show(servicetable + Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();

                }

                else if (u <= 0)
                {
                    MessageBox.Show("Operation Failed - Please Try Again With Valid Data ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_vin.SelectedItem.ToString()))
            {
                // MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
            }

            else
            {
                string vin = cbo_vin.Text;
          
                string condition = "vin=" + "'" + @vin + "'";
            


                DataTable dtable = o.SelctData(carstable, 1, condition);
              
                if (dtable != null && dtable.Rows.Count > 0)
                {
                    string bm = dtable.Rows[0]["makeModel"].ToString();

                    string year = dtable.Rows[0]["years"].ToString();


                    txt_carinfo.Text = bm + " " + year;
                }

                else
                {

   
                    }
                }


              
            }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_vin.SelectedItem.ToString()))
            {
                // MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
               
                int id = int.Parse(cbo_service.SelectedItem.ToString());
               
                string condition2 = "id=" + "'" + @id + "'";
             
                DataTable dtableser = o.SelctData(servicetable, 1, condition2);

                if (dtableser != null && dtableser.Rows.Count > 0)
                {
                    txt_serviceinfo.Text = dtableser.Rows[0]["name"].ToString();
                    txt_sercost.Text = dtableser.Rows[0]["cost"].ToString();
                }
                else
                {

                }


              
                }
            }
    }
    }

