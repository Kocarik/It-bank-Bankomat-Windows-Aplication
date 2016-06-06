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
    public partial class SetNewPincodeForm : Form
    {
        ConnectToDatabase db = new ConnectToDatabase();
        string cardID;

        public SetNewPincodeForm(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
            lblCardID.Text = cardID;
        }

        private void btnSetNewPin_Click(object sender, EventArgs e)
        {
            if (db.getCardPin(cardID, txtOldPincode.Text))
            {
                txtOldPInStatus.Text = "OLD PIN GOOD";

                if (txtNewPincode1.Text == txtNewPincode2.Text)
                {
                    if (db.updatePinCode(cardID, txtNewPincode2.Text))
                    {
                        lblNewPinStatus.Text = "NEW PIN SET OK";
                    }

                    else
                    {
                        lblNewPinStatus.Text = "ERROR NEW PIN FAIL";
                    }
                }

                else
                {
                    lblNewPinStatus.Text = "PIN NOT REPEAT";
                }

            }

            else
            {
                txtOldPInStatus.Text = "OLD PIN IS BAD";
            }
        }
    }
}
