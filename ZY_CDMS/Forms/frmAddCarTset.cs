using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public static string carvin = "";
        DataBase db = new DataBase();
       public static string CustVer = "";
        public static int selectedReport = 0; 

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




            SqlConnection conc = new SqlConnection(connstring);
            SqlCommand cmdc;
            SqlDataReader drc;

            string qryc = "select* from CarTest";

            conc.Open();


            cmdc = new SqlCommand(qryc, conc);
            drc = cmdc.ExecuteReader();

            while (drc.Read())
            {

                cbo_vin.Properties.Items.Add(drc.GetValue(5).ToString());

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
            cbo_cusid.EditValue = "";
            txt_custname.Clear();
            txt_custaddress.Clear();
            txt_custmobile.Clear();
            txt_vin.Clear();
            dtp_date.EditValue = DateTime.Now;
            txt_total.Clear();
            txt_repair.Clear();
            txt_clean.Clear();
            txt_bal.Clear();
            txt_pay.Clear();
            txt_tax.Clear();
            cbo_tax.Enabled = false;
            cbo_year.EditValue = "";
            cbo_color.EditValue = "";
            cbo_makemodel.EditValue = "";
            cbo_paints.EditValue = "";
            simpleButton1.Visible = true;
            simpleButton9.Visible = true;
            simpleButton4.Visible = false;



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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_color.Text) || string.IsNullOrEmpty(imglocationA.ToString()) || string.IsNullOrEmpty(imglocationB.ToString()) || string.IsNullOrEmpty(imglocationC.ToString()) || string.IsNullOrEmpty(imglocationD.ToString()) || string.IsNullOrWhiteSpace(cbo_makemodel.Text) || string.IsNullOrWhiteSpace(cbo_paints.Text) || string.IsNullOrWhiteSpace(cbo_year.Text) || r.isDigitsOnly(cbo_year.Text) == false || string.IsNullOrWhiteSpace(txt_bal.Text) || r.isDigitsOnly(txt_bal.Text) == false || string.IsNullOrWhiteSpace(txt_pay.Text) || r.isDigitsOnly(txt_pay.Text) == false || string.IsNullOrWhiteSpace(txt_vin.Text) || string.IsNullOrWhiteSpace(txt_dirty.Text) || string.IsNullOrWhiteSpace(txt_clean.Text) || string.IsNullOrWhiteSpace(txt_repair.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                byte[] logoA = null;
                FileStream streamA = new FileStream(imglocationA, FileMode.Open, FileAccess.Read);
                BinaryReader breA = new BinaryReader(streamA);
                logoA = breA.ReadBytes((int)streamA.Length);
                /////
                byte[] logoB = null;
                FileStream streamB = new FileStream(imglocationB, FileMode.Open, FileAccess.Read);
                BinaryReader breB = new BinaryReader(streamB);
                logoB = breB.ReadBytes((int)streamB.Length);
                ////
                byte[] logoC = null;
                FileStream streamC = new FileStream(imglocationC, FileMode.Open, FileAccess.Read);
                BinaryReader breC = new BinaryReader(streamC);
                logoC = breC.ReadBytes((int)streamC.Length);
                ///
                byte[] logoD = null;
                FileStream streamD = new FileStream(imglocationD, FileMode.Open, FileAccess.Read);
                BinaryReader breD = new BinaryReader(streamD);
                logoD = breD.ReadBytes((int)streamD.Length);

                int Trans_id = int.Parse(txt_transid.Text);
                int Trans_type = int.Parse(txt_trantype.Text);
                string Cust_id = cbo_cusid.EditValue.ToString();
                string Custname = txt_custname.Text;
                string Custmobile = txt_custmobile.Text;
                string Carvin = txt_vin.Text;
                DateTime TransDate = DateTime.Parse(dtp_date.EditValue.ToString());
                string MakeModel = cbo_makemodel.Text.ToString();
                string year = cbo_year.EditValue.ToString();
                string color = cbo_color.EditValue.ToString();
                string paintCode = cbo_paints.EditValue.ToString();
                int pay = int.Parse(txt_pay.Text);
                int balance = int.Parse(txt_bal.Text);
                string cardirty = txt_dirty.Text;
                string carclean = txt_clean.Text;
                string rdesc = txt_repair.Text;

                float tax = float.Parse(txt_tax.Text);
                float total = float.Parse(txt_total.Text);

                int InvoiceBegFrom = 0;


                int rest = o.AddCarTest((Trans_id + InvoiceBegFrom), Trans_type, Cust_id, Custname, Custmobile, Carvin, TransDate, MakeModel, year, color, paintCode, pay, balance, cardirty, carclean, rdesc, tax, total);

                if (rest > 0 )
                {
                    MessageBox.Show("Car Test For : " + MakeModel + " -  " + year + "  Added Successfully - Thank You  ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    o.newTransaction(Trans_id, Trans_type, Carvin, pay, 1, "Car Maintainance", TransDate);
                    o.UploaDCarTestImages(Carvin, logoA, logoB, logoC, logoD);
                    o.UserLogTransactions(DataBase.Username.ToString(), " Add Car Test ", DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();


                }

                else if (rest <= 0)
                {
                    MessageBox.Show("Error At Data Entry - Invalid info -  Exist Info - Try Again ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                }

            }
        }

        private void cbo_tax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_tax.EditValue.ToString()) == false || string.IsNullOrEmpty(txt_pay.Text) == false)
            {
                double taxPer = double.Parse(cbo_tax.EditValue.ToString());

                double taxval = double.Parse(txt_pay.Text.ToString()) * (taxPer / 100);

                txt_tax.Text = taxval.ToString();

                double total = taxval + double.Parse(txt_pay.Text.ToString());
                txt_total.Text = total.ToString();
            }

            else
            {


            }


        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            cbo_tax.Enabled = true;

        }

        private void cbo_vin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_vin.EditValue.ToString()))
            {


            }
            else
            {
                simpleButton1.Visible = false;
                simpleButton9.Visible = false;
                simpleButton4.Visible = true;
                cbo_tax.Enabled = false;
                carvin = cbo_vin.EditValue.ToString();
                string condition = "carvin=" + "'" + @carvin + "'";
                DataTable dt = o.SelctData(testTable, 1, condition);

                if (dt.Rows.Count > 0)
                {
                    txt_transid.Text = dt.Rows[0]["trans_id"].ToString();
                    cbo_cusid.Text = dt.Rows[0]["cust_id"].ToString();
                    txt_custname.Text = dt.Rows[0]["cust_name"].ToString();
                    txt_custmobile.Text = dt.Rows[0]["cust_mobile"].ToString();
                    dtp_date.EditValue = DateTime.Parse(dt.Rows[0]["trans_date"].ToString());

                    cbo_makemodel.EditValue = dt.Rows[0]["makeModel"].ToString();
                    cbo_color.EditValue = dt.Rows[0]["color"].ToString();
                    cbo_paints.EditValue = dt.Rows[0]["paintCode"].ToString();
                    cbo_year.EditValue = dt.Rows[0]["years"].ToString();
                    txt_vin.Text = dt.Rows[0]["carvin"].ToString();
                    txt_pay.Text = dt.Rows[0]["payment"].ToString();
                    txt_bal.Text = dt.Rows[0]["balance"].ToString();
                    txt_dirty.Text = dt.Rows[0]["carDirty"].ToString();
                    txt_clean.Text = dt.Rows[0]["carClean"].ToString();
                    txt_repair.Text = dt.Rows[0]["RepairDescription"].ToString();
                    txt_total.Text = dt.Rows[0]["totalpay"].ToString();
                    txt_tax.Text = dt.Rows[0]["tax"].ToString();

                    string vins = cbo_vin.EditValue.ToString();
                    DataSet dsA = o.viewLogo(vins, 'A');
                    MemoryStream msA = new MemoryStream((byte[])dsA.Tables[0].Rows[0]["ImageA"]);
                    imageA.Image = new Bitmap(msA);

                    DataSet dsB = o.viewLogo(vins, 'B');
                    MemoryStream msB = new MemoryStream((byte[])dsB.Tables[0].Rows[0]["ImageB"]);
                    imageB.Image = new Bitmap(msB);

                    DataSet dsC = o.viewLogo(vins, 'C');
                    MemoryStream msC = new MemoryStream((byte[])dsC.Tables[0].Rows[0]["ImageC"]);
                    imageC.Image = new Bitmap(msC);

                    DataSet dsD = o.viewLogo(vins, 'D');
                    MemoryStream msD = new MemoryStream((byte[])dsD.Tables[0].Rows[0]["ImageD"]);
                    imageD.Image = new Bitmap(msD);


                }
                else
                {
                    MessageBox.Show(testTable + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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
                   selectedReport = 4;
                    carvin = cbo_vin.SelectedItem.ToString();
                    CustVer = version.ToString();
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
    }
}

