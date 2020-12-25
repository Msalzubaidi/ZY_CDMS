using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Forms;
using ZY_CDMS.Properties;

namespace ZY_CDMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSellCar());
            /*
            
            String table = "ActivationApp";
            Operations o = new Operations();
           DataTable dt = o.SelctData(table , 0 , "");
            if (dt.Rows.Count != 0 )
            {
                int active = int.Parse(dt.Rows[0]["Activated"].ToString());
                if (active == 1)
                { 
                Application.Run(new frmLogin());
                }
                else if (active == 0 )
                {

                    MessageBox.Show(Resources.pleaseActive , Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                    Application.Run(new frmActivationApp());

               
                }
            }
            else
            {
                MessageBox.Show(Resources.activationneeded, Resources.MessageTitle, 0, MessageBoxIcon.Error);
            }
          

            */


        }
    }
}
