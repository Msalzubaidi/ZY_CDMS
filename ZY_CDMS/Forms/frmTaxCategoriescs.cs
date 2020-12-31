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
    public partial class frmTaxCategoriescs : Form
    {
        public frmTaxCategoriescs()
        {
            InitializeComponent();
        }

        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "TaxCat";
        Operations o = new Operations();




        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int y = r.FindMax(table);
            txt_id.Text = y.ToString();
            txt_value.Clear();
            txt_value.Focus();
            simpleButton1.Enabled = true;
        }

        private void frmTaxCategoriescs_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from TaxCat ";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                cbo_id.Properties.Items.Add(item1);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (r.isDigitsOnly(txt_value.Text) == false || string.IsNullOrWhiteSpace(txt_value.Text))
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }

            else
            {
                int id = int.Parse(txt_id.Text);
                double tax = double.Parse(txt_value.Text);

                int g = s.AddTaxCat(id, tax);

                if (g > 0)
                {
                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButton2.PerformClick();
                }

                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void frmTaxCategoriescs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbo_id_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbo_id.Text) || r.isDigitsOnly(cbo_id.Text) == false)
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }

            else

            {
                simpleButton1.Enabled = false;
                int v = int.Parse(cbo_id.Text);
                string condition = "tax_id=" + v.ToString();

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_id.Text = dtable.Rows[0]["tax_id"].ToString();//1
                    txt_value.Text = dtable.Rows[0]["tax_per"].ToString();//2

                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }
            }
        }
    }
}
