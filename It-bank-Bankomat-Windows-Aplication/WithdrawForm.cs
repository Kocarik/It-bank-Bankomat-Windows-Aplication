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
    public partial class WithdrawForm : Form
    {
        ConnectToDatabase db = new ConnectToDatabase();

        public WithdrawForm(string accountID)
        {
            InitializeComponent();
            label1.Text = accountID;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(db.updateBalance(label1.Text, float.Parse(txtAmout.Text)))
            {
                MessageBox.Show("Withdraw sucefull!", "Update Balance Message");
            }

            else
            {
                MessageBox.Show("Withdraw Unsucefull!", "Update Balance Unsucefull");
            }
        }

        private void pict5_Click(object sender, EventArgs e)
        {
            txtAmout.Text = "5";
        }
    }
}
