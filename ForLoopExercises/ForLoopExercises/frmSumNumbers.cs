using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopExercises
{
    /** Ahsana Tasnim
     * 16 July, 2021 **/

    public partial class frmSumNumbers : Form
    {
        public frmSumNumbers()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumber.Text, out int number))
                {
                    MessageBox.Show("Please enter a valid whole number.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNumber.Focus();
                    txtNumber.SelectAll();
                    return;
                }

                if (number < 1 || number > 100)
                {
                    MessageBox.Show("Please enter a valid whole number between 1 and 100.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNumber.Focus();
                    txtNumber.SelectAll();
                    return;
                }

                int result = 0;

                for (int increment = 0; increment <= number; increment++)
                {
                    result += increment;
                }

                lblDisplay.Text = $"The sum of the numbers 1 to {number} is {result}";

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }
    }
}
