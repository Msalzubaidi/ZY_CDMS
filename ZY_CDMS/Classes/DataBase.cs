﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Classes
{
    class DataBase
    {
        /* public static string servercon=Connection.s;
          public static string dbnamecon=Connection.dbn;
          public static string usernamecon=Connection.un;
          public static string passwordcon=Connection.ps;
          */
        Rules r = new Rules();
        public static string servercon =Resources.servercon; 
        public static string dbnamecon = Resources.dbnamecon;
        public static string usernamecon = Resources.usernamecon;
        public static string passwordcon =Resources.passwordcon;
        public static int ZYTECH = 0;
        public static int AZAuto = 10;
        public static int JordanCleaning = 20;
        public static string MasterPassword = DateTime.Now.ToString("ddMMyyyy");
        public static string connstring = @"Data Source=" + servercon + ";Initial Catalog=" + dbnamecon + ";User ID=" + usernamecon + ";Password=" + passwordcon;
        string table_name { get; set; }
        public static string Username { get; set; }
        public static int Unum { get; set; }
        string password { get; set; }
        string new_pass { get; set; }


       
        SqlConnection con = new SqlConnection(connstring);



        string qry = "";



        public int Login(string username, string password, int unum)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("select * from Users where user_name=@un and password=@pass and user_id=@unum", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@un", username); //store data in parameters to prevent sql injection (get from Password textbox)
            cmd.Parameters.AddWithValue("@pass", password);//store data in parameters to prevent sql injection (get from username textbox)
            cmd.Parameters.AddWithValue("@unum", unum);


            DataBase.Username = username;
            DataBase.Unum = unum;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Open();
            return dt.Rows.Count;

        }

      
        public DataTable ViewSysinfo(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string qry = "select * from SystemInfo";
            SqlCommand cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@id", id); //store data in parametageers to prevent sql injection (get from Password textbox)

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public DataTable ViewUSERinfo(int id)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("select * from Users where user_id=@id", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", id); //store data in parametageers to prevent sql injection (get from Password textbox)

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public int AddUserPer(int unum , int settings, int makemodel, int editmakemodel, int service, int editservice, int paymethods, int sourcecar, int paintcodes, int taxCat, int operations, int buycar, int sellcar, int printinvoice, int customers, int carMain, int searchMain, int search, int Reports, int rpt, int systemMange, int sysinfo, int usersettings, int MyAcc, int pExit, int admin)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO User_permission(user_id ,  settings,  makemodel,  editmakemodel,  service,  editservice,  paymethods,  sourcecar,  paintcodes,  taxCat,  operations,  buycar,  sellcar,  printinvoice,  customers,  carMain,  searchMain,  search,  Reports,  rpt,  systemMange,  sysinfo,  usersettings,  MyAcc,  pExit ,  admin) VALUES(@userid ,  @settings,  @makemodel,  @editmakemodel,  @service,  @editservice,  @paymethods,  @sourcecar,  @paintcodes,  @taxCat,  @operations,  @buycar,  @sellcar,  @printinvoice,  @customers,  @carMain,  @searchMain,  @search,  @Reports,  @rpt,  @systemMange,  @sysinfo,  @usersettings,  @MyAcc,  @pExit ,  @admin)", con); // sql command to so get data from data bas
           
            cmd.Parameters.Add(new SqlParameter("@userid", unum));
            cmd.Parameters.Add(new SqlParameter("@settings", settings));
            cmd.Parameters.Add(new SqlParameter("@makemodel", makemodel));
            cmd.Parameters.Add(new SqlParameter("@editmakemodel", editmakemodel));
            cmd.Parameters.Add(new SqlParameter("@service", service));
            cmd.Parameters.Add(new SqlParameter("@editservice", editservice));
            cmd.Parameters.Add(new SqlParameter("@paymethods", paymethods));
            cmd.Parameters.Add(new SqlParameter("@sourcecar", sourcecar));
            cmd.Parameters.Add(new SqlParameter("@paintcodes", paintcodes));
            cmd.Parameters.Add(new SqlParameter("@taxCat", taxCat));
            cmd.Parameters.Add(new SqlParameter("@operations", operations));
            cmd.Parameters.Add(new SqlParameter("@buycar", buycar));
            cmd.Parameters.Add(new SqlParameter("@sellcar", sellcar));
            cmd.Parameters.Add(new SqlParameter("@printinvoice", printinvoice));
            cmd.Parameters.Add(new SqlParameter("@customers", customers));
            cmd.Parameters.Add(new SqlParameter("@carMain", carMain));
            cmd.Parameters.Add(new SqlParameter("@searchMain", searchMain));
            cmd.Parameters.Add(new SqlParameter("@search", search));
            cmd.Parameters.Add(new SqlParameter("@Reports", Reports));
            cmd.Parameters.Add(new SqlParameter("@rpt", rpt));
            cmd.Parameters.Add(new SqlParameter("@systemMange", systemMange));
            cmd.Parameters.Add(new SqlParameter("@sysinfo", sysinfo));
            cmd.Parameters.Add(new SqlParameter("@usersettings", usersettings));
            cmd.Parameters.Add(new SqlParameter("@MyAcc", MyAcc));
            cmd.Parameters.Add(new SqlParameter("@pExit", pExit));
            cmd.Parameters.Add(new SqlParameter("@admin", admin));





            con.Open();

            return cmd.ExecuteNonQuery();
        }


        public int DeleteUser(int unum)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("delete from Users where user_id=@unum", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@unum", unum));


            DataBase d = new DataBase();
            con.Open();


            int y = this.checkexist(unum);
            if (y > 0)
                return cmd.ExecuteNonQuery();
            
            else
                return -1;

          


        }

        public int DeleteUserPermissions(int unum)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("delete from User_permission where user_id=@unum", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@unum", unum));



            con.Open();

                return cmd.ExecuteNonQuery();

          



        }

        public DataTable ViewUserper(int id)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from User_permission where user_id=@id", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", id); //store data in parametageers to prevent sql injection (get from Password textbox)

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }


        public int AddUser(int unum, string username, string password)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("INSERT INTO users(user_id,user_name , password) VALUES(@unum,@un,@psd)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@unum", unum));
            cmd.Parameters.Add(new SqlParameter("@un", username));
            cmd.Parameters.Add(new SqlParameter("@psd", password));





            con.Open();
        
            int y = this.checkexist(unum);
            if (y <= 0)
                return cmd.ExecuteNonQuery();

            else
                return -1;

        }

        public int checkexist(int unum)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from users where user_id=@unum", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@unum", unum);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }


        public int UpdateUserinfo(int uid, string username, string password, string new_password)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("UPDATE users set user_name=@uname , password=@new_pass where user_id=@user_id and password=@password ", con); ; // sql command to so get data from data base


            cmd.Parameters.Add(new SqlParameter("@user_id", uid));
            cmd.Parameters.Add(new SqlParameter("@uname", username));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@new_pass", new_password));



            con.Open();

            return cmd.ExecuteNonQuery();
        }

       

        public DataSet viewLogo(int id)
        {

            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("select logo from SystemInfo", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", id); //store data in parameters to prevent sql injection (get from Password textbox)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataSet dt = new System.Data.DataSet();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public int updatesysinfo(string id, string email, string mobile, string address)
        {
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET email=@email , mobile=@phone , address=@adres ,   where id=@id ", con);

            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@adres", address));
            cmd.Parameters.Add(new SqlParameter("@phone", mobile));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            con.Open();
            return cmd.ExecuteNonQuery();
        }


        public int changesysinfo(string oldid, string newid, string newname, string year)
        {
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET id=@newid , name=@newname , activeyear=@ayear where id=@oldid ", con);          
            cmd.Parameters.Add(new SqlParameter("@oldid", oldid));
            cmd.Parameters.Add(new SqlParameter("@newid", newid));
            cmd.Parameters.Add(new SqlParameter("@newname", newname));
            cmd.Parameters.Add(new SqlParameter("@ayear", year));
            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public int updatelicence(int id, string start, string end)
        {
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET licencefrom=@start , licenceto=@end where id=@id  ", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@start", start));
            cmd.Parameters.Add(new SqlParameter("@end", end));     
            con.Open();
            return cmd.ExecuteNonQuery();
        }

       

       

        public DataTable search(string parameteresearch , int method , DateTime from , DateTime to)
        {
            SqlCommand cmd = null; 
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            if (method == 0) // by vin
            { 
           cmd = new SqlCommand(" select vin as 'Car Vin ' , concat (makeModel ,  ' ',color,  ' ' , years ) as 'Car info' , CarSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '  from  Cars where vin=@vin", con); // sql command to so get data from data base
            }

            else if (method == 1 ) // by make model 
            {
                cmd = new SqlCommand(" select vin as 'Car Vin ' , concat (makeModel ,  ' ',color,  ' ' , years ) as 'Car info' , CarSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '  from  Cars where makeModel=@vin", con); // sql command to so get data from data base
            }  

            else if (method == 2 )
            {
                 qry = "select vin as 'Car Vin ' , concat(makeModel, ' ', color, ' ', years) as 'Car info' , CarSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '  from Cars " + parameteresearch ; 
               cmd = new SqlCommand(qry, con); // sql command to so get data from data base

            }

           
         
            cmd.Parameters.AddWithValue("@vin", parameteresearch);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public DataTable ReportSerach( int reportserial , string version , DateTime dtf, DateTime dtt)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);

            SqlCommand cmd = null;

            if (reportserial == 0 && version.ToString()==Resources.AZversion )
            {
               
                cmd = new SqlCommand("select vin as 'Car Vin ' , concat (makeModel , ' ' , years , ' ' , color ) as 'Car info' , carSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '   from Cars where datein >= @dtf and datein <=@dtt ", con); // sql command to so get data from data base
            }

            else if (reportserial == 1 && version.ToString() == Resources.AZversion )
            {
             
                cmd = new SqlCommand("select vin as 'Car Vin ' , carinfo as 'Car info' , purchPrice as 'Purchase Price' ,services as 'Services' ,tax as 'Tax',  totalprice as 'Total Price' , date as 'Selled in' from SellTransactions where (date >= @dtf and date <=@dtt) ", con); // sql command to so get data from data base
            }

            else if (reportserial == 2 && version.ToString() == Resources.AZversion)
            {
             
                cmd = new SqlCommand("select vin as 'Car Vin ' , carinfo as 'Car info' , purchPrice as 'Purchase Price' ,services as 'Services' ,tax as 'Tax',  totalprice as 'Total Price' , date as 'Selled in' from SellTransactions where sellPayMethod=1 and (date >= @dtf and date <=@dtt)  ", con); // sql command to so get data from data base
            }

            else if (reportserial == 3 && version.ToString() == Resources.AZversion)
            {
                
                cmd = new SqlCommand("select vin as 'Car Vin ' , carinfo as 'Car info' , purchPrice as 'Purchase Price' ,services as 'Services' ,tax as 'Tax',  totalprice as 'Total Price' , date as 'Selled in' from SellTransactions where sellPayMethod=2 and (date >= @dtf and date <=@dtt) ", con);  // sql command to so get data from data base
            }

            else if (reportserial == 4 && version.ToString() == Resources.AZversion)
            {
                
                cmd = new SqlCommand("select vin as 'Car Vin ' , concat (makeModel , ' ' , years , ' ' , color ) as 'Car info' , carSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '   from Cars  where carStatus=0 or carStatus=1 and (datein >= @dtf and datein <=@dtt) ", con); // sql command to so get data from data base
            }

            else if (reportserial == 5 && version.ToString() == Resources.AZversion)
            {
               
                cmd = new SqlCommand("select vin as 'Car Vin ' , concat (makeModel , ' ' , years , ' ' , color ) as 'Car info' , carSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '   from Cars  where carStatus=0 or carStatus=1 and PayType=1 and (datein >= @dtf and datein <=@dtt) ", con); // sql command to so get data from data base
            }

            else if (reportserial == 6 && version.ToString() == Resources.AZversion)
            {
               
                cmd = new SqlCommand("select vin as 'Car Vin ' , concat (makeModel , ' ' , years , ' ' , color ) as 'Car info' , carSttext as 'Car Status' , scar as 'Source of Purchase' , price as 'Price' , datein as 'Date in' , Millages as 'Millages' , pmtext as 'Purchase Payment Method '   from Cars  where ( carStatus=0 or carStatus=1 ) and PayType=2 and (datein >= @dtf and datein <=@dtt) ", con); // sql command to so get data from data base
            }

            if (reportserial == 7 && version.ToString() == Resources.AZversion )
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption' , trnsDate as 'Transaction Date' from TransActions where (trnsDate >= @dtf and trnsDate <=@dtt)  ", con); // sql command to so get data from data base
            }

            if (reportserial == 8 && version.ToString() == Resources.AZversion)
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption', trnsDate as 'Transaction Date' from TransActions where transType=0 and (trnsDate >= @dtf and trnsDate <=@dtt)", con); // sql command to so get data from data base
            }

            if (reportserial == 9 && version.ToString() == Resources.AZversion)
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption' , trnsDate as 'Transaction Date' from TransActions where transType=0 and payType=1 and (trnsDate >= @dtf and trnsDate <=@dtt)", con);
            }

            if (reportserial == 10 && version.ToString() == Resources.AZversion)
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption' , trnsDate as 'Transaction Date' from TransActions where transType=0 and payType=2 and (trnsDate >= @dtf and trnsDate <=@dtt)", con);
            }


            if (reportserial == 11 && version.ToString() == Resources.AZversion)
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption', trnsDate as 'Transaction Date'  from TransActions where transType=1 and (trnsDate >= @dtf and trnsDate <=@dtt)", con);
            }

            if (reportserial == 12 && version.ToString() == Resources.AZversion )
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption' , trnsDate as 'Transaction Date' from TransActions where transType=1 and payType=1 and (trnsDate >= @dtf and trnsDate <=@dtt)", con);
            }

            if (reportserial == 13 && version.ToString() == Resources.AZversion )
            {
                cmd = new SqlCommand("select transNo as 'Tranaction No ' , Vin as 'Vin No' , transValue as 'Transaction Value' , transDesc as 'Transaction Descryption' , trnsDate as 'Transaction Date'  from TransActions where transType=1 and payType=2 and (trnsDate >= @dtf and trnsDate <=@dtt)", con);
            }

            if ((reportserial == 14 ||  reportserial == 1 ) && (version.ToString() == Resources.AZversion || version.ToString() == Resources.JordanCleaningVersion))
            {
                cmd = new SqlCommand("select vin as 'Vin No' , Servcost as 'Service Cost' , serdesc as 'Service Descryption ' , servdate as 'Service Date'  from TransServices where (servdate >= @dtf and servdate <=@dtt)", con);
            }

            if ((reportserial == 15 || reportserial == 3) && (version.ToString() == Resources.AZversion || version.ToString() == Resources.JordanCleaningVersion))
            {
                cmd = new SqlCommand("select custid as 'Customer ID' , custname as 'Customer Name' , liceNo as 'License No.' ,   mobilenum as 'Mobile Number' , note as 'Address'  from customersInfo ", con);
            }

            if (reportserial ==0  &&  version.ToString() == Resources.JordanCleaningVersion)
            {
                cmd = new SqlCommand(" select trans_id as 'Invoice No.' , cust_id as ' Customer ID' , cust_name as ' Customer Name' , carvin as 'Car Vin' , trans_date as 'Test Date' , concat (makeModel ,' ' , years , ' ' , color ) as 'Car Details ' , payment as 'Payment' , tax as 'Tax Value' , totalpay as 'Total Payment'  from CarTest  where (trans_date >= @dtf and trans_date <=@dtt) ", con);
            }
           
            if (reportserial == 2 && version.ToString() == Resources.JordanCleaningVersion)
            {
                cmd = new SqlCommand("SELECT trans_id  as 'Invoice ID ' ,  carvin as 'Car VIN', trans_date as 'Date', tax as 'Tax' , name  ,   address  , mobile   FROM CarTest ,SystemInfo where trans_date  >= @dtf  and trans_date  <=@dtt  ", con);
            }
           

            
            cmd.Parameters.AddWithValue("@dtf", dtf);
            cmd.Parameters.AddWithValue("@dtt", dtt);
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public DataTable FatoraView(string vin)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
                                                                          /// SqlCommand cmd = new SqlCommand("SELECT  * FROM SellTransactions RIGHT JOIN customersInfo ON SellTransactions.custid = customersInfo.custid where SellTransactions.VIN=@vin ; ", con); // sql command to so get data from data base
            SqlCommand cmd = new SqlCommand("select * from  SellTransactions where VIN=@vin ", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@vin", vin);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public DataTable DataSourceReportBuilder(int ConditionalOrNotorFatoora , string table_name , string condition )
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            string qry = "";
         
            if (ConditionalOrNotorFatoora == 0 )
            {
                //NormalReport
                qry = " Select * from  " + table_name ;
            }
            else if (ConditionalOrNotorFatoora == 1)
            {
                //ConditionalReport
                qry = " Select * from  " + table_name + " where " + condition;
            }

            else if (ConditionalOrNotorFatoora == 2 )
            {
                //FatoraInvoice
                qry = "Select * from " + table_name + " where " + condition;   //VIN=@vin";
            }


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data base

         

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }


    }
}
