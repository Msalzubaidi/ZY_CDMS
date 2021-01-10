using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        DataBase d = new DataBase();


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
            String prt = "";
            if (frmLogin.languagearabic == 1 )
            {
                prt = ResourcesAR.ExitPromt; ;
             
            }
            else
            {
                prt = Resources.ExitPromtEng; ;
            }
            DialogResult result = MessageBox.Show(prt.ToString() ,  Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes )
            {

             
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
            int x = int.Parse(DataBase.Unum.ToString());
            string logedusername = DataBase.Username.ToString();
            DataTable userPermission = d.ViewUserper(x);
            DataTable datatable = o.SelctData(table,0,"");

            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6
            DateTime dt = DateTime.Parse(datatable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(datatable.Rows[0]["licencefrom"].ToString());
            string titleform = datatable.Rows[0]["name"].ToString();
            TimeSpan t = dt - dt1;
            double NrOfDays = t.TotalDays;

            string nl = "\r\n";

            if (userPermission.Rows.Count != null)
            { 
            ///////////////////////////  User Permission //////////////////////////////

               
            int Settings = int.Parse(userPermission.Rows[0]["settings"].ToString());
            int MakeModel = int.Parse(userPermission.Rows[0]["makemodel"].ToString());
            int EditMakeModel = int.Parse(userPermission.Rows[0]["editmakemodel"].ToString());
            int Services = int.Parse(userPermission.Rows[0]["service"].ToString());
            int EditServices = int.Parse(userPermission.Rows[0]["editservice"].ToString());
            int Paymethods = int.Parse(userPermission.Rows[0]["paymethods"].ToString());
            int SourceCar = int.Parse(userPermission.Rows[0]["sourcecar"].ToString());
            int PaintCodes = int.Parse(userPermission.Rows[0]["paintcodes"].ToString());
            int TaxCat = int.Parse(userPermission.Rows[0]["taxCat"].ToString());
            int Operations = int.Parse(userPermission.Rows[0]["operations"].ToString());
            int BuyCar = int.Parse(userPermission.Rows[0]["buycar"].ToString());
            int addserivetocar = int.Parse(userPermission.Rows[0]["addserivetocar"].ToString());
            int SellCar = int.Parse(userPermission.Rows[0]["sellcar"].ToString());
            int PrintInvoice = int.Parse(userPermission.Rows[0]["printinvoice"].ToString());
            int Customers = int.Parse(userPermission.Rows[0]["customers"].ToString());
            int CarMaintainance = int.Parse(userPermission.Rows[0]["carMain"].ToString());
            int Search = int.Parse(userPermission.Rows[0]["searchMain"].ToString());
            int search = int.Parse(userPermission.Rows[0]["search"].ToString());
            int Reports = int.Parse(userPermission.Rows[0]["Reports"].ToString());
            int report = int.Parse(userPermission.Rows[0]["rpt"].ToString());
            int SystemManage = int.Parse(userPermission.Rows[0]["systemMange"].ToString());
            int sysinfo = int.Parse(userPermission.Rows[0]["sysinfo"].ToString());
            int userSettings = int.Parse(userPermission.Rows[0]["usersettings"].ToString());
            int MyAccountSettings = int.Parse(userPermission.Rows[0]["MyAcc"].ToString());
            int Exit = int.Parse(userPermission.Rows[0]["pExit"].ToString());
         

            if (Settings == 0)
                mun_settings.Visible = false;
            if (MakeModel == 0)
                defineMakeModelToolStripMenuItem.Visible = false;
            if (EditMakeModel == 0)
                editMakeModelToolStripMenuItem.Visible = false;
            if (Services == 0)
                defineServicesToolStripMenuItem.Visible = false;
            if (EditServices == 0)
                editServicesToolStripMenuItem .Visible = false;
            if (Paymethods == 0)
                    definePayMethodsToolStripMenuItem.Visible = false;

            if (SourceCar == 0 )
                    defineSourceCarToolStripMenuItem.Visible = false;

            if (PaintCodes == 0 )

                    definePaintCodesToolStripMenuItem.Visible = false;

                if (TaxCat == 0)

                    defineTaxCategoriesToolStripMenuItem.Visible = false;
            if (Operations == 0)
                { 
                        mnu_operations.Visible = false;
                accordionControlElement1.Visible = false;
                }

                if (BuyCar == 0)
                {
                    buyCarToolStripMenuItem.Visible = false;
                    accordionControlElement5.Visible = false;
                }


                if (SellCar == 0  )
                {
                    sellCarToolStripMenuItem.Visible = false;
                    accordionControlElement6.Visible = false;
                }
                   

                if (addserivetocar == 0)
                {
                    addServiceToCarToolStripMenuItem.Visible = false;
                    accordionControlElement9.Visible = false;
                }
                   


                if (PrintInvoice == 0)
                {
                    printInvoiceToolStripMenuItem.Visible = false;
                    accordionControlElement8.Visible = false;
                }
                   


                if (Customers == 0)
                {
                    addCustomerToolStripMenuItem.Visible = false;
                    accordionControlElement10.Visible = false;
                }
                    


                if (CarMaintainance == 0 )
                {
                    carMaintainanceToolStripMenuItem.Visible = false;
                    accordionControlElement12.Visible = false;
                }
                   

                if (Search == 0)
                {

                    tab_cars.Visible = false;
                    accordionControlElement2.Visible = false;
                }


                if (search == 0)
                {

                    carsToolStripMenuItem.Visible = false;
                    accordionControlElement14.Visible = false;
                }

                if (Reports == 0)

                {
                    mnu_reports.Visible = false;
                    accordionControlElement3.Visible = false;

                }

                if (report == 0)
                {
                    tab_reports.Visible = false;
                    accordionControlElement17.Visible = false;
                }
                    

                if (SystemManage == 0)
                    mun_sysmanage.Visible = false;

            if (sysinfo == 0)

                    tab_sysinfo.Visible = false;
            if (userSettings == 0)

                    tab_usersettings.Visible = false; 
            if (MyAccountSettings == 0 || MyAccountSettings == 1 )
             mnu_myaccount.Visible = true ;
                if (Exit == 0 || Exit == 1)
                {
                    mnu_exit.Visible = true;

                
                }

           }

            else
            {
                mnu_operations.Visible = false;
                mnu_reports.Visible = false;
                mun_settings.Visible = false;
                tab_cars.Visible = false;
                mun_sysmanage.Visible = false;
                accordionControlElement1.Visible = false;
                accordionControlElement2.Visible = false;
                accordionControlElement3.Visible = false;

                MessageBox.Show(logedusername + " Hasn't Permissions", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            /////////////////////////////////

            if (version.ToString() == Resources.JordanCleaningVersion)
            {
                carMaintainanceToolStripMenuItem.Visible = true;
                accordionControlElement12.Visible = true;
                buyCarToolStripMenuItem.Visible = false;
                sellCarToolStripMenuItem.Visible = false;
                accordionControlElement5.Visible = false;
                accordionControlElement6.Visible = false;
                definePayMethodsToolStripMenuItem.Visible = false;
                defineSourceCarToolStripMenuItem.Visible = false;
            }



            int flag = 0;

            if (NrOfDays > 30)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;

               

                flag = 0;
                
                if (frmLogin.languagearabic == 1 )
                {
                    lic.Text = Resources.LogoAR + " " + Resources.AppNameAR + " - نسخة مرخصة  ل ( " + " " + titleform.ToString() + " ) " + nl + "الرخصة فعالة لغاية  " + dt.ToShortDateString(); ;
                }
                else
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) " + nl + "License Active to " + dt.ToShortDateString(); ;
                }

            }
            if (NrOfDays <= 30)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Azure;

                if (frmLogin.languagearabic == 1)
                {
                    lic.Text = Resources.LogoAR + " " + Resources.AppNameAR + " - نسخة مرخصة ل ( " + " " + titleform.ToString() + " ) " + nl + "ستنتهي صلاحية الرخصة خلال " + "" + NrOfDays.ToString() + " " + "يوم";
                }
                else
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " ) " + nl + "License will be Expired by " + "" + NrOfDays.ToString() + " " + "Days";
                }



             

                flag = 0;
            }
            if (NrOfDays <= 0)
            {
                lic.Visible = true;
                lic.ForeColor = Color.Red;


                if (frmLogin.languagearabic == 1)
                {
                    lic.Text = Resources.LogoAR + " " + Resources.AppNameAR + " - نسخة مرخصة ل  ( " + " " + titleform.ToString() + " )  " + nl + "انتهت صلاحية الرخصة في  " + "" + dt.ToShortDateString();
                }
                else
                {
                    lic.Text = Resources.Logo + " " + Resources.AppName + " - Licensed for ( " + " " + titleform.ToString() + " )  " + nl + "License Expired in " + "" + dt.ToShortDateString();
                }



               
                mnu_operations.Visible = false;
                mnu_reports.Visible = false;
                mun_settings.Visible = false;
                tab_cars.Visible = false;
             
                accordionControlElement1.Visible = false;
                accordionControlElement2.Visible = false;
                accordionControlElement3.Visible = false;

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
            DataTable datatable = o.SelctData(table, 0, "");

            int version = int.Parse(datatable.Rows[0]["version"].ToString());//6

           

            switch (version)
            {
                case 10: // AZ

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

                    break;
                case 20: // JOClean

                    bool isopen2 = false;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "Add Car Test")
                        {
                            isopen2 = true;
                            f.BringToFront();
                            break;
                        }
                    }

                    if (isopen2 == false)
                    {
                        frmAddCarTset act = new frmAddCarTset();
                        act.Show();

                    }

                    break;

                default:
                    MessageBox.Show("Please Contact With : +962790480266 -  Mohammad Alzubaidi ");
                    break;
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
                if (f.Text == "Reports")
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

        private void عربيToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
