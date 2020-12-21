using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZY_CDMS.Classes
{
    class DataBase
    {
        /* public static string servercon=Connection.s;
          public static string dbnamecon=Connection.dbn;
          public static string usernamecon=Connection.un;
          public static string passwordcon=Connection.ps;
          */

      

        public static string servercon = "MZUBAIDI"; //ZYTECH
        public static string dbnamecon = "Auto2020";
        public static string usernamecon = "sa";
        public static string passwordcon = "1";
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

        public DataTable ViewUserper(int id)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from User_permission where userid=@id", con); // sql command to so get data from data base

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

        public DataTable userpermession(int uid)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("select * from User_permission where userid=@id", con); // sql command to so get data from data base

            cmd.Parameters.AddWithValue("@id", uid); //store data in parameters to prevent sql injection (get from Password textbox)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            con.Open();
            return dt;

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

        public DataTable ViewActivateInfo()
        {
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(" Select * from ActivationApp ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            con.Open();
            return dt;
        }

        public int Activate()
        {
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("update ActivationApp set Activated = 1", con);
            con.Open();
            return cmd.ExecuteNonQuery();
        }

    }
}
