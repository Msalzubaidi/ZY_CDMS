using System;
using System.Collections.Generic;
using System.Data;
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

     

        public bool ISnullorEmptyRule(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            else
                return false; 
        }


        public bool isCharOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c < 'a'  || c > 'z' ) || (c < 'A' || c > 'Z'))
                    return true;//contain symbols 

            }

            return false; // does not contain char
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
            return dt.Rows.Count + 1 ;

        }

        public int checkexist(string tablename , int parx , string condition)
        {
            int x = parx;

            SqlConnection con = new SqlConnection(DataBase.connstring);
            string begqry = "select * from ";
            string table_name = tablename;
            string qrycondition = condition;
            string qry = "";
            
            if (x == 0)
            {
                //Only For Select * 
                 qry = "selct * from " + tablename ;
            }
            else if (x == 1) 
            {
                //For Conditional Select 
                qry = begqry + table_name + " where " + qrycondition ; 
            }
         
            SqlCommand cmd = new SqlCommand(qry , con); // sql command to so get data from data base


            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt.Rows.Count;

        }

       
    }
}
