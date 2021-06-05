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

namespace ZY_CDMS.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            label3.Text = "Buy Transactions Report";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            simpleButton6.PerformClick();
           
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable datatable = db.ViewSysinfo(1);


            string titleform = datatable.Rows[0]["name"].ToString();
            string ay = datatable.Rows[0]["activeyear"].ToString();
            label1.Text = titleform.ToString();
            label5.Text = ay.ToString();
            label2.Text = DateTime.Now.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            label3.Text = "Sales Transactions Report";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            label3.Text = "Car Tests Report";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            label3.Text = "Services Transactions Report";
        }
    }
}
