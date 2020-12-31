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
    public partial class frmAddPaintsCode : Form
    {
        public frmAddPaintsCode()
        {
            InitializeComponent();
        }

        String table = "Colors";
        SysSettings s = new SysSettings();
        Rules r = new Rules();
        Operations o = new Operations();

        private void frmAddPaintsCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmAddPaintsCode_Load(object sender, EventArgs e)
        {
            
            simpleButton2.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Colors ";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();
               
                cbo_id.Properties.Items.Add(item1);

            }


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_pid.Clear();
            txt_pname.Clear();
            int v = r.FindMax(table);
            txt_pid.Text = v.ToString(); ;
            txt_pname.Focus();
            simpleButton1.Enabled = true;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pid.Text) || r.isDigitsOnly(txt_pid.Text) == false || string.IsNullOrEmpty(txt_pname.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                int id = int.Parse(txt_pid.Text);
                string name = txt_pname.Text;


                int rest = s.AddColor(id, name , table);
                if (rest == -1)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
                else if (rest > 0)
                {
                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);

                    simpleButton2.PerformClick();



                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    simpleButton2.PerformClick();
                }
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
                string condition = "color_id=" + v.ToString();

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_pid.Text = dtable.Rows[0]["color_id"].ToString();//1
                    txt_pname.Text = dtable.Rows[0]["color_name"].ToString();//2

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
