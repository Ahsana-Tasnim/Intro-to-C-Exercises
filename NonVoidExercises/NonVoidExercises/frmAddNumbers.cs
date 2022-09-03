using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonVoidExercises
{
    /** Ahsana Tasnim
     * 17 July, 2021 **/

    public partial class frmAddNumbers : Form
    {
        public frmAddNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtFirstNum.Text, out double firstNumber))
                {
                    MessageBox.Show("Please enter valid numbers in the boxes provided.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtFirstNum.Focus();
                    txtFirstNum.SelectAll();
                    return;
                }

                if (!double.TryParse(txtSecondNum.Text, out double secondNumber))
                {
                    MessageBox.Show("Please enter valid numbers in the boxes provided.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSecondNum.Focus();
                    txtSecondNum.SelectAll();
                    return;
                }

                lblDisplay.Text = AddNums(firstNumber, secondNumber).ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }


        private double AddNums(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
    }
}
