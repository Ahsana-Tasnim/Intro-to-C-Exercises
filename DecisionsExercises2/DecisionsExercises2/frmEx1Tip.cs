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


    public partial class frmEx1Tip : Form
    {
        const decimal HIGHEST_BILL_RATE = 0.20m;
        const decimal LOWEST_BILL_RATE = 0.15m;
        const decimal LOWEST_TIP = 1.00m;
        const decimal HIGHEST_TIP = 5.00m;
        
        public frmEx1Tip()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal bill = Convert.ToDecimal(txtBillAmt.Text);

                decimal upToTenTip = (bill * HIGHEST_BILL_RATE);
                decimal moreThanTenTip = (bill * LOWEST_BILL_RATE);

                if (upToTenTip < 1 && bill <= 10 && bill > 0)
                {
                    MessageBox.Show($"The tip amount is: {LOWEST_TIP:c}");

                }
                else if (upToTenTip >= 1 && bill <= 10)
                {
                    MessageBox.Show($"The tip amount is: {upToTenTip:c}");
                }

                else if (moreThanTenTip < 5 && bill > 10)
                {
                    MessageBox.Show($"The tip amount is: {HIGHEST_TIP:c}");
                }
                else if (bill <= 0)
                {
                    MessageBox.Show("The bill must be more than $0.00");
                }
                
                else
                {
                    MessageBox.Show($"The tip amount is: {moreThanTenTip:c}");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
                
            }
            
        }
    }
}
