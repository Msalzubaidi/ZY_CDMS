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
    public partial class frmAddPayMethod : Form
    {
        public frmAddPayMethod()
        {
            InitializeComponent();
        }

        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "PayMethods";
        Operations o = new Operations();
        private void frmAddPayMethod_KeyDown(object sender, KeyEventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            int x = r.FindMax(table);
            txt_pid.Text = x.ToString();
            txt_pname.Clear();
            txt_pname.Focus();
            simpleButton1.Enabled = true;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_pid.Text) || r.isDigitsOnly(txt_pid.Text) == false || string.IsNullOrWhiteSpace(txt_pname.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txt_pid.Text);
                string name = txt_pname.Text;



                int rest = s.AddPM(id, name, table);
                if (rest <= 0)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
                else if (rest > 0)
                {
                    MessageBox.Show(Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    o.UserLogTransactions(DataBase.Username.ToString(), " Add Pay Method ", DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();


                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void frmAddPayMethod_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con13 = new SqlConnection(connstring);
            SqlCommand cmd13;
            SqlDataReader dr13;

            string qry13 = "select * from PayMethods";
            con13.Open();



            cmd13 = new SqlCommand(qry13, con13);
            dr13 = cmd13.ExecuteReader();

            while (dr13.Read())
            {
                string item1 = dr13.GetValue(0).ToString();
                cbo_id.Properties.Items.Add(item1);

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
                string condition = "id=" + v.ToString();

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_pid.Text = dtable.Rows[0]["id"].ToString();//1
                    txt_pname.Text = dtable.Rows[0]["name"].ToString();//2

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
