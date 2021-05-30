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
            Operations o = new Operations();
            string table = "ActivationApp";
       
            string condition = "";

       
            DataTable dtable2 = o.SelctData(table, 0, condition);
            int ActiveStatus = int.Parse(dtable2.Rows[0]["Activated"].ToString());
            if (ActiveStatus == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmActivationApp());
            }
            if (ActiveStatus == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());


               
            }

         
          
        }
    }
}
