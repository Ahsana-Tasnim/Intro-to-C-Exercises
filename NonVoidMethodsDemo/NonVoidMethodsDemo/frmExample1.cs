using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonVoidMethodsDemo
{
    /** Ahsana Tasnim
     * 14 July, 2021 **/

    public partial class frmExample1 : Form
    {
        public frmExample1()
        {
            InitializeComponent();
        }

        private void btnFindLargest_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtFirstNumber.Text, out double firstNum) ||
                    !double.TryParse(txtSecondNumber.Text, out double secondNum)) 
                {
                    MessageBox.Show("Please enter valid numbers", "Invalid entry");
                    return;
                }

                double largestNumber = FindLargest(firstNum, secondNum);

                MessageBox.Show($"The lasrgest number you entered is: {largestNumber}");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private double FindLargest(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;

        }

        private void btnIsFirstOneBigger_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirstNumber.Text, out double firstNum) ||
                    !double.TryParse(txtSecondNumber.Text, out double secondNum))
            {
                MessageBox.Show("Please enter valid numbers", "Invalid entry");
                return;
            }

            if (IsFirstLargest(firstNum, secondNum))
            {
                MessageBox.Show("First number was largest");
            }
            else
            {
                MessageBox.Show("First number was not largest");
            }
        }

        private bool IsFirstLargest(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
