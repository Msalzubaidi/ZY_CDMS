using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZY_CDMS.Classes;

namespace ZY_CDMS.Classes
{
    class Rules
    {
        SqlConnection con = new SqlConnection(DataBase.connstring);



        public bool isDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;//contain char 

            }

            return true; // does not contain char
        }

        public int FindMax(string table_name)
        {
            SqlConnection con = new SqlConnection(DataBase.connstring);
            string qry = "select * from " + table_name;


            SqlCommand cmd = new SqlCommand(qry, con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@t_name", table_name);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

        public int checkexist(string parameter , string tablename , int x , string condition)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring);
            string qry = "";
            
            if (x == 0)
            {
              //   qry = "selct * from " + tablename + " where " + parameter + " =@"+;
            }
            else if (x == 1) 
            {
                qry = "";
            }
         
            SqlCommand cmd = new SqlCommand(qry , con); // sql command to so get data from data base


            cmd.Parameters.AddWithValue("@unum", parameter);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }
    }
}
