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


    public partial class frmEx3ProfitAndLoss : Form
    {
        public frmEx3ProfitAndLoss()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal revenue = Convert.ToDecimal(txtRevenue.Text);
                decimal expense = Convert.ToDecimal(txtExpenses.Text);

                decimal lossAmt = expense - revenue;
                decimal profitAmt = revenue - expense;

                if (expense > revenue)
                {
                    string title = "So Sorry!";

                    MessageBox.Show($"Your net loss is {lossAmt:c}", title);
                }
                else if (revenue > expense)
                {
                    string title = "Congratulations!";
                    MessageBox.Show($"Your net profit is {profitAmt:c}", title);
                }
                else
                {
                    MessageBox.Show("You broke even");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
               
            }
           
        }
    }
}
