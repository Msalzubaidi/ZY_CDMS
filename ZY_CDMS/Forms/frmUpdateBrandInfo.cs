using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmUpdateBrandInfo : Form
    {
        public frmUpdateBrandInfo()
        {
            InitializeComponent();
        }

        Rules r = new Rules();
        string table = "Brands";
        Operations o = new Operations();
        SysSettings s = new SysSettings();
        private void frmUpdateBrandInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bid.Text) || r.isDigitsOnly(txt_bid.Text) == false)
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }

            else

            {
                int v = int.Parse(txt_bid.Text);
                string condition = "bnum=" + v.ToString();

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {

                    txt_make.Text = dtable.Rows[0]["bname"].ToString();//1
                    txt_model.Text = dtable.Rows[0]["bmodel"].ToString();//2

                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_bid.Clear();
            txt_make.Clear();
            txt_model.Clear();
            txt_bid.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_bid.Text) || r.isDigitsOnly(txt_bid.Text) == false || string.IsNullOrEmpty(txt_make.Text) || string.IsNullOrEmpty(txt_model.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                int id = int.Parse(txt_bid.Text);
                string name = txt_make.Text;
                string model = txt_model.Text;



                int rest = s.UpdateBrand(id, name, model, table);
                if (rest > 0)
                {
                    MessageBox.Show(table + Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    txt_bid.Clear();
                    txt_make.Clear();
                    txt_model.Clear();
                }
                else if (rest == -1)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                    txt_bid.Clear();
                    txt_make.Clear();
                    txt_model.Clear();



                }
                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
            }
        }
    }
}
