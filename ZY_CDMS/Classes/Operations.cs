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
    }


}