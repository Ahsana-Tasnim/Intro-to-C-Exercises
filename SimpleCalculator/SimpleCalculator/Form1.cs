using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber + secondNumber;
            lblAnswer.Text = answer.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber - secondNumber;
            lblAnswer.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber * secondNumber;
            lblAnswer.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber / secondNumber;
            lblAnswer.Text = answer.ToString();
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
            double answer = firstNumber % secondNumber;
            lblAnswer.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = string.Empty;
            txtFirstNumber.Text = string.Empty;
            txtSecondNumber.Text = string.Empty;
        }
    }
}
