using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    /** Ahsana Tasnim 
     * 23 May, 2021 **/


    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int conversionFacttor = 703;
            decimal weight = Convert.ToDecimal(txtWeight.Text);
            decimal height = Convert.ToDecimal(txtHeight.Text);
            decimal result = (weight * (Convert.ToDecimal(conversionFacttor))) / (height * height);
            decimal roundResult = Math.Round(result, 2, MidpointRounding.ToEven);
            MessageBox.Show("Your BMI is " + roundResult);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtWeight.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's an irrelevant number anyway!");
        }
    }
}
