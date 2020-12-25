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
    public partial class frmAddNewCar : Form
    {
        public frmAddNewCar()
        {
            InitializeComponent();
        }

        SysSettings s = new SysSettings();
        Rules r = new Rules();
        string table = "Cars";
        string TarnsTabletable = "TransActions";
        Operations o = new Operations();
        


        private void frmAddNewCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to Close Without Save ?  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vin.Text) || string.IsNullOrEmpty(cbo_makemodel.Text) || string.IsNullOrWhiteSpace(cbo_year.Text) || string.IsNullOrEmpty(cbo_source.Text) || nud_price.Value <= 0 || string.IsNullOrEmpty(cbo_paymethod.Text) || r.isDigitsOnly(nud_millages.Text) ==false  || string.IsNullOrEmpty(cbo_color.Text))
            {

                MessageBox.Show(Resources.invalidData + " Or Price 0 ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                int transno = int.Parse(txt_transid.Text);
                int transtype = int.Parse(txt_trantype.Text);
                int paytype = cbo_paymethod.SelectedIndex + 1;
                string Vin = txt_vin.Text;   
                string Color = cbo_color.SelectedItem.ToString();
                string Years = cbo_year.SelectedItem.ToString();
                string mill = nud_millages.Text;
                DateTime date = DateTime.Parse(dtp_datein.EditValue.ToString());
                double Price = double.Parse(nud_price.Text);
                int source = cbo_source.SelectedIndex + 1 ;
                int carst = int.Parse(txt_carstatus.Text);
                string carstetxt = "New Car";
                string makeModel = cbo_makemodel.Text;
                string scar = cbo_source.Text;
                string pmtext = cbo_paymethod.Text;

                int rest = o.AddCAR(transno , transtype ,paytype , Vin ,makeModel , Color, Years , mill , date , Price , carst , carstetxt , scar , pmtext );
                if (rest > 0)
                {
                    string desc = "";
                    if (transtype == 0 && paytype == 1)
                        desc = "Buy Cash";
                    if (transtype == 0 && paytype == 2)
                        desc = "Buy Cheq";

                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    o.newTransaction(transno, transtype, Vin, Price, paytype, desc, date);
                    simpleButton5.PerformClick();
                  
                }
                else if (rest == -1)
                {
                    MessageBox.Show(table +" Vin"+ Resources.Exist , Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }

            }


            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        
           


        }

        private void frmAddNewCar_Load(object sender, EventArgs e)
        {
            simpleButton5.PerformClick();
            txt_vin.Focus();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select* from Brands";

            con.Open();

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string item = dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString();

                cbo_makemodel.Properties.Items.Add(item);

            }

            SqlConnection con2 = new SqlConnection(connstring);
            SqlCommand cmd2;
            SqlDataReader dr2;

            string qry2 = "select* from SourceCar";
            con2.Open();



            cmd2 = new SqlCommand(qry2, con2);
            dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {

                cbo_source.Properties.Items.Add(dr2.GetValue(1).ToString());

            }


            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select* from PayMethods";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {

                cbo_paymethod.Properties.Items.Add(dr3.GetValue(1).ToString());

            }


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txt_vin.Clear();
            int v = r.FindMax(table);
            txt_transid.Text = v.ToString();
            dtp_datein.EditValue = DateTime.Now;
            cbo_color.EditValue = "";
            cbo_makemodel.EditValue = "";
            cbo_paymethod.EditValue = "";
            cbo_source.EditValue = "";
            cbo_year.EditValue = "";
            nud_millages.Value = 0;
            nud_price.Value = 0;
            txt_vin.Focus();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to Close Without Save Data ?  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                this.Close();


            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
