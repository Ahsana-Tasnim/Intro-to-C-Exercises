using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreNB
{
    /** Ahsana Tasnim
     * 24 July, 2021 **/ 

    public partial class frmTicketPurchase : Form
    {
        public frmTicketPurchase()
        {
            InitializeComponent();
        }


        private void frmTicketPurchase_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfPlays = 0;

                if (chk1979.Checked)
                {
                    numOfPlays++;
                }
                if (chkAnnie.Checked)
                {
                    numOfPlays++;
                }
                if (chkBoysGirls.Checked)
                {
                    numOfPlays++;
                }
                if (chkWonderfulLife.Checked)
                {
                    numOfPlays++;
                }

                if (numOfPlays < 1)
                {
                    MessageBox.Show("You must select at least one play.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string creditCardNumber = txtCreditCard.Text;

                if (!IsValidCreditCard(creditCardNumber))
                {
                    MessageBox.Show("Credit card is invalid.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtCreditCard.Focus();
                    txtCreditCard.SelectAll();
                    return;
                }

                decimal total = 0;

                if (rdoBalcony.Checked)
                {
                    total = 50 * numOfPlays;
                }
                else if (rdoBox.Checked)
                {
                    total = 85 * numOfPlays;
                }
                else
                {
                    total = 110 * numOfPlays;
                    
                    if(numOfPlays >= 2)
                    {
                        total *= 0.15m;
                    }
                }

                string lastFourNumOfCC = creditCardNumber.Substring(creditCardNumber.Length - 4);

                lblDisplay.Text = $"{total:c} has been charged to your credit card ending in {lastFourNumOfCC}";


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private bool IsValidCreditCard(string creditCardNumber)
        {
            if (creditCardNumber.Length != 16)
            {
                return false;
            }

            if (!creditCardNumber.StartsWith("45"))
            {
                return false;
            }

            if (!long.TryParse(creditCardNumber, out long cc))
            {
                return false;
            }

            return true;
        }
        private void Setup()
        {
            rdoBalcony.Checked = true;

            chk1979.Checked = false;
            chkAnnie.Checked = false;
            chkBoysGirls.Checked = false;
            chkWonderfulLife.Checked = false;

            lblDisplay.Text = string.Empty;
            txtCreditCard.Text = string.Empty;
        }

    }
}
