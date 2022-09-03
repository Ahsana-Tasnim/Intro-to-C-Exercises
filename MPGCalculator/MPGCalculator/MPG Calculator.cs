using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPGCalculator
{
    public partial class MPGCalculator : Form
    {
        public MPGCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal gallonNumber = Convert.ToDecimal(txtNumberofGallon.Text);
            decimal miles = Convert.ToDecimal(txtMiles.Text);
            decimal result = miles / gallonNumber;
            lblresult.Text = Math.Round(result, 2, MidpointRounding.ToEven).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblresult.Text = string.Empty;
            txtMiles.Text = string.Empty;
            txtNumberofGallon.Text = string.Empty;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
