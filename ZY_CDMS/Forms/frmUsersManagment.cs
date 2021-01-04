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
    public partial class frmUsersManagment : Form
    {
        public frmUsersManagment()
        {
            InitializeComponent();
        }

        string table = "Users";
        Operations o = new Operations();
        Rules r = new Rules();

        private void frmUsersManagment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmUsersManagment_Load(object sender, EventArgs e)
        {

            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Users";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                cbo_userid.Properties.Items.Add(item1);

            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void SetChildrenChecked(TreeNode treeNode, bool checkedState)
        {
           
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
          

        

        }

        private void cbo_userid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_userid.Text) || r.isDigitsOnly(cbo_userid.Text) == false)
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton3.PerformClick();
            }

            else

            {
            
                int v = int.Parse(cbo_userid.EditValue.ToString());
                string condition = "user_id=" + v.ToString();

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_userid.Text = dtable.Rows[0]["user_id"].ToString();//1
                    txt_username.Text = dtable.Rows[0]["user_name"].ToString();//2
                    txt_pass.Text = dtable.Rows[0]["password"].ToString();

                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton3.PerformClick();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            cbo_userid.ResetText();
            txt_userid.Clear();
            txt_username.Clear();
            txt_pass.Clear();
            cbo_userid.Focus();

            

        }
    }
}
