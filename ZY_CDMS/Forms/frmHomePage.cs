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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        string table = "SystemInfo";

        private void defineMakeModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Brand")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddBrand df = new frmAddBrand();
              
                df.Show();
            }
        }

        private void editMakeModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Update Brand Info")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmUpdateBrandInfo ubi = new frmUpdateBrandInfo();
                
                ubi.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to exit ?  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

               // MessageBox.Show("Please Close All Open Forms ", Resources.MessageTitle, 0  , MessageBoxIcon.Warning);
                Application.Exit();
              


            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void defineServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Define Services")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmDefineServices ds = new frmDefineServices();
             
                ds.Show();
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void editServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Edit Services")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmEditServices es = new frmEditServices();
               
                es.Show();
            }
        }

        private void definePayMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Pay Method")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
               frmAddPayMethod dpm = new frmAddPayMethod();
               
                dpm.Show();
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            tab_accountsettings.PerformClick();
        }

        private void defineSourceCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Car Source")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
               frmAddCarSource dosc = new frmAddCarSource();
                
                dosc.Show();
            }
        }

        private void definePaintCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Paints Code")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddPaintsCode dc = new frmAddPaintsCode();
               
                dc.Show();
            }
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            mnu_exit.PerformClick();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {


            DataTable datatable = o.SelctData(table,0,"");

            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6
            DateTime dt = DateTime.Parse(datatable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(datatable.Rows[0]["licencefrom"].ToString());
            string titleform = datatable.Rows[0]["name"].ToString();
            TimeSpan t = dt - dt1;
            double NrOfDays = t.TotalDays;

            string nl = "\r\n";
            

            int flag = 0;

            if (NrOfDays > 30)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;

                logo.ForeColor = Color.Azure;

                flag = 0;
                logo.Text = Resources.Logo ;
                lic.Text = Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) "+ "License Active to " + dt.ToShortDateString(); ;

            }
            if (NrOfDays <= 30)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;
                logo.ForeColor = Color.Azure;
                logo.Text = Resources.Logo;
                lic.Text = Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) " +  "License will be Expired by " + "" + NrOfDays.ToString() + " " + "Days";

                flag = 0;
            }
            if (NrOfDays <= 0)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Red;
                logo.ForeColor = Color.Red;
                logo.Text = Resources.Logo;
                lic.Text = Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " )  " + "License Expired in " + "" + dt.ToShortDateString();
                




            }

        }

        private void myAccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "My Account Setttings")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAccountSetttings fas = new frmAccountSetttings();
               
                fas.Show();
            }
        }

        private void LoadMenus_Click(object sender, EventArgs e)
        {
            
        }

        private void buyCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add New Car")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddNewCar nc = new frmAddNewCar();
               
                nc.Show();
            }
        }

        private void sellCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Sell Car")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmSellCar sc = new frmSellCar();
               
                sc.Show();
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            buyCarToolStripMenuItem.PerformClick();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Customer")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddCustomer ac = new frmAddCustomer();
                
                ac.Show();
            }
        }

        private void updateCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            sellCarToolStripMenuItem.PerformClick();
        }

        private void addServiceToCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Servicecs")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddServicecs ad = new frmAddServicecs();
                
                ad.Show();
            }
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            addCustomerToolStripMenuItem.PerformClick();
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Print Invoice")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmPrintInvoice pi = new frmPrintInvoice();
                
                pi.Show();

            }
        }

        private void carMaintainanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Car Test")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddCarTset ct = new frmAddCarTset();
                
                ct.Show();
            }
        }

        private void defineTaxCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Tax Categories")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmTaxCategoriescs tc = new frmTaxCategoriescs();
             

                tc.Show();
            }
        }

        private void tab_sysinfo_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "System Info")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmSystemInfo si = new frmSystemInfo();
               
                
                si.Show();
                
            }
        }

        private void lic_DoubleClick(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "About")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAbout about = new frmAbout();
              
                about.Show();
            }
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            carMaintainanceToolStripMenuItem.PerformClick();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            printInvoiceToolStripMenuItem.PerformClick();
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Search")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmSearch s = new frmSearch();
                
                s.Show();

            }
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            carsToolStripMenuItem.PerformClick();
        }

        private void tab_usersettings_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "My Account Setttings")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmUsersManagment um = new frmUsersManagment();
               

                um.Show();
            }
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            addServiceToCarToolStripMenuItem.PerformClick();
        }

        private void tab_reports_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "System Info")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmReports r = new frmReports();
              
                r.Show();

            }
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            tab_reports.PerformClick();
        }
    }
}
