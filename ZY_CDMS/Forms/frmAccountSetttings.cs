using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZY_CDMS.Classes;
using ZY_CDMS.Properties;

namespace ZY_CDMS.Forms
{
    public partial class frmAccountSetttings : Form
    {
        public frmAccountSetttings()
        {
            InitializeComponent();
        }

        SysSettings s = new SysSettings();


        private void frmAccountSetttings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_oldpass.Text) || string.IsNullOrWhiteSpace(txt_newpass.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_newpass.Clear();
                txt_oldpass.Clear();
                txt_username.Clear();
                txt_userid.Text = DataBase.Unum.ToString();
                txt_username.Text = DataBase.Username.ToString();
            }
            else
            {
              

                int id = int.Parse(txt_userid.Text);
                string usern = txt_username.Text;
                string opass = txt_oldpass.Text;
                string npass = txt_newpass.Text;

                int rest = s.UpdateUserinfo(id, usern, opass, npass);

                if (rest > 0)
                {
                    MessageBox.Show("Account Info Updated ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
                    txt_username.Clear();
                    txt_userid.Text = DataBase.Unum.ToString();
                    txt_username.Text = DataBase.Username.ToString();

                }

                else if (rest <= 0)
                {
                    MessageBox.Show("Invalid Password", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
                    txt_userid.Text = DataBase.Unum.ToString();
                    txt_username.Text = DataBase.Username.ToString();

                }

                else
                {
                    MessageBox.Show("Please Try Again", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_newpass.Clear();
                    txt_oldpass.Clear();
                    txt_userid.Text = DataBase.Unum.ToString();
                    txt_username.Text = DataBase.Username.ToString();

                }
            }
        }

        private void frmAccountSetttings_Load(object sender, EventArgs e)
        {
            txt_userid.Text = DataBase.Unum.ToString();
            txt_username.Text = DataBase.Username.ToString();
        }
    }
}
