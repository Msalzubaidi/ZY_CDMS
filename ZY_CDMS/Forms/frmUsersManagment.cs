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
            simpleButton1.Visible = true;
            simpleButton5.Visible = false;
            simpleButton4.Visible = true;
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
            simpleButton1.Visible = false;
            simpleButton5.Visible = true;
            simpleButton4.Visible = false;
            cbo_userid.ResetText();
            txt_userid.Clear();
            txt_username.Clear();
            txt_pass.Clear();
            cbo_userid.Focus();

            

        }
       
        private void chk_Settings_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Settings.Checked)
            {
                chk_dmm.Checked = true;
                chk_emm.Checked = true;
                chk_sv.Checked = true;
                chk_esv.Checked = true;
                chk_pm.Checked = true;
                chk_dsc.Checked = true;
                chk_pc.Checked = true;
                chk_tc.Checked = true;
            }

        }

        private void chk_Operations_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Operations.Checked)
            {
                chk_bc.Checked = true;
                chk_sc.Checked = true;
                chk_pi.Checked = true;
                chk_cust.Checked = true;
                chk_cm.Checked = true;
            }
        }

        private void chk_Search_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Search.Checked)
            {
               
                chk_srch.Checked = true;
            }
        }

        private void chk_Reports_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Reports.Checked)
            {
           
                chk_rpt.Checked = true;
            }
        }

        private void chk_systemMange_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_systemMange.Checked)
            {
              
                chk_sysinfo.Checked = true;
                chk_us.Checked = true;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // 25 Variables 
           if (chk_admin.Checked)
            {
                //Check All

            }
            else
            {
                if (chk_Settings.Checked)
                {

                }
            }
        } 
    }
}
