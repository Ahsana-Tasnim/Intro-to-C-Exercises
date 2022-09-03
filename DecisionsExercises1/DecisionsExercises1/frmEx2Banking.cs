using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercises1
{
    /** Ahsana Tasnim
     * 05 June, 2021 **/

    public partial class frmEx2Banking : Form
    {
        public frmEx2Banking()
        {
            InitializeComponent();
        }

        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                decimal beginningBalance = Convert.ToDecimal(txtBeginningBalance.Text);
                decimal withdrawalAmt = Convert.ToDecimal(txtWithdrawalAmt.Text);

                decimal newBalance = beginningBalance - withdrawalAmt;

                if (withdrawalAmt > beginningBalance)
                {
                    lblDisplay.Text = "Withdrawal denied- Insufficient fund";
                    lblDisplay.ForeColor = Color.Red;
                }
                else
                {
                    lblDisplay.Text = $"Your new balance is: {newBalance:c} ";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }

           
        }
    }
}
