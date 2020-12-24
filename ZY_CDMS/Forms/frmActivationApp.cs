using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZY_CDMS.Forms
{
    public partial class frmActivationApp : Form
    {
        public frmActivationApp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivationApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             
            Z(day)Y(month)C(first digit of year)D(second digit of year)M(third digit of year)S(fourth digit of year)
            Z(25)Y(12)C(2)D(0)M(2)S(0)
            Z25Y12C2D0M2S0 

             
             * */

            string date = DateTime.Now.ToString("ddMMyyyy");
            string day = date[0] +  ""+ date [1];
            string month = date[2]+ "" + date[3];
            string f = date[4] + "";
            string s = date[5] + "";
            string t = date[6] + "";
            string fth = date[7] + "";
            StringBuilder sb = new StringBuilder();
          
            sb.Append('Z');
            sb.Append(day);
            sb.Append('Y');
            sb.Append(month);
            sb.Append('C');
            sb.Append(f);
            sb.Append('D');
            sb.Append(s);
            sb.Append('M');
            sb.Append(t);
            sb.Append('S');
            sb.Append(fth);

            MessageBox.Show(sb.ToString());
            key.Text = sb.ToString();


              
        }
    }
}
