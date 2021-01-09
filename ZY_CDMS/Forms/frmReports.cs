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
using ZY_CDMS.Reports;

namespace ZY_CDMS.Forms
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();

        public static int selectedReport = -1;
        public static int CusVersion = 0 ; 

      

        string server = DataBase.servercon;
        string dbname = DataBase.dbnamecon;
        string username = DataBase.usernamecon;
        string pass = DataBase.passwordcon;

        public static DateTime from;
        public static DateTime to;

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
            frmReportViewer rv = null;
           
            DataTable datatable = db.ViewSysinfo(1);
            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6

            if (string.IsNullOrEmpty(cbo_reports.EditValue.ToString()) || (cbo_reports.SelectedIndex < 0 || cbo_reports.SelectedIndex > 15))
            {
                MessageBox.Show("Please Select Vin  to view Data !!! ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbo_reports.SelectedIndex == 0 )
                {
                
                        selectedReport = 0;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;

                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 1)
                {
                    selectedReport = 1;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 2)
                {
                    selectedReport = 2;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 3)
                {
                    selectedReport = 3;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 4)
                {
                    selectedReport = 4;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 5)
                {
                    selectedReport = 5;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 6)
                {
                    selectedReport = 6;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 7)
                {
                    selectedReport = 7;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 8)
                {
                    selectedReport = 8;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 9)
                {
                    selectedReport = 9;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex ==10)
                {
                    selectedReport = 10;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 11)
                {
                    selectedReport = 11;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 12)
                {
                    selectedReport = 12;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 13)
                {
                    selectedReport = 13;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }

                else if (cbo_reports.SelectedIndex == 14)
                {
                    selectedReport = 14;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 15)
                {
                    selectedReport =15;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 0  && (version.ToString() == Resources.JordanCleaningVersion))
                {
                    selectedReport =0;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    CusVersion = version;

                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 1 && (version.ToString() == Resources.JordanCleaningVersion))
                {
                    selectedReport = 1;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    CusVersion = version;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 2 && (version.ToString() == Resources.JordanCleaningVersion))
                {
                    selectedReport = 2;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    CusVersion = version;
                    rv = new frmReportViewer();
                    rv.Show();

                }
                else if (cbo_reports.SelectedIndex == 3 && (version.ToString() == Resources.JordanCleaningVersion))
                {
                    selectedReport = 3;
                    from = dtp_from.DateTime;
                    to = dtp_to.DateTime;
                    CusVersion = version;
                    rv = new frmReportViewer();
                    rv.Show();

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
