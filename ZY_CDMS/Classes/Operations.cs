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

      
            string begqry = "select * from ";
            string table_name = tablename;
            string qrycondition = condition;
            string qry = "";


            if (x == 0)
            {
                //Only For Select * 
                qry = "select * from " + tablename;
            }
            else if (x == 1)
            {
                //For Conditional Select 
                qry = begqry + table_name + " where " + qrycondition;
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

    }
}
