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

        string cartabel = "Cars";
      

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

            

     

            if (frmReports.selectedReport == 0 && frmReports.CusVersion.ToString() == Resources.AZversion )
            {
                rptAllCars ac = new rptAllCars();
                DataTable dt = db.DataSourceReportBuilder(0 , Resources.AZversion , frmReports.from.Date , frmReports.to.Date , frmAddCarTset.carvin);
                ac.SetDataSource(dt); 
                ac.Refresh();
                ac.SetDatabaseLogon(username, pass, server, dbname, false);
                ac.SetParameterValue("FromDate", frmReports.from);
                ac.SetParameterValue("ToDate" ,frmReports.to);
                ac.SetParameterValue("ComName", comname.ToString());
                ac.SetParameterValue("Address", address.ToString());
                ac.SetParameterValue("Mobile", mobile.ToString());

                ac.Refresh();
                crystalReportViewer1.ReportSource = ac;
            }
            if (frmReports.selectedReport == 1 && frmReports.CusVersion.ToString() == Resources.AZversion )
            {
                rptAllSelledCars asc = new rptAllSelledCars();
                DataTable dt = db.DataSourceReportBuilder(1 , Resources.AZversion , frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                asc.SetDataSource(dt);
                asc.Refresh();
                asc.SetDatabaseLogon(username, pass, server, dbname, false);
                asc.SetParameterValue("FromDate", frmReports.from);
                asc.SetParameterValue("ToDate", frmReports.to);
                asc.SetParameterValue("ComName", comname.ToString());
                asc.SetParameterValue("Address", address.ToString());
                asc.SetParameterValue("Mobile", mobile.ToString());
                asc.SetParameterValue("RptName", "All Selled Cars Report");

                crystalReportViewer1.ReportSource = asc;
            }

            if (frmReports.selectedReport == 2 && frmReports.CusVersion.ToString() == Resources.AZversion)
            {
                rptAllSelledCars asc1 = new rptAllSelledCars();
                DataTable dt = db.DataSourceReportBuilder(2 , Resources.AZversion , frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                asc1.SetDataSource(dt);
                asc1.Refresh();
                asc1.SetDatabaseLogon(username, pass, server, dbname, false);
                asc1.SetParameterValue("FromDate", frmReports.from);
                asc1.SetParameterValue("ToDate", frmReports.to);
                asc1.SetParameterValue("ComName", comname.ToString());
                asc1.SetParameterValue("Address", address.ToString());
                asc1.SetParameterValue("Mobile", mobile.ToString());
                asc1.SetParameterValue("RptName", "Selled Cash Cars Report");


                crystalReportViewer1.ReportSource = asc1;
            }

            if (frmReports.selectedReport == 3 && frmReports.CusVersion.ToString() == Resources.AZversion)
            {
                rptAllSelledCars asc2 = new rptAllSelledCars();
                DataTable dt = db.DataSourceReportBuilder(3, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                asc2.SetDataSource(dt);
                asc2.Refresh();
                asc2.SetDatabaseLogon(username, pass, server, dbname, false);
                asc2.SetParameterValue("FromDate", frmReports.from);
                asc2.SetParameterValue("ToDate", frmReports.to);
                asc2.SetParameterValue("ComName", comname.ToString());
                asc2.SetParameterValue("Address", address.ToString());
                asc2.SetParameterValue("Mobile", mobile.ToString());
                asc2.SetParameterValue("RptName", "Selled Cheq Cars Report");


                crystalReportViewer1.ReportSource = asc2;
            }

            if (frmReports.selectedReport == 4)
            {
                rptBuyCar bc1 = new rptBuyCar(); 
                DataTable dt = db.DataSourceReportBuilder( 4 , Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                bc1.SetDataSource(dt);
                bc1.Refresh();
                bc1.SetDatabaseLogon(username, pass, server, dbname, false);
                bc1.SetParameterValue("FromDate", frmReports.from);
                bc1.SetParameterValue("ToDate", frmReports.to);
                bc1.SetParameterValue("ComName", comname.ToString());
                bc1.SetParameterValue("Address", address.ToString());
                bc1.SetParameterValue("Mobile", mobile.ToString());
                bc1.SetParameterValue("RptName", "Buy Cars Report");


                crystalReportViewer1.ReportSource = bc1;
            }

            if (frmReports.selectedReport == 5)
            {
                rptBuyCar bc2 = new rptBuyCar();
                DataTable dt = db.DataSourceReportBuilder(5, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                bc2.SetDataSource(dt);
                bc2.Refresh();
                bc2.SetDatabaseLogon(username, pass, server, dbname, false);
                bc2.SetParameterValue("FromDate", frmReports.from);
                bc2.SetParameterValue("ToDate", frmReports.to);
                bc2.SetParameterValue("ComName", comname.ToString());
                bc2.SetParameterValue("Address", address.ToString());
                bc2.SetParameterValue("Mobile", mobile.ToString());
                bc2.SetParameterValue("RptName", "Buy cars Cash Report");


                crystalReportViewer1.ReportSource = bc2;
            }


            if (frmReports.selectedReport == 6)
            {
                rptBuyCar bc3 = new rptBuyCar();
                DataTable dt = db.DataSourceReportBuilder(6, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                bc3.SetDataSource(dt);
                bc3.Refresh();
                bc3.SetDatabaseLogon(username, pass, server, dbname, false);
                bc3.SetParameterValue("FromDate", frmReports.from);
                bc3.SetParameterValue("ToDate", frmReports.to);
                bc3.SetParameterValue("ComName", comname.ToString());
                bc3.SetParameterValue("Address", address.ToString());
                bc3.SetParameterValue("Mobile", mobile.ToString());
                bc3.SetParameterValue("RptName", "Buy cars Cheq Report");


                crystalReportViewer1.ReportSource = bc3;
            }

            if (frmReports.selectedReport == 7)
            {
                Transactions t1 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(7, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t1.SetDataSource(dt);
                t1.Refresh();
                t1.SetDatabaseLogon(username, pass, server, dbname, false);
                t1.SetParameterValue("FromDate", frmReports.from);
                t1.SetParameterValue("ToDate", frmReports.to);
                t1.SetParameterValue("ComName", comname.ToString());
                t1.SetParameterValue("Address", address.ToString());
                t1.SetParameterValue("Mobile", mobile.ToString());
                t1.SetParameterValue("RptName", "All Transactions Report ");


                crystalReportViewer1.ReportSource = t1;
            }

            if (frmReports.selectedReport == 8)
            {
                Transactions t2 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(8, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t2.SetDataSource(dt);
                t2.Refresh();
                t2.SetDatabaseLogon(username, pass, server, dbname, false);
                t2.SetParameterValue("FromDate", frmReports.from);
                t2.SetParameterValue("ToDate", frmReports.to);
                t2.SetParameterValue("ComName", comname.ToString());
                t2.SetParameterValue("Address", address.ToString());
                t2.SetParameterValue("Mobile", mobile.ToString());
                t2.SetParameterValue("RptName", "All Buy Transactions Report");


                crystalReportViewer1.ReportSource = t2;
            }

            if (frmReports.selectedReport == 9)
            {
                Transactions t3 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(9, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t3.SetDataSource(dt);
                t3.Refresh();
                t3.SetDatabaseLogon(username, pass , server, dbname, false);
                t3.SetParameterValue("FromDate", frmReports.from);
                t3.SetParameterValue("ToDate", frmReports.to);
                t3.SetParameterValue("ComName", comname.ToString());
                t3.SetParameterValue("Address", address.ToString());
                t3.SetParameterValue("Mobile", mobile.ToString());
                t3.SetParameterValue("RptName", "Buy Cash Transactions");


                crystalReportViewer1.ReportSource = t3;
            }

            if (frmReports.selectedReport == 10)
            {
                Transactions t4 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(10, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t4.SetDataSource(dt);
                t4.Refresh();
                t4.SetDatabaseLogon(username, pass, server, dbname, false);
                t4.SetParameterValue("FromDate", frmReports.from);
                t4.SetParameterValue("ToDate", frmReports.to);
                t4.SetParameterValue("ComName", comname.ToString());
                t4.SetParameterValue("Address", address.ToString());
                t4.SetParameterValue("Mobile", mobile.ToString());
                t4.SetParameterValue("RptName", "Buy Cheq Transactions");


                crystalReportViewer1.ReportSource = t4;
            }

            if (frmReports.selectedReport == 11)
            {
                Transactions t5 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(11, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t5.SetDataSource(dt);
                t5.Refresh();
                t5.SetDatabaseLogon(username, pass, server, dbname, false);
                t5.SetParameterValue("FromDate", frmReports.from);
                t5.SetParameterValue("ToDate", frmReports.to);
                t5.SetParameterValue("ComName", comname.ToString());
                t5.SetParameterValue("Address", address.ToString());
                t5.SetParameterValue("Mobile", mobile.ToString());
                t5.SetParameterValue("RptName", "All Sell Transactions");


                crystalReportViewer1.ReportSource = t5;
            }

            if (frmReports.selectedReport == 12)
            {
                Transactions t6 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(12, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t6.SetDataSource(dt);
                t6.Refresh();
                t6.SetDatabaseLogon(username, pass, server, dbname, false);
                t6.SetParameterValue("FromDate", frmReports.from);
                t6.SetParameterValue("ToDate", frmReports.to);
                t6.SetParameterValue("ComName", comname.ToString());
                t6.SetParameterValue("Address", address.ToString());
                t6.SetParameterValue("Mobile", mobile.ToString());
                t6.SetParameterValue("RptName", "Sell Cash Transactions");


                crystalReportViewer1.ReportSource = t6;
            }

            if (frmReports.selectedReport == 13)
            {
                Transactions t7 = new Transactions();
                DataTable dt = db.DataSourceReportBuilder(13, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                t7.SetDataSource(dt);
                t7.Refresh();
                t7.SetDatabaseLogon(username, pass, server, dbname, false);
                t7.SetParameterValue("FromDate", frmReports.from);
                t7.SetParameterValue("ToDate", frmReports.to);
                t7.SetParameterValue("ComName", comname.ToString());
                t7.SetParameterValue("Address", address.ToString());
                t7.SetParameterValue("Mobile", mobile.ToString());
                t7.SetParameterValue("RptName", "Sell Cheq Transactions");


                crystalReportViewer1.ReportSource = t7;
            }

            if (frmReports.selectedReport == 14)
            {
                TransactionsServies ts1 = new TransactionsServies();
                DataTable dt = db.DataSourceReportBuilder(14, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                ts1.SetDataSource(dt);
                ts1.Refresh();
                ts1.SetDatabaseLogon(username, pass, server, dbname, false);
                ts1.SetParameterValue("FromDate", frmReports.from);
                ts1.SetParameterValue("ToDate", frmReports.to);
                ts1.SetParameterValue("ComName", comname.ToString());
                ts1.SetParameterValue("Address", address.ToString());
                ts1.SetParameterValue("Mobile", mobile.ToString());
                ts1.SetParameterValue("RptName", "All Services Transactions");


                crystalReportViewer1.ReportSource = ts1;
            }

            if (frmReports.selectedReport == 15 )
            {
                rptCustomers ct1 = new rptCustomers();
                DataTable dt = db.DataSourceReportBuilder(15, Resources.AZversion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                ct1.SetDataSource(dt);
                ct1.Refresh();
                ct1.SetDatabaseLogon(username, pass, server, dbname, false);
                ct1.SetParameterValue("FromDate", frmReports.from);
                ct1.SetParameterValue("ToDate", frmReports.to);
                ct1.SetParameterValue("ComName", comname.ToString());
                ct1.SetParameterValue("Address", address.ToString());
                ct1.SetParameterValue("Mobile", mobile.ToString());
                ct1.SetParameterValue("RptName", "Customers List");


                crystalReportViewer1.ReportSource = ct1;
            }


            if (frmPrintInvoice.selectedReportp == 16 && ((frmPrintInvoice.CustVerp.ToString() == Resources.AZversion)))
            {
                DataTable dtablef = new DataTable();
                string vin = frmPrintInvoice.carvin;
                string condition = "VIN=" + "'" + @vin + "'";
                dtablef = o.SelctData(cartabel, 1, condition);

                string bm = dtablef.Rows[0]["makeModel"].ToString();

                string year = dtablef.Rows[0]["years"].ToString();
                string mill = dtablef.Rows[0]["Millages"].ToString();
                string col = dtablef.Rows[0]["color"].ToString();


                string millages = dtablef.Rows[0]["Millages"].ToString();

             


                AZINVOICEE ainv = new AZINVOICEE();
                DataTable dt = db.FatoraView(16 , frmPrintInvoice.CustVerp.ToString(), frmPrintInvoice.carvin);
                ainv.SetDataSource(dt);

                ainv.Refresh();
                ainv.SetDatabaseLogon(username, pass, server, dbname, false);

                ainv.SetParameterValue("ComName", comname.ToString());
                ainv.SetParameterValue("Address", address.ToString());
                ainv.SetParameterValue("Mobile", mobile.ToString());
             //   ainv.SetParameterValue("Taxno", taxNo.ToString());
                ainv.SetParameterValue("year", year.ToString());
                ainv.SetParameterValue("color", col.ToString());
                ainv.SetParameterValue("mill", millages.ToString());
                ainv.SetParameterValue("makemodel", bm.ToString());
               



                crystalReportViewer1.ReportSource = ainv;

            }


            if (frmAddServicecs.selectedReportpc == 17)
            {

           
                rptServiceInv sinv = new rptServiceInv();
                string vin = frmAddServicecs.carvin; 
                string condition = "vin=" + "'" + @vin + "'";
                string conditionqty =@vin;

                DataTable dt = o.SelctData("TransServices", 1 , condition);

                int qty = int.Parse(dt.Rows.Count.ToString());
                //  DataTable qty = o.SelctData("TransServices", 11 , conditionqty);
                sinv.SetDataSource(dt);
                sinv.Refresh();
                sinv.SetDatabaseLogon(username, pass, server, dbname, false);

                sinv.SetParameterValue("ComName", comname.ToString());
                sinv.SetParameterValue("Address", address.ToString());
                sinv.SetParameterValue("Mobile", mobile.ToString());
                sinv.SetParameterValue("qty", qty.ToString());
                sinv.SetParameterValue("RptName", "Service Invoice");
                
                crystalReportViewer1.ReportSource = sinv;

            }


            if (frmReports.selectedReport == 0 && (frmReports.CusVersion.ToString() == Resources.JordanCleaningVersion))
            {
                CarTests  cts = new CarTests();
                DataTable dt = db.DataSourceReportBuilder(0, Resources.JordanCleaningVersion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                cts.SetDataSource(dt);
                cts.Refresh();
                cts.SetDatabaseLogon(username, pass, server, dbname, false);
                cts.SetParameterValue("FromDate", frmReports.from);
                cts.SetParameterValue("ToDate", frmReports.to);
                cts.SetParameterValue("ComName", comname.ToString());
                cts.SetParameterValue("Address", address.ToString());
                cts.SetParameterValue("Mobile", mobile.ToString());
                cts.SetParameterValue("RptName", "Car Tests Summary");


                crystalReportViewer1.ReportSource = cts;
            }

            if (frmReports.selectedReport == 1 && (frmReports.CusVersion.ToString() == Resources.JordanCleaningVersion))
            {
                TransactionsServies ts2 = new TransactionsServies();
                DataTable dt = db.DataSourceReportBuilder(1, Resources.JordanCleaningVersion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                ts2.SetDataSource(dt);
                ts2.Refresh();
                ts2.SetDatabaseLogon(username, pass, server, dbname, false);
                ts2.SetParameterValue("FromDate", frmReports.from);
                ts2.SetParameterValue("ToDate", frmReports.to);
                ts2.SetParameterValue("ComName", comname.ToString());
                ts2.SetParameterValue("Address", address.ToString());
                ts2.SetParameterValue("Mobile", mobile.ToString());
                ts2.SetParameterValue("RptName", " Services ");


                crystalReportViewer1.ReportSource = ts2;
            }

            if (frmReports.selectedReport == 2 && (frmReports.CusVersion.ToString() == Resources.JordanCleaningVersion))
            {
                CarTestsTax ctst = new CarTestsTax();
                DataTable dt = db.DataSourceReportBuilder(2, Resources.JordanCleaningVersion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                ctst.SetDataSource(dt);
                ctst.Refresh();
                ctst.SetDatabaseLogon(username, pass, server, dbname, false);
                ctst.SetParameterValue("FromDate", frmReports.from);
                ctst.SetParameterValue("ToDate", frmReports.to);
                ctst.SetParameterValue("ComName", comname.ToString());
                ctst.SetParameterValue("Address", address.ToString());
                ctst.SetParameterValue("Mobile", mobile.ToString());
                ctst.SetParameterValue("RptName", " Total Recived Tax ");


                crystalReportViewer1.ReportSource = ctst;
            }

            if (frmReports.selectedReport == 3 && (frmReports.CusVersion.ToString() == Resources.JordanCleaningVersion))
            {

                rptCustomers ct2 = new rptCustomers();
                DataTable dt = db.DataSourceReportBuilder(3, Resources.JordanCleaningVersion, frmReports.from.Date, frmReports.to.Date , frmAddCarTset.carvin);
                ct2.SetDataSource(dt);
                ct2.Refresh();
                ct2.SetDatabaseLogon(username, pass, server, dbname, false);
                ct2.SetParameterValue("FromDate", frmReports.from);
                ct2.SetParameterValue("ToDate", frmReports.to);
                ct2.SetParameterValue("ComName", comname.ToString());
                ct2.SetParameterValue("Address", address.ToString());
                ct2.SetParameterValue("Mobile", mobile.ToString());
                ct2.SetParameterValue("RptName", "Customers List");


                crystalReportViewer1.ReportSource = ct2;
            }


            if (frmAddCarTset.selectedReport == 4 && ((frmAddCarTset.CustVer.ToString() == Resources.JordanCleaningVersion)))
            {
                
                JorInvoice inv = new JorInvoice();
                DataTable dt = db.FatoraView(4 , frmAddCarTset.CustVer.ToString() , frmAddCarTset.carvin);
                inv.SetDataSource(dt);
                
                inv.Refresh();
                inv.SetDatabaseLogon(username, pass, server, dbname, false);

                inv.SetParameterValue("ComName", comname.ToString());
                inv.SetParameterValue("Address", address.ToString());
                inv.SetParameterValue("Mobile", mobile.ToString());
                inv.SetParameterValue("Taxno", taxNo.ToString());
               
                
                crystalReportViewer1.ReportSource = inv;
              
            }
        }
    }
}
