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
    public partial class frmAddCarTset : Form
    {
        public frmAddCarTset()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        Rules r = new Rules();
        string custable = "customersInfo";
        string testTable = "CarTest";
        string imglocationA = "";
        string imglocationB = "";
        string imglocationC = "";
        string imglocationD = "";

        private void frmAddCarTset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCarTset_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;


            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd;
            SqlDataReader dr;

            string qry = "select* from Colors";

            con.Open();
            //MessageBox.Show("Connected ... ");

            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cbo_paints.Properties.Items.Add(dr.GetValue(1).ToString());

            }


            SqlConnection conx = new SqlConnection(connstring);
            SqlCommand cmdx;
            SqlDataReader drx;

            string qryx = "select* from TaxCat";

            conx.Open();
            //MessageBox.Show("Connected ... ");

            cmdx = new SqlCommand(qryx, conx);
            drx = cmdx.ExecuteReader();

            while (drx.Read())
            {

                cbo_tax.Properties.Items.Add(drx.GetValue(1).ToString());

            }


            SqlConnection con1 = new SqlConnection(connstring);
            SqlCommand cmd1;
            SqlDataReader dr1;

            string qry1 = "select* from Brands";

            con1.Open();
            //MessageBox.Show("Connected ... ");

            cmd1 = new SqlCommand(qry1, con1);
            dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                string item = dr1.GetValue(1).ToString() + " " + dr1.GetValue(2).ToString();
                cbo_makemodel.Properties.Items.Add(item);

            }

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

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Customer")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddCustomer ac = new frmAddCustomer();
                ac.Show();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int f = r.FindMax(testTable);
            txt_transid.Text = f.ToString();

        }

        private void cbo_cusid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_cusid.Text))
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                string cust = cbo_cusid.Text;
                string condition = "custid=" + "'" + @cust + "'";

                DataTable dtable = o.SelctData(custable, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {


                    txt_custname.Text = dtable.Rows[0]["custname"].ToString();//2
                    txt_custaddress.Text = dtable.Rows[0]["note"].ToString();//2
                    txt_custmobile.Text = dtable.Rows[0]["mobilenum"].ToString();//2

                }

                else
                {
                    MessageBox.Show("Please Enter Customer ID  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void imageB_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void imageC_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void imageD_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void imageA_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            // "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocationA = opnfd.FileName.ToString();
                imageA.Image = new Bitmap(imglocationA);

            }
        }

        private void imageB_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocationB = opnfd.FileName.ToString();
                imageB.Image = new Bitmap(imglocationB);

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocationC = opnfd.FileName.ToString();
                imageC.Image = new Bitmap(imglocationC);

            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocationD = opnfd.FileName.ToString();
                imageD.Image = new Bitmap(imglocationD);

            }
        }
    }
}

