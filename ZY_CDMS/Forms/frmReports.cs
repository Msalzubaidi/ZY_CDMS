﻿using System;
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
            frmReportViewer rv = new frmReportViewer();
            rv.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dtp_from.EditValue = DateTime.Now;
            dtp_to.EditValue = DateTime.Now;
            cbo_reports.ResetText();
            cbo_reports.Focus();

        }
    }
}
