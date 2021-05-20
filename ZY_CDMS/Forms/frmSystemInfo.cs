using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmSystemInfo : Form
    {
        public frmSystemInfo()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        string table = "SystemInfo";
        string imglocation = "";

        private void frmSystemInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmSystemInfo_Load(object sender, EventArgs e)
        {
            string condition = "";

            DataTable dtable = o.SelctData(table, 0, condition);


            txt_comno.Text = dtable.Rows[0]["id"].ToString();
            txt_comname.Text = dtable.Rows[0]["name"].ToString();
            txt_address.Text = dtable.Rows[0]["address"].ToString();
            txt_email.Text = dtable.Rows[0]["email"].ToString();
            txt_mobile.Text = dtable.Rows[0]["mobile"].ToString();
            txt_datefrom.Text = dtable.Rows[0]["licencefrom"].ToString();
            txt_dateto.Text = dtable.Rows[0]["licenceto"].ToString();
            txt_activeyear.Text = dtable.Rows[0]["activeyear"].ToString();
            int version = int.Parse(dtable.Rows[0]["version"].ToString());
            txt_version.Text = version.ToString();
            txt_taxno.Text = dtable.Rows[0]["tax_no"].ToString();

           
            DataSet ds = o.viewLogo(1);

            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["logo"]);
            pictureBox1.Image = new Bitmap(ms);

            DateTime dt = DateTime.Parse(dtable.Rows[0]["licenceto"].ToString());
            DateTime dt1 = DateTime.Parse(dtable.Rows[0]["licencefrom"].ToString());
            string titleform = dtable.Rows[0]["name"].ToString();
            TimeSpan t = dt - dt1;
            double NrOfDays = t.TotalDays;



            

            if (NrOfDays > 30)
            {
                Licence.Visible = true;
                Licence.ForeColor = Color.Black;
                //  days.Visible = false;
               
                Licence.Text = "Licenced for ( " + " " + titleform.ToString() + " )";

            }
            if (NrOfDays <= 30)
            {
                Licence.Visible = true;
                Licence.ForeColor = Color.Red;
                Licence.Text = "Licenced for ( " + " " + titleform.ToString() + " )" + " licence will be ended by " + " " + NrOfDays.ToString() + " " + "Days";
                //  days.Visible = true;
                
            }
            if (NrOfDays <= 0)
            {
                Licence.Visible = true;
                Licence.ForeColor = Color.Red;
                Licence.Text = "Licenced for ( " + " " + titleform.ToString() + " )" + "Licence ended in " + " " + dt.ToShortDateString();
                // days.Visible = false;


            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Information Will be updated ? ", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_mobile.Text) || string.IsNullOrEmpty(imglocation.ToString()))
                {
                    MessageBox.Show(Resources.invalidData, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {

                    byte[] logo = null;
                    FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bre = new BinaryReader(stream);
                    logo = bre.ReadBytes((int)stream.Length);
                    string cid = txt_comno.Text;
                    string tax = txt_taxno.Text;

                    string oemail = txt_email.Text;
                    string omobile = txt_mobile.Text;
                    string oaddress = txt_address.Text;

                   
                    int x = o.updatesysinfo(cid, oemail, omobile, oaddress , tax);
                    int LogoUpload = o.UploadLogo(cid, logo);

                    if (x > 0)
                    {
                        MessageBox.Show(Resources.Updated, Resources.MessageTitle, 0, MessageBoxIcon.Information);
                    }
                    else if (x < 0)
                    {
                        MessageBox.Show("No Changes Happened !!!", Resources.MessageTitle, 0, MessageBoxIcon.Error);
                    }

                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled by User ", Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
            }
        }

        private void Licence_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Devloper")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
               frmDevloper dev = new frmDevloper();
               
                dev.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                imglocation = opnfd.FileName.ToString();
                pictureBox1.Image = new Bitmap(imglocation);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            frmReportViewer rv = null;
            frmReports.selectedReport = 88;
            rv = new frmReportViewer();
            rv.Show();

        }
    }
}
