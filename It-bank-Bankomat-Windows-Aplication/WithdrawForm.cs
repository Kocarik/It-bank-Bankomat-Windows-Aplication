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
        string accountID;

        public WithdrawForm(string accountID)
        {
            InitializeComponent();
            label1.Text = accountID;
            this.accountID = accountID;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(db.updateBalance(accountID, float.Parse(txtAmout.Text)))
            {
                MessageBox.Show("Withdraw sucefull!", "Update Balance Message");
            }

            else
            {
                MessageBox.Show("Withdraw Unsucefull!", "Update Balance Unsucefull");
            }
        }

        private void pict5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
