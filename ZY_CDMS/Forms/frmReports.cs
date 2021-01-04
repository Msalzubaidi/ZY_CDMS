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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();

        public static int y = -1;

        public static DateTime dtf;
        public static DateTime dtt;


        private void frmReports_Load(object sender, EventArgs e)
        {
            simpleButton3.PerformClick();
            DataTable datatable = db.ViewSysinfo(1);
            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            string qry13 = "";

            SqlConnection con13 = new SqlConnection(connstring);
            SqlCommand cmd13;
            SqlDataReader dr13;
          
            if (version.ToString() == Resources.AZversion)
            {
                 qry13 = "select * from Reports where reportversion=" + @version ;
            }
            if (version.ToString() == Resources.JordanCleaningVersion)
            {
                    qry13 = "select * from Reports where reportversion=" + @version;
            }
                con13.Open();



            cmd13 = new SqlCommand(qry13, con13);
            dr13 = cmd13.ExecuteReader();

            while (dr13.Read())
            {
                string item1 = dr13.GetValue(1).ToString();
                cbo_reports.Properties.Items.Add(item1);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            DataTable datatable = db.ViewSysinfo(1);
            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6
            if (string.IsNullOrEmpty(cbo_reports.EditValue.ToString()) || (cbo_reports.SelectedIndex < 0 || cbo_reports.SelectedIndex > 15))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbo_reports.SelectedIndex == 0)
                {
                    y = 0;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 1)
                {
                    y = 1;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 2)
                {
                    y = 2;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();
                }

                else if (cbo_reports.SelectedIndex == 3)
                {
                    y = 3;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 4)
                {
                    y = 4;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                // 

                else if (cbo_reports.SelectedIndex == 5)
                {
                    y = 5;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 6)
                {
                    y = 6;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 7)
                {
                    y = 7;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 8)
                {
                    y = 8;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 9)
                {
                    y = 9;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 10)
                {
                    y = 10;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();
                }

                else if (cbo_reports.SelectedIndex == 11)
                {
                    y = 11;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 12)
                {
                    y = 12;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 13)
                {
                    y = 13;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 14)
                {
                    y = 14;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 15)
                {
                    y = 15;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (comboBox2.SelectedIndex == 0)
                {
                    y = 18;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (comboBox2.SelectedIndex == 1)
                {
                    y = 19;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (comboBox2.SelectedIndex == 2)
                {
                    y = 20;
                    frmReportViewer rv = new frmReportViewer();
                    rv.Show();

                }

                else if (y == -1)
                {
                    MessageBox.Show(" => You Must Select Report to view <= !!!   ", SystemInfo.MessageTitle, 0, MessageBoxIcon.Error);
                }


            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dtp_from.EditValue = DateTime.Now;
            dtp_to.EditValue = DateTime.Now;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            cbo_reports.ResetText();
            cbo_reports.Focus();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            DataTable datatable = db.ViewSysinfo(1);
            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6
            if (string.IsNullOrEmpty(cbo_reports.EditValue.ToString()) || (cbo_reports.SelectedIndex < 0  ||  cbo_reports.SelectedIndex > 15 ))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
               
                    dt = db.ReportSerach( cbo_reports.SelectedIndex , version.ToString() ,DateTime.Parse(dtp_from.EditValue.ToString()) , DateTime.Parse(dtp_to.EditValue.ToString()));
                
                
                dataGridView1.DataSource = dt;

            }
        }
    }
}
