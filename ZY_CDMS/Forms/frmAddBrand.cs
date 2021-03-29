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
    public partial class frmAddBrand : Form
    {
        public frmAddBrand()
        {
            InitializeComponent();
        }

        String table = "Brands";
        Rules r = new Rules();
        Operations o = new Operations();
        SysSettings si = new SysSettings();
        

        private void frmAddBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

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
                string make = txt_make.Text;
                string model = txt_model.Text;

                int rest = si.AddBrand(id, make, model, table);
                if (rest == -1)
                {
                    MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Error);
                }
                else if (rest > 0)
                {
                    MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    o.UserLogTransactions(DataBase.Username.ToString(), " Add Brand ", DateTime.Now, Environment.MachineName);
                    simpleButton2.PerformClick();


                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_make.PromptChar = ' ';
            txt_model.PromptChar = ' ';

            txt_bid.Clear();
            txt_make.Clear();
            txt_model.Clear();
            txt_make.Focus();
            int y = r.FindMax(table);
            txt_bid.Text = y.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
