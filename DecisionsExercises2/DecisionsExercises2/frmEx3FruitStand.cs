using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercises2
{
    /** Ahsana Tasnim 
     * 06 June, 2021 **/

    public partial class frmEx3FruitStand : Form
    {
        private decimal cost;
        const decimal POUND_RATE = 1.7M;
        public frmEx3FruitStand()
        {
            InitializeComponent();
        }

        private void btnShowCost_Click(object sender, EventArgs e)
        {
            decimal numberofPound = Convert.ToDecimal(txtPoundsOfApples.Text);

            cost = numberofPound * POUND_RATE;

            lblCost.Text = cost.ToString("c");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                decimal paymentAmt = Convert.ToDecimal(txtPaymentAmt.Text);

                string title = "Thank you for shopping with us.";

                decimal returnAmt = cost - paymentAmt;
                decimal changeAmt = paymentAmt - cost;

                if (returnAmt > 0)
                {
                    MessageBox.Show($"You still owe {returnAmt:c}", title);

                }
                else if (returnAmt < 0)
                {
                    MessageBox.Show($"Your change is {changeAmt:c}", title);
                }
                else
                {
                    MessageBox.Show("You are paid in full.", title);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
               
            }
           
        }
    }
}
