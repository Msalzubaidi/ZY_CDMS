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
    public partial class frmUsersManagment : Form
    {
        public frmUsersManagment()
        {
            InitializeComponent();
        }

        string table = "Users";
        Operations o = new Operations();
        Rules r = new Rules();
        DataBase d = new DataBase();

        private void frmUsersManagment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmUsersManagment_Load(object sender, EventArgs e)
        {
            simpleButton3.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select * from Users";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                string item1 = dr3.GetValue(0).ToString();

                cbo_userid.Properties.Items.Add(item1);

            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void SetChildrenChecked(TreeNode treeNode, bool checkedState)
        {
           
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
          

        

        }

        private void cbo_userid_TextChanged(object sender, EventArgs e)
        {
            DataBase d = new DataBase();
            //simpleButton1.Visible = true;
            //simpleButton5.Visible = false;
            //simpleButton4.Visible = true;
            if (string.IsNullOrEmpty(cbo_userid.Text) || r.isDigitsOnly(cbo_userid.Text) == false)
            {
                // MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton3.PerformClick();
            }

            else

            {
            
                int v = int.Parse(cbo_userid.EditValue.ToString());
                string condition = "user_id=" + v.ToString();
                DataTable dtp = d.ViewUserper(v);

                DataTable dtable = o.SelctData(table, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {
                    simpleButton3.PerformClick();
                    txt_userid.Text = dtable.Rows[0]["user_id"].ToString();//1
                    txt_username.Text = dtable.Rows[0]["user_name"].ToString();//2
                    txt_pass.Text = dtable.Rows[0]["password"].ToString();
                    int Settings = int.Parse(dtp.Rows[0]["settings"].ToString());
                    int MakeModel = int.Parse(dtp.Rows[0]["makemodel"].ToString());
                    int EditMakeModel = int.Parse(dtp.Rows[0]["editmakemodel"].ToString());
                    int Services = int.Parse(dtp.Rows[0]["service"].ToString());
                    int EditServices = int.Parse(dtp.Rows[0]["editservice"].ToString());
                    int Paymethods = int.Parse(dtp.Rows[0]["paymethods"].ToString());
                    int SourceCar = int.Parse(dtp.Rows[0]["sourcecar"].ToString());
                    int PaintCodes = int.Parse(dtp.Rows[0]["paintcodes"].ToString());
                    int TaxCat = int.Parse(dtp.Rows[0]["taxCat"].ToString());
                    int Operations = int.Parse(dtp.Rows[0]["operations"].ToString());
                    int servicetocar = int.Parse(dtp.Rows[0]["addserivetocar"].ToString());
                    int BuyCar = int.Parse(dtp.Rows[0]["buycar"].ToString());
                    int SellCar = int.Parse(dtp.Rows[0]["sellcar"].ToString());
                    int PrintInvoice = int.Parse(dtp.Rows[0]["printinvoice"].ToString());
                    int Customers = int.Parse(dtp.Rows[0]["customers"].ToString());
                    int CarMaintainance = int.Parse(dtp.Rows[0]["carMain"].ToString());
                    int Search = int.Parse(dtp.Rows[0]["searchMain"].ToString());
                    int search = int.Parse(dtp.Rows[0]["search"].ToString());
                    int Reports = int.Parse(dtp.Rows[0]["Reports"].ToString());
                    int report = int.Parse(dtp.Rows[0]["rpt"].ToString());
                    int SystemManage = int.Parse(dtp.Rows[0]["systemMange"].ToString());
                    int sysinfo = int.Parse(dtp.Rows[0]["sysinfo"].ToString());
                    int userSettings = int.Parse(dtp.Rows[0]["usersettings"].ToString());
                    int MyAccountSettings = int.Parse(dtp.Rows[0]["MyAcc"].ToString());
                    int Exit = int.Parse(dtp.Rows[0]["pExit"].ToString());
                    int Admin = int.Parse(dtp.Rows[0]["admin"].ToString());
                    int UserLog = int.Parse(dtp.Rows[0]["usersLogTrans"].ToString());
                    if (Settings == 1)
                        chk_Settings.Checked = true;
                    if (MakeModel == 1)
                        chk_dmm.Checked = true;
                    if (EditMakeModel == 1)
                        chk_emm.Checked = true;
                    if (Services == 1)
                        chk_sv.Checked = true;
                    if (EditServices == 1)
                        chk_esv.Checked = true;
                    if (Paymethods == 1)
                        chk_pm.Checked = true;
                    if (servicetocar == 1)
                        chk_asc.Checked = true;

                    if (SourceCar == 1)
                        chk_dsc.Checked = true;
                    if (PaintCodes == 1)
                        chk_pc.Checked = true;
                    if (TaxCat == 1)
                        chk_tc.Checked = true;
                    if (Operations == 1)
                        chk_Operations.Checked = true;
                    if (BuyCar == 1)
                        chk_bc.Checked = true;
                    if (SellCar == 1)
                        chk_sc.Checked = true;
                
                    if (PrintInvoice == 1)
                        chk_pi.Checked = true;
                    if (Customers == 1)
                        chk_cust.Checked = true;
                    if (CarMaintainance == 1)
                        chk_cm.Checked = true;
                    if (Search == 1 )
                        chk_Search.Checked = true;
                    if (search == 1 )
                    chk_srch.Checked = true;

                    if (Reports == 1 )
                        chk_Reports.Checked = true;
                    if (report == 1 )
                        chk_rpt.Checked = true;

                    if (SystemManage == 1)
                    chk_systemMange.Checked = true;
                    if (sysinfo == 1)
                        chk_sysinfo.Checked = true;
                    if (userSettings == 1)
                        chk_us.Checked = true;
                    if (UserLog == 1)
                        chk_lt.Checked = true;
                    if (MyAccountSettings == 1)
                        chk_MyAcc.Checked = true;
                    if (Exit == 1)
                        chk_Exit.Checked = true;
                    if (Admin == 1)
                        chk_admin.Checked = true;



                }

                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton3.PerformClick();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txt_userid.Clear();
            int y = r.FindMax(table);

            txt_userid.Text = y.ToString();
       

          //  simpleButton1.Visible = false;
           // simpleButton5.Visible = true;
           // simpleButton4.Visible = false;
            
        
            txt_username.Clear();
            txt_pass.Clear();
            cbo_userid.Focus();

            chk_Settings.Checked = false;
          
                chk_dmm.Checked = false;
                chk_emm.Checked = false;
                chk_sv.Checked = false;
                chk_esv.Checked = false;
                chk_pm.Checked = false;
                chk_dsc.Checked = false;
                chk_pc.Checked = false;
                chk_tc.Checked = false;
            chk_lt.Checked = false;

            chk_Operations.Checked = false;
            
                chk_bc.Checked = false;
                chk_sc.Checked = false;
                chk_pi.Checked = false;
                chk_cust.Checked = false;
                chk_cm.Checked = false;
                chk_asc.Checked = false; 

            
            chk_Search.Checked = false;
            

                chk_srch.Checked = false;
            
            chk_Reports.Checked = false;
            

                chk_rpt.Checked = false;

            chk_systemMange.Checked= false;
           

                chk_sysinfo.Checked = false;
                chk_us.Checked = false;
            


        }
       
        private void chk_Settings_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Settings.Checked)
            {
                chk_dmm.Checked = true;
                chk_emm.Checked = true;
                chk_sv.Checked = true;
                chk_esv.Checked = true;
                chk_pm.Checked = true;
                chk_dsc.Checked = true;
                chk_pc.Checked = true;
                chk_tc.Checked = true;
            }

        }

        private void chk_Operations_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Operations.Checked)
            {
                chk_bc.Checked = true;
                chk_sc.Checked = true;
                chk_pi.Checked = true;
                chk_cust.Checked = true;
                chk_cm.Checked = true;
                chk_asc.Checked = true;
            }
        }

        private void chk_Search_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Search.Checked)
            {
               
                chk_srch.Checked = true;
            }
        }

        private void chk_Reports_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Reports.Checked)
            {
           
                chk_rpt.Checked = true;
            }
        }

        private void chk_systemMange_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_systemMange.Checked)
            {
              
                chk_sysinfo.Checked = true;
                chk_us.Checked = true;
                chk_lt.Checked = true;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_admin.Checked)
            {
                chk_Settings.Checked = true;
                chk_Operations.Checked = true;
                chk_MyAcc.Checked = true;
                chk_Exit.Checked = true;
                chk_systemMange.Checked = true;
                chk_Reports.Checked = true;
                chk_Search.Checked = true;
                chk_lt.Checked = true;

            }
            else if (chk_admin.Checked ==false  )
            {
                simpleButton3.PerformClick();

            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            int Settings = 0; 
            int MakeModel = 0;
            int EditMakeModel = 0;
            int Services = 0;
            int EditServices = 0;
            int Paymethods = 0;
            int SourceCar = 0;
            int PaintCodes = 0;
            int TaxCat = 0;
            int Operations = 0; 
            int BuyCar = 0;
            int SellCar = 0;
            int PrintInvoice = 0;
            int Customers = 0;
            int addserivetocar = 0;
            int CarMaintainance = 0;
            int Search = 0;
            int search = 0;
            int Reports = 0;
            int report = 0;
            int SystemManage = 0; 
            int sysinfo = 0;
            int userSettings = 0;
            int MyAccountSettings = 1; 
            int Exit = 1;
            int Admin = 0;
            int UserLog = 0;
         
            if (chk_admin.Checked == true )
            {
                Admin = 1;
                
            }
            if (chk_Exit.Checked == true)
            {
                Exit = 1;
                
            }
            if (chk_MyAcc.Checked == true)
            {
                MyAccountSettings = 1;
               
            }
            if (chk_admin.Checked == true)
            {

                Settings = 1;
                Operations = 1;
                Search = 1;
                Reports = 1;
                SystemManage = 1;

                 MakeModel = 1;
                 EditMakeModel = 1;
                 Services = 1;
                 EditServices = 1;
                 Paymethods = 1;
                 SourceCar = 1;
                 PaintCodes = 1;
                 TaxCat = 1;
               
                 BuyCar = 1;
                 SellCar = 1;
                 PrintInvoice = 1;
                 Customers = 1;
                 CarMaintainance = 1;
                addserivetocar = 1;
                 search = 1;

                
                 report = 1;
              
                 sysinfo = 1;
                 userSettings = 1;

                 MyAccountSettings = 1;
                 Exit = 1;
              
            }

                if (chk_dmm.Checked == true)
                {
                Settings = 1;
                MakeModel = 1;
                }
                if (chk_emm.Checked == true)
                {
                Settings = 1;
                EditMakeModel = 1;
                }
                if (chk_sv.Checked == true)
                {
                Settings = 1;
                Services = 1;
                }
                if (chk_esv.Checked == true)
                {
                Settings = 1;
                EditServices = 1;
                }
                if (chk_pm.Checked == true)
                {
                Settings = 1;
                Paymethods = 1;
                }
                if (chk_dsc.Checked == true)
                {
                Settings = 1;
                SourceCar = 1;
                }
                if (chk_pc.Checked == true)
                {
                Settings = 1;
                PaintCodes = 1;
                }
                if (chk_tc.Checked == true)
                {
                Settings = 1;
                TaxCat = 1;
                }
            
          
                if (chk_bc.Checked == true)
            {
                Operations = 1;
                BuyCar = 1;
                }
                if (chk_sc.Checked == true)
            {
                Operations = 1;
                SellCar = 1;
                }
                if (chk_pi.Checked == true)
            {
                Operations = 1;
                PrintInvoice = 1;
                }
                if (chk_cust.Checked == true)
            {
                Operations = 1;
                Customers = 1;
                }

            if (chk_asc.Checked == true)
            {
                Operations = 1;
                addserivetocar = 1;
            }


            if (chk_cm.Checked == true)
            {
                Operations = 1;
                CarMaintainance = 1;
                }
               
       
          
              
                if (chk_srch.Checked == true)
                {
                Search = 1;

                    search = 1;
                }

           
                  
                    if (chk_rpt.Checked == true)
                    {
                Reports = 1; 
                        report = 1;
                    }
             
                   
                    if (chk_sysinfo.Checked == true)
                    {
                SystemManage = 1; 
                        sysinfo = 1;
                UserLog = 1;
                    }
                    if (chk_us.Checked == true)
                    {
                SystemManage = 1;
                userSettings = 1;
                    }
                
            
            
                if (r.isDigitsOnly(txt_userid.Text) == false || string.IsNullOrEmpty(txt_userid.Text) || string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_pass.Text))
                {
                    MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {
                    int userid = int.Parse(txt_userid.Text);
                    string username = txt_username.Text;
                    string password = txt_pass.Text;

                    int add = d.AddUser(userid, username, password , 0);

                    if (add > 0)
                    {
                    
                        MessageBox.Show(table + Resources.AddedSuccessfully, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    d.AddUserPer(userid , Settings , MakeModel , EditMakeModel , Services , EditServices , Paymethods , SourceCar , PaintCodes , TaxCat , Operations ,BuyCar ,SellCar  ,  PrintInvoice  , addserivetocar, Customers  , CarMaintainance , Search , search , Reports , report , SystemManage , sysinfo , userSettings , MyAccountSettings , Exit , Admin , UserLog , 0 );
                    simpleButton3.PerformClick();
                    

                    }
                    else if (add <= 0)
                    {
                        MessageBox.Show(table + Resources.Exist, Resources.MessageTitle, 0, MessageBoxIcon.Hand);
                        simpleButton3.PerformClick();
                    }
                }

            
            }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To DeActivted User ? ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int num = int.Parse(txt_userid.Text);

                int rest = d.ActivateOrDeactivate(num, 10);
                if (string.IsNullOrEmpty(txt_userid.Text))
                    MessageBox.Show("Invalid User id  ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                else

                if (rest > 0)
                {
             
                    MessageBox.Show("User DeActivated ", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    d.ActivateDeActivatePermissions(num, 10);
                    simpleButton3.PerformClick();
                }
                else if (rest <= 0)
                {
                    MessageBox.Show("User Not Exist", Resources.MessageTitle, 0, MessageBoxIcon.Error);
                
                }




            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled by User ", Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                simpleButton3.PerformClick();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, You haven't Permission To Update Userinformation ", Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
        }

        private void chk_us_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Activte User ? ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int num = int.Parse(txt_userid.Text);

                int rest = d.ActivateOrDeactivate(num , 20 );
                if (string.IsNullOrEmpty(txt_userid.Text))
                    MessageBox.Show("Invalid User id  ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                else

                if (rest > 0)
                {

                    MessageBox.Show("User Activted", Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    d.ActivateDeActivatePermissions(num , 20);
                    simpleButton3.PerformClick();
                }
                else if (rest <= 0)
                {
                    MessageBox.Show("User Not Exist", Resources.MessageTitle, 0, MessageBoxIcon.Error);

                }




            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled by User ", Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
                simpleButton3.PerformClick();
            }
        }
    } 
    }

