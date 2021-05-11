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

namespace ZY_CDMS
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        SqlConnection con; 

        SqlCommand cmd;

        SqlDataReader dr;


        private void frmBackup_Load(object sender, EventArgs e)
        {
            serverName(".");
        }

        public void serverName(string str)

        {

            con = new SqlConnection(DataBase.connstring);

            con.Open();

            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                ComboBoxserverName.Items.Add(dr[2]);

            }

            dr.Close();

        }

        public void Createconnection()

        {

            con = new SqlConnection(DataBase.connstring);

            con.Open();

          //  ComboBoxDatabaseName.Items.Clear();

            cmd = new SqlCommand("select * from sysdatabases", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())

            {

        
            }

            dr.Close();

        }

        public void query(string que)

        {

            // ERROR: Not supported in C#: OnErrorStatement



            cmd = new SqlCommand(que, con);

            cmd.ExecuteNonQuery();

        }


        public void blank(string str)

        {

            if (string.IsNullOrEmpty(ComboBoxserverName.Text) | string.IsNullOrEmpty(ComboBoxDatabaseName.Text))

            {

                // label3.Visible = true;

              
                MessageBox.Show("Server Name & Database can not be Blank ", Resources.MessageTitle, 0, MessageBoxIcon.Warning);

                return;

            }

            else

            {

                if (str == "backup")

                {

                    SaveFileDialog1.FileName = ComboBoxDatabaseName.Text;

                    SaveFileDialog1.ShowDialog();

                    string s = null;

                    s = SaveFileDialog1.FileName;

                    query("Backup database " + ComboBoxDatabaseName.Text + " to disk='" + s + "'");



                    MessageBox.Show("Backup Database Executed Successfully  ", Resources.MessageTitle, 0, MessageBoxIcon.Information);

                }

            }
        }

       



        private void cmbserver_SelectedIndexChanged(object sender, EventArgs e)

        {

            Createconnection();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            blank("backup");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
