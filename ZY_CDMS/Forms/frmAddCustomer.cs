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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }


        Operations o = new Operations();
        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "customersInfo";

        private void cbo_cusid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_cusid.Text))
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                simpleButton4.Visible = false;
                simpleButton1.Visible = true;
                string cust = cbo_cusid.Text;
                string condition = "custid=" + "'" + @cust + "'";

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_cusid.Text = dtable.Rows[0]["custid"].ToString();//2
                    txt_cusname.Text = dtable.Rows[0]["custname"].ToString();//2
                    txt_address.Text = dtable.Rows[0]["note"].ToString();//2
                    txt_cusmobile.Text = dtable.Rows[0]["mobilenum"].ToString();//2
                    txt_licno.Text = dtable.Rows[0]["liceNo"].ToString();//2
                }

                else
                {
                    MessageBox.Show("Please Enter Customer ID  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            simpleButton1.Visible = false;
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbo_cusid.ResetText();
            txt_cusid.Clear();
            txt_address.Clear();
            txt_cusmobile.Clear();
            txt_cusname.Clear();
            txt_licno.Clear();
            txt_cusid.Focus();
            simpleButton4.Visible = true;
            simpleButton1.Visible = false;


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cusid.Text) || string.IsNullOrEmpty(txt_cusname.Text) || string.IsNullOrEmpty(txt_licno.Text) || string.IsNullOrEmpty(txt_cusmobile.Text) || string.IsNullOrEmpty(txt_address.Text))
            {
                MessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cid, cname, lic, mobile, note;

                cid = txt_cusid.Text.Trim();
                cname = txt_cusname.Text.Trim();
                mobile = txt_cusmobile.Text.Trim();
                note = txt_address.Text.Trim();
                lic = txt_licno.Text.Trim();


                int rest = o.AddCustomer(cid, cname, lic, mobile, note);

                if (rest > 0)
                {
                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();
                }
                else if (rest == -1)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cusid.Text) || string.IsNullOrEmpty(txt_cusname.Text) || string.IsNullOrEmpty(txt_licno.Text) || string.IsNullOrEmpty(txt_cusmobile.Text) || string.IsNullOrEmpty(txt_address.Text))
            {
                MessageBox.Show(Resources.missingTextboxes, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cid, cname, lic, mobile, note;

                cid = txt_cusid.Text.Trim();
                cname = txt_cusname.Text.Trim();
                mobile = txt_cusmobile.Text.Trim();
                note = txt_address.Text.Trim();
                lic = txt_licno.Text.Trim();



                int rest = o.UpdateCustomer(cid, cname, lic, mobile, note);

                if (rest > 0)
                {
                    MessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    o.UpdateCustomerinfatora(cid, cname, lic, mobile, note);
                    simpleButton2.PerformClick();
                }
                else if (rest <= 0)
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmAddCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
