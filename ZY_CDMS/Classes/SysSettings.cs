using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Classes
{
    class SysSettings
    {

        Rules r = new Rules();
        public int AddBrand(int bnum, string bname, string bmodel , string table_name )
        {
            
            SqlConnection con = new SqlConnection(DataBase.connstring);
            SqlCommand cmd = new SqlCommand("INSERT INTO Brands(bnum , bname , bmodel) VALUES(@bnum,@bname , @bmodel)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@bnum", bnum));
            cmd.Parameters.Add(new SqlParameter("@bname", bname));
            cmd.Parameters.Add(new SqlParameter("@bmodel", bmodel));

            string condition = "bname=" + "'" + @bname + "'" + " and " + "bmodel=" + "'"+ @bmodel + "'";


            con.Open();
            
            int x = r.checkexist(table_name , 1 , condition); // if exist return -1 ; 
            if (x > 0)
                return -1;
            else
                return cmd.ExecuteNonQuery();
        }

        public int UpdateBrand(int bnum, string bname, string bmodel , string table)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring);
            SqlCommand cmd = new SqlCommand("UPDATE Brands set bname=@bname , bmodel=@bmodel where bnum=@bnum", con); ; // sql command to so get data from data base


            cmd.Parameters.Add(new SqlParameter("@bnum", bnum));
            cmd.Parameters.Add(new SqlParameter("@bname", bname));
            cmd.Parameters.Add(new SqlParameter("@bmodel", bmodel));

            string condition = "bname=" + "'" + @bname + "'" + " and " + "bmodel=" + "'" + @bmodel + "'";
            con.Open();
            
            int x = r.checkexist(table, 1, condition); // if exist return -1 ; 
            if (x > 0)
                return -1;

            else
                return cmd.ExecuteNonQuery();
        }
        public int AddService(int sid, string sname, int scost)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); 
            SqlCommand cmd = new SqlCommand("INSERT INTO Services(id ,name , cost) VALUES(@sid,@sname , @scost)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@sid", sid));
            cmd.Parameters.Add(new SqlParameter("@sname", sname));
            cmd.Parameters.Add(new SqlParameter("@scost", scost));



            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public int UpdateService(int id, string name, int cost)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("UPDATE Services set name=@name , cost=@cost where id=@id", con); ; // sql command to so get data from data base


            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@cost", cost));


            con.Open();

            return cmd.ExecuteNonQuery();
        }

        public int AddPM(int id, string name , string table)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO PayMethods(id,name) VALUES(@id,@name)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Parameters.Add(new SqlParameter("@name", name));

           
            string condition = "name=" + "'" + @name + "'"  ;

            con.Open();
            
            int x = r.checkexist(table , 1 , condition); // if exist return -1 ; 
            if (x > 0)
                return -1;
            else
                return cmd.ExecuteNonQuery();
        }

        public int AddSOC(int id, string name ,  string table)
        {

            SqlConnection con = new SqlConnection(DataBase.connstring); // making connection  
            SqlCommand cmd = new SqlCommand("INSERT INTO SourceCar(id,name) VALUES(@id,@name)", con); // sql command to so get data from data bas

            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Parameters.Add(new SqlParameter("@name", name));


            string condition = "name=" + "'" + @name + "'";
            con.Open();
            Settings s = new Settings();
            int x = r.checkexist(table , 1 , condition); // if exist return -1 ; 
            if (x > 0)
                return -1;
            else
                return cmd.ExecuteNonQuery();
        }
    }
}
