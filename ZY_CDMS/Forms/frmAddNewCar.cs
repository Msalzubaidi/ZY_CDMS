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
    public partial class frmAddNewCar : Form
    {
        public frmAddNewCar()
        {
            InitializeComponent();
        }

        SysSettings s = new SysSettings();
        Rules r = new Rules();
        string table = "Cars";
        string TarnsTabletable = "TransActions";
        


        private void frmAddNewCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to Close Without Save ?  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vin.Text) || string.IsNullOrEmpty(cbo_makemodel.Text) || string.IsNullOrWhiteSpace(cbo_year.Text) || string.IsNullOrEmpty(cbo_source.Text) || nud_price.Value <= 0 || string.IsNullOrEmpty(cbo_paymethod.Text) || r.isDigitsOnly(nud_millages.Text) || string.IsNullOrEmpty(cbo_color.Text))
            {

                MessageBox.Show(Resources.invalidData + " Or Price 0 ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }

            else
            {
                /*
                int transno = int.Parse(txt_transid.Text);
                int transtype = int.Parse(txt_trantype.Text);
            
                int paytype = cbo_paymethod.SelectedIndex + 1;
                string Vin = txt_vin.Text;
                
                string Color = cbo_color.SelectedItem.ToString();
                string Years = years.SelectedItem.ToString();
                string mill = millages.Text;
                DateTime date = datein.Value;
                double Price = double.Parse(pprice.Text);
                int source = int.Parse(sc.Text);
                int carst = int.Parse(txt_carstatus.Text);
                string carstetxt = "New Car";
                string bntext = bname.Text;
                string bmtext = bmodel.Text;
                string scar = scname.Text;
                string pmtext = pmn.Text;
                */
            }


            }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_vin.Clear();
            int v = r.FindMax(table);
            txt_transid.Text = v.ToString();
            dtp_datein.EditValue = DateTime.Now;
            cbo_color.EditValue ="";
            cbo_makemodel.EditValue ="";
            cbo_paymethod.EditValue ="";
            cbo_source.EditValue ="";
            cbo_year.EditValue ="";
            nud_millages.Value = 0;
            nud_price.Value = 0;
            txt_vin.Focus();
        
           


        }

        private void frmAddNewCar_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
            txt_vin.Focus();
        }
    }
}
