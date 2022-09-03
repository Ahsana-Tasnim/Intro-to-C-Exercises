using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits
{
    /** Ahsana Tasnim
     * 09 June, 2021 **/

    public partial class frmDeposit : Form
    {
        const decimal SURCHARGE_RATE = 0.005m;
        const decimal TRANSACTION_FEE_FOR_TWO = 3.75m;
        const decimal TRANSACTION_FEE_FOR_MORE = 1;
        const decimal CHECK_PROCESS_RATE_FOR_FOUR = 0.75m;
        const decimal CHECK_PROCEES_RATE_FOR_MORE = 0.25m;
        private int depositNumber = 0;
        private decimal netDeposit;

        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)
        {
            try
            {

                string accHolder = txtAccountHolder.Text;
                string accNumber = txtAccountNumber.Text;
                decimal cashAmt = Convert.ToDecimal(txtCashAmt.Text);
                decimal checkAmt = Convert.ToDecimal(txtCheckAmt.Text);
                decimal numberOfChecks = Convert.ToDecimal(txtNumChecks.Text);

                decimal depositAfterSurcharge = cashAmt * SURCHARGE_RATE;
                decimal checkProcessingUptoFour = numberOfChecks * CHECK_PROCESS_RATE_FOR_FOUR; ;
                decimal checkProcessingMore = numberOfChecks * CHECK_PROCEES_RATE_FOR_MORE;

                decimal transictionUptoTwo = TRANSACTION_FEE_FOR_TWO;
                decimal transictionMore = TRANSACTION_FEE_FOR_MORE;

                netDeposit = depositAfterSurcharge + checkAmt;

                lblDepositSummary.Text = ($"Deposit for {accHolder} {Environment.NewLine}");
                                          


                if (numberOfChecks <= 3 && numberOfChecks > 0)
                {

                    lblDepositSummary.Text = ($"Account #: {accNumber} {Environment.NewLine}" +
                                               $"{Environment.NewLine}Cash Deposits (after surcharge): {depositAfterSurcharge:c} {Environment.NewLine}" +
                                               $"Check Deposit: {checkAmt:c} {Environment.NewLine}" +
                                               $"Check Processing: {checkProcessingUptoFour:c} {Environment.NewLine}" +
                                               $"Transaction Fee: {transictionUptoTwo:c} {Environment.NewLine}" +
                                               $"{Environment.NewLine}Net Deposit: {netDeposit:c}");
                }
                else
                {

                    lblDepositSummary.Text = ( $"Account #: {accNumber} {Environment.NewLine}" +
                                               $"{Environment.NewLine}Cash Deposits (after surcharge): {depositAfterSurcharge:c} {Environment.NewLine} " +
                                               $"Check Deposit: {checkAmt:c} {Environment.NewLine}" +
                                               $"Check Processing: {checkProcessingMore:c} {Environment.NewLine}" +
                                               $"Transaction Fee: {transictionMore:c} {Environment.NewLine}" +
                                               $"{Environment.NewLine}Net Deposit: {netDeposit:c}");

                }

                lblTotalDisplay.Text = $"Total diposits for all accounts belonging to {accHolder} is {netDeposit:c}";

                btnNewAccount.Enabled = true;

                depositNumber += 1;

                txtAccountNumber.Text = string.Empty;
                txtCashAmt.Text = string.Empty;
                txtCheckAmt.Text = string.Empty;
                txtNumChecks.Text = string.Empty;

                txtAccountHolder.Enabled = false;
                

                txtAccountNumber.Focus();
            }
            catch (Exception er)
            {
                string msg = "The following exeption occured: The input string was not in a current fromat.";
                MessageBoxButtons button = MessageBoxButtons.OK;

                MessageBox.Show($"{msg}", er.GetType().ToString(), button, MessageBoxIcon.Warning);
                
            }
           
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            string accHolder = txtAccountHolder.Text;
            lblTotalDisplay.Text = $"Total diposits for all accounts belonging to {accHolder} is {netDeposit:c}";

            txtAccountNumber.Text = string.Empty;
            txtCashAmt.Text = string.Empty;
            txtCheckAmt.Text = string.Empty;
            txtNumChecks.Text = string.Empty;
            lblDepositSummary.Text = string.Empty;

            txtAccountNumber.Focus();
        }


        private void btnLeave_Click(object sender, EventArgs e)
        {
            string title = "Come back again soon!";
            MessageBox.Show($"Net amount for your {depositNumber} deposits were {netDeposit:c}. {Environment.NewLine}" +
                             "Thank you for Banking with us." , title);

            Close();
        }

        
    }
}
