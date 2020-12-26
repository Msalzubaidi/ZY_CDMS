﻿using System;
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



namespace ZY_CDMS.Forms
{
    public partial class frmSellCar : Form
    {
        public frmSellCar()
        {
            InitializeComponent();
        }

        Operations o = new Operations();
        Rules r = new Rules();
        SysSettings s = new SysSettings();
        string table = "Cars";
        string TarnsTabletable = "TransActions";
        string cutsTabel = "customersInfo";
        string servicetable = "TransServices";
        string selltable = "SellTransactions";




        public static string nl = "\r\n";

        private void frmSellCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taxper.Text))
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double tax = (double.Parse(txt_price.Text) * (double.Parse(txt_taxper.Text) / 100));
                txt_taxval.Text = tax.ToString();
                txt_discount.Focus();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (r.isDigitsOnly(txt_service.Text) == false ||string.IsNullOrEmpty (txt_service.Text)|| string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_taxper.Text) || string.IsNullOrEmpty(txt_taxval.Text) || string.IsNullOrEmpty(txt_discount.Text) ||  r.isDigitsOnly(txt_discount.Text) == false || r.isDigitsOnly(txt_taxval.Text) == false || r.isDigitsOnly(txt_taxper.Text) == false || r.isDigitsOnly(txt_price.Text) == false)
            {
                MessageBox.Show(Resources.digitOnlyError + " For Price - Service - Discount - Tax ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double price = double.Parse(txt_price.Text);
                double service = double.Parse(txt_service.Text);
                double tax = double.Parse(txt_taxval.Text);
                double discount = double.Parse(txt_discount.Text);
                double total = (price + service + tax) - discount;
                txt_totalprice.Text = total.ToString();
            }


        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_vin.Text))
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                simpleButton2.PerformClick();

            }

            else
            {
                string vin = txt_vin.Text;
                string condition = "vin=" + "'" + @vin + "'";


                DataTable dtable = o.SelctData(table, 1, condition);
                DataTable dtableser = o.SelctData(servicetable, 1, condition);

                if (dtableser != null && dtableser.Rows.Count > 0)
                {                   
                    txt_service.Text = dtableser.Rows[0]["Servcost"].ToString();
                }
                


                    int x = dtable.Rows.Count;


                if (dtable != null && dtable.Rows.Count > 0)
                {

                    int statuscar = int.Parse(dtable.Rows[0]["carStatus"].ToString());
                    if (statuscar > 0)
                    {

                        txt_carinfo.Text = nl + nl + nl + nl + "   CAR ALREADY SELLED     ";

                        dtp_date.Enabled = false;
                        cbo_paymethod.Enabled = false;
                        txt_totalprice.Enabled = false;
                        txt_taxval.Enabled = false;
                        txt_taxper.Enabled = false;
                        txt_service.Enabled = false;
                        txt_price.Enabled = false;
                        txt_custid.Enabled = false;
                        txt_custmobile.Enabled = false;
                        txt_custaddress.Enabled = false;
                        txt_custname.Enabled = false;
                        txt_carinfo.Enabled = false;
                        txt_discount.Enabled = false;
                        simpleButton1.Enabled = false;




                    }

                    else
                    {


                        string bm = dtable.Rows[0]["makeModel"].ToString();

                        string year = dtable.Rows[0]["years"].ToString();
                        string mill = dtable.Rows[0]["Millages"].ToString();
                        string col = dtable.Rows[0]["color"].ToString();

                        double pr = double.Parse(dtable.Rows[0]["price"].ToString());
                        txt_price.Text = pr.ToString();

                        txt_carinfo.Text = nl + "Make - Model : " + bm + nl + "Year : " + year + nl + "Millages : " + mill + nl + "Color :" + col;


                    }
                }


                else
                {
                    MessageBox.Show(table + Resources.notExist, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    simpleButton2.PerformClick();
                }
            }
        }

        private void frmSellCar_Load(object sender, EventArgs e)
        {
            simpleButton2.PerformClick();
            string connstring = @"Data Source=" + Resources.servercon + ";Initial Catalog=" + Resources.dbnamecon + ";User ID=" + Resources.usernamecon + ";Password=" + Resources.passwordcon;
            SqlConnection con3 = new SqlConnection(connstring);
            SqlCommand cmd3;
            SqlDataReader dr3;

            string qry3 = "select* from PayMethods";
            con3.Open();



            cmd3 = new SqlCommand(qry3, con3);
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {

                cbo_paymethod.Properties.Items.Add(dr3.GetValue(1).ToString());

            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Customer")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmAddCustomer ac = new frmAddCustomer();
                ac.Show();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to Close Without Save Data ?  ", Resources.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                this.Close();


            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_transid.Clear();
            txt_vin.Clear();
            dtp_date.EditValue = DateTime.Now;
            cbo_paymethod.EditValue = "";
            txt_totalprice.Text = "0";
            txt_taxval.Text = "0";
            txt_taxper.Text = "0";
            txt_service.Text = "0";
            txt_price.Text = "0";
            txt_custid.Clear();
            txt_custmobile.Clear();
            txt_custaddress.Clear();
            txt_custname.Clear();
            txt_carinfo.Clear();
            txt_discount.Text = "0";
            int v = r.FindMax(table);
            txt_transid.Text = v.ToString();
            txt_vin.Focus();
            dtp_date.Enabled = true;
            cbo_paymethod.Enabled = true;
           
         
            txt_taxper.Enabled = true;
            txt_service.Enabled = true;
            txt_price.Enabled = true;
            txt_custid.Enabled = true;


            txt_discount.Enabled = true;
            simpleButton1.Enabled = true;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vin.Text) || string.IsNullOrEmpty(txt_carinfo.Text) || string.IsNullOrEmpty(txt_custname.Text) || string.IsNullOrEmpty(cbo_paymethod.SelectedItem.ToString() ) || r.isDigitsOnly(txt_service.Text) == false || string.IsNullOrEmpty(txt_service.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_taxper.Text) || string.IsNullOrEmpty(txt_taxval.Text) || string.IsNullOrEmpty(txt_discount.Text) || r.isDigitsOnly(txt_discount.Text) == false || r.isDigitsOnly(txt_taxval.Text) == false || r.isDigitsOnly(txt_taxper.Text) == false || r.isDigitsOnly(txt_price.Text) == false)
            {
                MessageBox.Show(Resources.invalidData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                // MessageBox.Show("All fields are OK ... " , Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                int transno = int.Parse(txt_transid.Text);
                string vinn = txt_vin.Text;
                int transtype = int.Parse(txt_trantype.Text);
                DateTime date = DateTime.Parse(dtp_date.EditValue.ToString());

                int spm = cbo_paymethod.SelectedIndex + 1;
                string pmethod = cbo_paymethod.EditValue.ToString();
                double price = double.Parse(txt_price.Text);
                double ser = double.Parse(txt_service.Text);
                double tax = double.Parse(txt_taxval.Text);
                double total = double.Parse(txt_totalprice.Text);
                int cstat = int.Parse(txt_carstatus.Text);
                string carsttext = "Selled Car";
                string carinfoo = txt_carinfo.Text;
                string custnum = txt_custid.Text;
                string custnamee = txt_custname.Text;
                string custmob = txt_custmobile.Text;
                string custaddres = txt_custaddress.Text;



                int g = o.newSellTransaction(transno, transtype, date, vinn, spm, price, ser, tax, total, carinfoo, custnum, custnamee, custaddres, custmob , pmethod);

                if (g > 0 )
                {
                    string desc = "";
                    if (transtype == 1 && spm == 1)
                        desc = "Sell Cash";
                    if (transtype == 1 && spm == 2)
                        desc = "Sell Cheq";
                    MessageBox.Show(Resources.Completed , Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    o.newTransaction(transno, transtype, vinn, total, spm, desc, date);
                    o.updatecarStatus(vinn, cstat, carsttext);
                    simpleButton2.PerformClick();


                }

                else if (g == -1)
                {
                    MessageBox.Show("You Can't Sell Same car more than one ... ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else
                {
                    MessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        private void simpleButton8_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_custid.Text))
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                string cust = txt_custid.Text;
                string condition = "custid=" + "'" + @cust + "'";

                DataTable dtable = o.SelctData(cutsTabel, 1, condition);
                int x = dtable.Rows.Count;

                if (dtable != null && dtable.Rows.Count > 0)
                {


                    txt_custname.Text = dtable.Rows[0]["custname"].ToString();//2
                    txt_custaddress.Text = dtable.Rows[0]["note"].ToString();//2
                    txt_custmobile.Text = dtable.Rows[0]["mobilenum"].ToString();//2
                }

                else
                {
                    MessageBox.Show("Please Enter Customer ID  ", Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void txt_taxper_Leave(object sender, EventArgs e)
        {
            simpleButton4.PerformClick();
            txt_taxval.Focus();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void txt_taxper_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taxper.Text))
            {
                MessageBox.Show(Resources.digitOnlyError, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_taxval.Focus();
            }
            else
            {
                double tax = (double.Parse(txt_price.Text) * (double.Parse(txt_taxper.Text) / 100));
                txt_taxval.Text = tax.ToString();
                txt_discount.Focus();
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Update Customer Info")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                frmUpdateCustomerInfo uc = new frmUpdateCustomerInfo();
                uc.Show();
            }
        }
    }
            
    }

    
