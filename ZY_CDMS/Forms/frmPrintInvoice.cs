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
    public partial class frmPrintInvoice : Form
    {
        public frmPrintInvoice()
        {
            InitializeComponent();
        }

        public static string carvin;

        string table = "SellTransactions";

        Operations o = new Operations();
        DataBase db = new DataBase();

        public static string CustVerp = "";
        public static int selectedReportp = 0;
        public static string VinToPrint = "";



        private void frmPrintInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbo_vin.ResetText();
            txt_invoiceno.Clear();
            txt_carinfo.Clear();
            txt_sellprice.Clear();
            txt_tax.Clear();
            txt_total.Clear();
            txt_customer.Clear();
            txt_services.Clear();
            dtp_selldate.EditValue = DateTime.Now;
            cbo_vin.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_vin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_vin.Text))
            {
               
            }

            else
            {
                carvin = cbo_vin.SelectedItem.ToString();
                string condition = "VIN=" + "'" + @carvin + "'";
               
                DataTable dtable = o.SelctData(table, 1, condition);


                int x = dtable.Rows.Count;
                
                if (dtable != null && dtable.Rows.Count > 0)
                {
                    if (x <= 0 )
                    {
                        MessageBox.Show("Car Not Selled - Please Make Sure You Made Sell Transaction  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        simpleButton2.PerformClick();
                       
                    }
                    else
                    {
                        txt_carinfo.Text = dtable.Rows[0]["carinfo"].ToString();
                        txt_invoiceno.Text = dtable.Rows[0]["transNo"].ToString();
                        txt_sellprice.Text = dtable.Rows[0]["purchPrice"].ToString();
                        txt_services.Text = dtable.Rows[0]["services"].ToString();
                        txt_tax.Text = dtable.Rows[0]["tax"].ToString();
                        dtp_selldate.EditValue = dtable.Rows[0]["date"].ToString();
                        txt_total.Text = dtable.Rows[0]["totalPrice"].ToString();
                        txt_customer.Text = dtable.Rows[0]["custname"].ToString();
                        
                       

                    }
                }

                else
                {
                    MessageBox.Show("Car Not Exist ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void frmPrintInvoice_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con13 = new SqlConnection(connstring);
            SqlCommand cmd13;
            SqlDataReader dr13;

            string qry13 = "select * from Cars where carStatus=1";
            con13.Open();



            cmd13 = new SqlCommand(qry13, con13);
            dr13 = cmd13.ExecuteReader();

            while (dr13.Read())
            {
                string item1 = dr13.GetValue(3).ToString();
                cbo_vin.Properties.Items.Add(item1);

            }


          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_carinfo.Text) == false)
            {

                frmReportViewer rv = null;

                DataTable datatable = db.ViewSysinfo(1);
                int version = int.Parse(datatable.Rows[0]["version"].ToString());//6

                if (string.IsNullOrEmpty(cbo_vin.EditValue.ToString()))
                {
                    if (frmLogin.languagearabic == 1)
                        MessageBox.Show("الرجاء اختيار السيارة للطباعة", "زد واي لتكنولوجيا المعلومات ", 0, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Please Select Vin  to Print !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbo_vin.SelectedItem.ToString() != " ")
                    {
                        selectedReportp = 16 ;
                        carvin = cbo_vin.SelectedItem.ToString();
                        CustVerp = version.ToString();
                        rv = new frmReportViewer();
                        rv.Show();
                    }
                    else
                    {

                        if (frmLogin.languagearabic == 1)
                            MessageBox.Show("الرجاء اختيار السيارة للطباعة", "زد واي لتكنولوجيا المعلومات ", 0, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Please Select Vin  to Print !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                    }
                }

            }
            if (string.IsNullOrEmpty(txt_carinfo.Text))
            {
                MessageBox.Show("Please Fill Valid Data !!   ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
