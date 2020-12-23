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
                qry = "selct * from " + tablename;
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

    }
}
