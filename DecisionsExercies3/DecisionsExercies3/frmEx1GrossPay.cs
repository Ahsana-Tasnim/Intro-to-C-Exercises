using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercies3
{
    /** Ahsana Tasnim
     * 08 June, 2021 **/

    public partial class frmEx1GrossPay : Form
    {
        const decimal PAYMENT_RATE = 15;
        public frmEx1GrossPay()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal workHour = Convert.ToDecimal(txtHours.Text);
                decimal paymentAmt = workHour * PAYMENT_RATE;

                if (workHour >= 1 && workHour <= 168)
                {
                    MessageBox.Show($"Your gross pay for {workHour} hours is {paymentAmt:c}");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
               
            }
            txtHours.Focus();
            txtHours.SelectAll();
        }
    }
}
