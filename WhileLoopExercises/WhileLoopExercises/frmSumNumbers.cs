using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoopExercises
{
    /** Ahsana Tasnim
     * 09 July, 2021 **/

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
                int result = 0;
                int increment = 0;

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

                while (increment <= number)
                {
                    result += increment;
                    increment++;
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


