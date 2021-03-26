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
    public partial class frmWhatsNew : Form
    {
        public frmWhatsNew()
        {
            InitializeComponent();
        }


        public static int show = 0;
        private void frmWhatsNew_Load(object sender, EventArgs e)
        {
            metroLabel7.Text = "In this Version : " + Resources.AppVersion;
        }

        private void showagain_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
