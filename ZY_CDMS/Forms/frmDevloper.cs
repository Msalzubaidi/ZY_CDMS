using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmDevloper : Form
    {
        public frmDevloper()
        {
            InitializeComponent();
        }

        private void frmDevloper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("ddMMyyyy");
            if (string.IsNullOrWhiteSpace(masterkey.Text))
            {
                MessageBox.Show("Please Type Master Key ?  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (masterkey.Text == date)
            {
                frmAppSettings aset = new frmAppSettings();
                aset.Show();
                this.Close();
            }
            else if (masterkey.Text != date)
            {
                MessageBox.Show("Invalid Master Key", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
