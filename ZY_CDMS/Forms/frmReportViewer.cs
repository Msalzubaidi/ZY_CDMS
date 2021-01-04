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
using ZY_CDMS.Reports;

namespace ZY_CDMS.Forms
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        string server = DataBase.servercon;
        string dbname = DataBase.dbnamecon;
        string username = DataBase.usernamecon;
        string pass = DataBase.passwordcon;
        DataBase db = new DataBase();
        Operations o = new Operations();

        public static DateTime dtf ;
        public static DateTime dtt;

      

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dtable = o.SelctData("SystemInfo", 0 ,"");

            string id = dtable.Rows[0]["id"].ToString();
            string comname  = dtable.Rows[0]["name"].ToString();
            string address = dtable.Rows[0]["address"].ToString();
            string email = dtable.Rows[0]["email"].ToString();
            string mobile = dtable.Rows[0]["mobile"].ToString();
         
            string taxNo = dtable.Rows[0]["tax_no"].ToString();

            if (frmReports.selectedReport == 0)
            {
                rptAllCars ac = new rptAllCars();
                DataTable dt = db.DataSourceReportBuilder(0 , "Cars" , " ");
                ac.SetDataSource(dt);
                ac.Refresh();
                ac.SetDatabaseLogon(username, pass, server, dbname, false);
                ac.SetParameterValue("FromDate", frmReports.from);
                ac.SetParameterValue("ToDate" ,frmReports.to);
                ac.SetParameterValue("ComName", comname.ToString());
                ac.SetParameterValue("Address", address.ToString());
                ac.SetParameterValue("Mobile", mobile.ToString());

                crystalReportViewer1.ReportSource = ac;
            }
            if (frmReports.selectedReport == 1)
            {
                rptAllCars ac = new rptAllCars();
                DataTable dt = db.DataSourceReportBuilder(0, "Cars", " ");
                ac.SetDataSource(dt);
                ac.Refresh();
                ac.SetDatabaseLogon(username, pass, server, dbname, false);
                ac.SetParameterValue("FromDate", frmReports.from);
                ac.SetParameterValue("ToDate", frmReports.to);
                ac.SetParameterValue("ComName", comname.ToString());
                ac.SetParameterValue("Address", address.ToString());
                ac.SetParameterValue("Mobile", mobile.ToString());

                crystalReportViewer1.ReportSource = ac;
            }
        }
    }
}
