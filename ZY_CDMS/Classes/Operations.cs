using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZY_CDMS.Classes
{

    class Operations
    {


        Rules r = new Rules();
        public DataTable SelctData(string tablename , int parx , string condition )
        {
            int x = parx;
            //Add Check Exist
      
            string begqry = "select * from ";
            string table_name = tablename;
            string qrycondition = condition;
            string qry = "";


            if (x == 0)
            {
                //Only For Select * 
                qry = "select * from " + table_name;
            }
            else if (x == 1)
            {
                //For Conditional Select 
                qry = begqry + table_name + " where " + qrycondition;
            }

            else if (x == 2)
            {
                //For Conditional Select 
                qry = "select sum(Servcost) as 'Servcost' from " + table_name + " where " + qrycondition;
            }

            SqlConnection con = new SqlConnection(DataBase.connstring);
            SqlCommand cmd = new SqlCommand(qry , con); // sql command to so get data from data base

            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

        }


        public int UploadLogo(string id, byte[] logo)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  

            SqlCommand cmd = new SqlCommand("update SystemInfo set logo = @logo where id =@id", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@logo", logo));
            cmd.Parameters.Add(new SqlParameter("@id", id));



            con.Open();

            return cmd.ExecuteNonQuery();
        }


        public int updatesysinfo(string id, string email, string mobile, string address , string tax)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET email=@email , mobile=@phone , address=@adres , tax_no=@tax   where id=@id ", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@adres", address));
            cmd.Parameters.Add(new SqlParameter("@phone", mobile));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            cmd.Parameters.Add(new SqlParameter("@tax", tax));



            con.Open();
            return cmd.ExecuteNonQuery();
        }


        public DataSet viewLogo(int id)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("select logo from SystemInfo", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", id); //store data in parameters to prevent sql injection (get from Password textbox)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataSet dt = new System.Data.DataSet();
            sda.Fill(dt);

            con.Open();
            return dt;

        }

        public DataSet viewLogo(string vin , char im)
        {
            SqlCommand cmd = null; 
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
           if (im == 'A')
                 cmd = new SqlCommand("select ImageA from CarTest where carvin=@vin", con); // sql command to so get data from data base
           else if (im == 'B')
                 cmd = new SqlCommand("select ImageB from CarTest where carvin=@vin", con); // sql command to so get data from data base
          
           else if (im == 'C')
                 cmd = new SqlCommand("select ImageC from CarTest where carvin=@vin", con); // sql command to so get data from data base

           else if (im == 'D')
                 cmd = new SqlCommand("select ImageD from CarTest where carvin=@vin", con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@vin", vin); //store data in parameters to prevent sql injection (get from Password textbox)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataSet dt = new System.Data.DataSet();
            sda.Fill(dt);

            con.Open();
            return dt;

        }


        public int AddCAR(int transNo, int transType, int PayType, string VIN, string makeModel, string color, string years, string Millages, DateTime datein, double price, int crst, string crsttext, string scar, string pmtext)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO Cars (transNo,transType,PayType,VIN,color,years,Millages,datein,price,carStatus , carSttext ,  makeModel ,  scar ,  pmtext) VALUES(@transNo, @transType, @PayType, @VIN, @color, @years, @Millages, @datein, @price, @crst, @carSttext,@makeModel , @scar, @pmtext)", con);

            cmd.Parameters.Add(new SqlParameter("@transNo", transNo));
            cmd.Parameters.Add(new SqlParameter("@transType", transType));
            cmd.Parameters.Add(new SqlParameter("@PayType", PayType));
            cmd.Parameters.Add(new SqlParameter("@VIN", VIN));
       
            cmd.Parameters.Add(new SqlParameter("@color", color));
            cmd.Parameters.Add(new SqlParameter("@years", years));
            cmd.Parameters.Add(new SqlParameter("@Millages", Millages));
            cmd.Parameters.Add(new SqlParameter("@datein", datein));
            cmd.Parameters.Add(new SqlParameter("@price", price));
        
            cmd.Parameters.Add(new SqlParameter("@crst", crst));
            cmd.Parameters.Add(new SqlParameter("@carSttext", crsttext));
         
            cmd.Parameters.Add(new SqlParameter("@makeModel", makeModel));
            cmd.Parameters.Add(new SqlParameter("@scar", scar));
            cmd.Parameters.Add(new SqlParameter("@pmtext", pmtext));


           
            string condition = "VIN=" + "'" + @VIN + "'";

            con.Open();
        
            int y = r.checkexist("Cars" , 1 , condition);
            if (y <= 0)
                return cmd.ExecuteNonQuery();
            else
                return -1;

        }

        public int newTransaction(int transNo, int transType, string VIN, double transValue, int payType, string transDesc, DateTime date)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO TransActions (transNo,transType,VIN, transValue , payType , transDesc , trnsDate) VALUES(@transNo,@transType,@vin , @transValue , @payType, @transDesc , @trnsDate)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@transNo", transNo));
            cmd.Parameters.Add(new SqlParameter("@transType", transType));
            cmd.Parameters.Add(new SqlParameter("@vin", VIN));
            cmd.Parameters.Add(new SqlParameter("@transValue", transValue));
            cmd.Parameters.Add(new SqlParameter("@payType", payType));
            cmd.Parameters.Add(new SqlParameter("@transDesc", transDesc));
            cmd.Parameters.Add(new SqlParameter("@trnsDate", date));





            con.Open();

            return cmd.ExecuteNonQuery();


        }

        public int newSellTransaction(int transNo, int transType, DateTime date, string vin, int sellPayMethod, double purchPrice, double services, double tax, double totalPrice, string carinfo, string custno, string custname, string addr, string mob , string paymethodtext )
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO SellTransactions (transNo,transType,date, vin , sellPayMethod , purchPrice , services , tax , totalPrice , carinfo , custid , custname , custaddress , custmob , paymethodtext) VALUES(@transNo,@transType,@date, @vin , @sellPayMethod , @purchPrice , @services , @tax , @totalPrice , @carinfo , @custno ,@custname , @custaddress , @custmob , @paymethodtext)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@transNo", transNo));
            cmd.Parameters.Add(new SqlParameter("@transType", transType));
            cmd.Parameters.Add(new SqlParameter("@date", date));
            cmd.Parameters.Add(new SqlParameter("@vin", vin));
            cmd.Parameters.Add(new SqlParameter("@sellPayMethod", sellPayMethod));
            cmd.Parameters.Add(new SqlParameter("@purchPrice", purchPrice));
            cmd.Parameters.Add(new SqlParameter("@services", services));
            cmd.Parameters.Add(new SqlParameter("@tax", tax));
            cmd.Parameters.Add(new SqlParameter("@totalPrice", totalPrice));//carinfo
            cmd.Parameters.Add(new SqlParameter("@carinfo", carinfo));//carinfo
            cmd.Parameters.Add(new SqlParameter("@custno", custno));//carinfo
            cmd.Parameters.Add(new SqlParameter("@custname", custname));//carinfo
            cmd.Parameters.Add(new SqlParameter("@custaddress", addr));//carinfo
            cmd.Parameters.Add(new SqlParameter("@custmob", mob));//carinfo
            cmd.Parameters.Add(new SqlParameter("@paymethodtext", paymethodtext));

            Operations o = new Operations();
             string condition = "VIN=" + "'" + @vin + "'";
            con.Open();
            DataTable dt = o.SelctData("Cars", 1, condition);
            int so = int.Parse(dt.Rows[0]["carStatus"].ToString());
            if (so == 0)
                return cmd.ExecuteNonQuery();
            else
                return -1;

        }

        public int updatecarStatus(string vin, int status, string carSttext)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring);
            SqlCommand cmd = new SqlCommand("update Cars set carStatus=@crst , carSttext=@carSttext  where VIN =@vin", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@crst", status));
            cmd.Parameters.Add(new SqlParameter("@vin", vin));
            cmd.Parameters.Add(new SqlParameter("@carSttext", carSttext));






            con.Open();

            return cmd.ExecuteNonQuery();


        }

        public int newService(int servid, double servcost, string vin, string serdesc, DateTime sdate , int tr_id)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO TransServices ( Servid , Servcost , vin , serdesc , servdate , trans_id) VALUES(@srid , @srcost, @vin , @serdesc , @sdate , @trans_id)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@srid", servid));
            cmd.Parameters.Add(new SqlParameter("@srcost", servcost));
            cmd.Parameters.Add(new SqlParameter("@vin", vin));
            cmd.Parameters.Add(new SqlParameter("@serdesc", serdesc));
            cmd.Parameters.Add(new SqlParameter("@sdate", sdate));
            cmd.Parameters.Add(new SqlParameter("@trans_id", tr_id));

           





            con.Open();

            return cmd.ExecuteNonQuery();


        }


    public int AddCustomer(string custid, string custname, string licenseno, string mobile, string note)
    {

        SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
        SqlCommand cmd = new SqlCommand("INSERT INTO customersInfo (custid , custname , liceNo , mobilenum ,note) VALUES(@custid , @custname , @liceNo , @mobilenum ,@note)", con); // sql command to so get data from data bas

        cmd.Parameters.Add(new SqlParameter("@custid", custid));
        cmd.Parameters.Add(new SqlParameter("@custname", custname));
        cmd.Parameters.Add(new SqlParameter("@liceNo", licenseno));
        cmd.Parameters.Add(new SqlParameter("@mobilenum", mobile));
        cmd.Parameters.Add(new SqlParameter("@note", note));



            string condition = "custid=" + "'" + @custid + "'";
            con.Open();

            int y = r.checkexist("customersInfo", 1, condition);
            if (y <= 0)
                return cmd.ExecuteNonQuery();
            else
                return -1;



        }

        public int UpdateCustomer(string custid, string custname, string licenseno, string mobile, string note)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("Update customersInfo set custname=@custname ,liceNo=@liceNo , mobilenum=@mobilenum ,note=@note where custid=@custid ", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@custid", custid));
            cmd.Parameters.Add(new SqlParameter("@custname", custname));
            cmd.Parameters.Add(new SqlParameter("@liceNo", licenseno));
            cmd.Parameters.Add(new SqlParameter("@mobilenum", mobile));
            cmd.Parameters.Add(new SqlParameter("@note", note));




            con.Open();
            return cmd.ExecuteNonQuery();



        }

        public int UpdateCustomerinfatora(string custid, string custname, string licenseno, string mobile, string note)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("Update SellTransactions set custname=@custname  , custaddress=@note , custmob=@mobilenum where custid=@custid ", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@custid", custid));
            cmd.Parameters.Add(new SqlParameter("@custname", custname));
            cmd.Parameters.Add(new SqlParameter("@liceNo", licenseno));
            cmd.Parameters.Add(new SqlParameter("@mobilenum", mobile));
            cmd.Parameters.Add(new SqlParameter("@note", note));




            con.Open();
            return cmd.ExecuteNonQuery();



        }
        
        public int AddCarTest(int tran_id, int transtype, string custid, string custname, string mobile, string vin, DateTime transDate, string MakeModel, string year, string color, string paintCode, int payment, int balance, string carDirty, string carClean, string RepairDescription, float tax, float total)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO CarTest ( trans_id ,  trans_type ,  cust_id,  cust_name,  cust_mobile,  carvin  ,  trans_date ,  makeModel , years , color ,  paintCode ,  payment, balance , carDirty,  carClean,  RepairDescription , tax , totalpay) VALUES(@tran_id ,  @transtype ,  @custid,  @custname,  @mobile,  @vin  ,  @transDate ,  @MakeModel , @year , @color ,  @paintCode ,  @payment,  @balance,  @carDirty,  @carClean,  @RepairDescription , @tax , @total)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@tran_id", tran_id));
            cmd.Parameters.Add(new SqlParameter("@transtype", transtype));
            cmd.Parameters.Add(new SqlParameter("@custid", custid));
            cmd.Parameters.Add(new SqlParameter("@custname", custname));
            cmd.Parameters.Add(new SqlParameter("@mobile", mobile));
            cmd.Parameters.Add(new SqlParameter("@vin", vin));
            cmd.Parameters.Add(new SqlParameter("@transDate", transDate));
            cmd.Parameters.Add(new SqlParameter("@MakeModel", MakeModel));
            cmd.Parameters.Add(new SqlParameter("@year", year));
            cmd.Parameters.Add(new SqlParameter("@color", color));
            cmd.Parameters.Add(new SqlParameter("@paintCode", paintCode));
            cmd.Parameters.Add(new SqlParameter("@payment", payment));
            cmd.Parameters.Add(new SqlParameter("@balance", balance));

            cmd.Parameters.Add(new SqlParameter("@carDirty", carDirty));
            cmd.Parameters.Add(new SqlParameter("@carClean", carClean));
            cmd.Parameters.Add(new SqlParameter("@RepairDescription", RepairDescription));
            cmd.Parameters.Add(new SqlParameter("@tax", tax));
            cmd.Parameters.Add(new SqlParameter("@total", total));


            con.Open();
            return cmd.ExecuteNonQuery();



        }

        public int UploaDCarTestImages(string vin, byte[] A, byte[] B, byte[] C, byte[] D)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  

            SqlCommand cmd = new SqlCommand("update CarTest set ImageA =@A  , ImageB=@B  , ImageC =@C , ImageD =@D where carvin =@vin", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@A", A));
            cmd.Parameters.Add(new SqlParameter("@B", B));
            cmd.Parameters.Add(new SqlParameter("@C", C));
            cmd.Parameters.Add(new SqlParameter("@D", D));

            cmd.Parameters.Add(new SqlParameter("@vin", vin));



            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public int UpdateVersion(string version)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  

            SqlCommand cmd = new SqlCommand("update SystemInfo set version=@version", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@version", version));




            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public int updatelicence(int id, string start, string end)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET licencefrom=@start , licenceto=@end where id=@id  ", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Parameters.Add(new SqlParameter("@start", start));
            cmd.Parameters.Add(new SqlParameter("@end", end));

            // cmd.Parameters.Add(new SqlParameter("@ut", usertype));

            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public int changesysinfo(string oldid, string newid, string newname, string year)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE SystemInfo SET id=@newid , name=@newname , activeyear=@ayear where id=@oldid ", con); // sql command to so get data from data bas


            cmd.Parameters.Add(new SqlParameter("@oldid", oldid));
            cmd.Parameters.Add(new SqlParameter("@newid", newid));
            cmd.Parameters.Add(new SqlParameter("@newname", newname));
            cmd.Parameters.Add(new SqlParameter("@ayear", year));


            con.Open();
            return cmd.ExecuteNonQuery();
        }
    }


}