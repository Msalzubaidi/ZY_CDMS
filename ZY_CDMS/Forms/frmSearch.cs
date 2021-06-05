using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        DataBase d = new DataBase();
         

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con13 = new SqlConnection(connstring);
            SqlCommand cmd13;
            SqlDataReader dr13;

            string qry13 = "select * from Cars";
            con13.Open();



            cmd13 = new SqlCommand(qry13, con13);
            dr13 = cmd13.ExecuteReader();

            while (dr13.Read())
            {
                string item1 = dr13.GetValue(3).ToString();
                cbo_vin.Properties.Items.Add(item1);

            }


            SqlConnection concv = new SqlConnection(connstring);
            SqlCommand cmdcv;
            SqlDataReader drcv;

            string qrycv = "select * from Cars";
            concv.Open();



            cmdcv = new SqlCommand(qrycv, concv);
            drcv = cmdcv.ExecuteReader();

            while (drcv.Read())
            {
                string item1 = drcv.GetValue(11).ToString();
                cbo_makemodel.Properties.Items.Add(item1);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_vin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_vin.Text))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {

                string vinnum = cbo_vin.Text;

               
                DataTable dt = d.search(vinnum , 0 , DateTime.Now , DateTime.Now );
                MyGrid.DataSource = dt;

            }
        }

        private void cbo_makemodel_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_makemodel.Text))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {

                string vinnum = cbo_makemodel.EditValue.ToString();


                DataTable dt = d.search(vinnum, 1 , DateTime.Now , DateTime.Now);
                MyGrid.DataSource = dt;

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_makemodel.Text))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder condition = new StringBuilder();
                condition.Append(" where ");
                int pricerangefrom = int.Parse(pricefrom.Text);
                int pricerangeto = int.Parse(priceto.Text);
                int MillRangeFrom = int.Parse(millfrom.Text);
                int MillRangeTo = int.Parse(millto.Text);

                if (selled.Checked && newcar.Checked)
                condition.Append(" ( carStatus=0  or  carStatus=1 )");
                if (selled.Checked  == false && newcar.Checked == false)
                    condition.Append(" ( carStatus=0  or  carStatus=1 )");
                else if (selled.Checked)
                        condition.Append("or ( carStatus=1)  ");
                else if (newcar.Checked)
                    condition.Append(" or (carStatus=0 )  ");
               /////////////////////////////////////////////////////////
                if (cash.Checked && cheq.Checked)
                    condition.Append(" and ( PayType=1 or  PayType=2)  ");
               else if (cash.Checked == false && cheq.Checked == false)
                    condition.Append(" and ( PayType=1 or  PayType=2)  ");
                else if (cash.Checked)
                        condition.Append(" and (PayType=1) ");
               else if (cheq.Checked)
                    condition.Append(" and (PayType=2 ) ");


                condition.Append(" and " + "(" + "Price  Between " + @pricerangefrom + " and " + @pricerangeto + ")" + " and " +"("+ " Millages Between " + @MillRangeFrom + " and " + @MillRangeTo+")");

                string con = condition.ToString();
               

                DataTable dt = d.search(con, 2, DateTime.Now , DateTime.Now);
                MyGrid.DataSource = dt;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = null;
            gridView1.Columns.Clear();
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {


            if (gridView1.Columns.Count <= 0 )
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {

                string path = "Report.xlsx";
                gridView1.ExportToXlsx(path);
                // Open the created XLSX file with the default application.
                MessageBox.Show("Search Result Exported To Excel Successfully ... ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                Process.Start(path);
            }
        }

        


    }
}
