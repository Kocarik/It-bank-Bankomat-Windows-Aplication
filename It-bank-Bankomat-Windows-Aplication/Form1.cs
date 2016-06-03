using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace It_bank_Bankomat_Windows_Aplication
{
    public partial class Form1 : Form
    {
        ConnectToDatabase db = new ConnectToDatabase();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            lblBalance.Visible = false;
            lblCardID.Visible = false;
            lblYourBalance.Visible = false;
            txtCardID.Text = "Please Enter Your Card ID";
            txtPin.Text = "Please enter your pin";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtPin.Text = null;
            txtCardID.Text = null;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPin.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPin.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPin.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPin.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPin.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPin.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPin.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPin.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPin.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPin.Text += "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (db.getCardPin(txtCardID.Text, txtPin.Text))
            {
                txtCardID.Visible = false;
                txtPin.Visible = false;

                label1.Text = "PIN OK";
                lblYourBalance.Visible = true;
                lblBalance.Visible = true;
                lblBalance.Text = db.getBalance(txtCardID.Text);

                lblCardID.Visible = true;
                lblCardID.Text = "Card ID: " + txtCardID.Text;
            }


            else
            {
                txtCardID.Visible = true;
                txtPin.Visible = true;

                label1.Text = "BAD PIN";
                lblBalance.Text = "";
                lblCardID.Text = "";
                db.insetIntobatAcess(int.Parse(txtCardID.Text));

            }

        }

        private void txtCardID_Click(object sender, EventArgs e)
        {
            txtCardID.Text = null;
        }

        private void txtPin_Click(object sender, EventArgs e)
        {
            txtPin.Text = null;
        }

        private void txtCardID_TextChanged(object sender, EventArgs e)
        {
            txtCardID.Text = "Please Enter Your Card ID";
        }
    }
}
