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
    public partial class frmTaxCategoriescs : Form
    {
        public frmTaxCategoriescs()
        {
            InitializeComponent();
        }

        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string taxtable = "TaxCat"; 
             

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int y = r.FindMax(taxtable);
            txt_id.Text = y.ToString();
            txt_value.Clear();
            txt_value.Focus();
        }

        private void frmTaxCategoriescs_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(r.isDigitsOnly(txt_value.Text)== false || string.IsNullOrWhiteSpace(txt_value.Text))
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();
            }

            else
            {
                int id = int.Parse(txt_id.Text);
                int tax = int.Parse(txt_value.Text);

                int g = s.AddTaxCat(id , tax);

                if (g > 0 )
                {
                    MessageBox.Show(taxtable +Resources.AddedSuccessfully, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
