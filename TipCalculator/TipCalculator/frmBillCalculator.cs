using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class frmBillCalculator : Form
    {
        public frmBillCalculator()
        {
            InitializeComponent();
        }

        const decimal SALES_TAX_PERC = 7.5m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the data from user
            decimal foodCharges = Convert.ToDecimal(txtFood.Text);
            decimal drinkCharges = Convert.ToDecimal(txtDrinks.Text);
            decimal tipPerc = Convert.ToDecimal(lblTipPerc.Text);

            // performed calculations
            decimal subTotal = foodCharges + drinkCharges;
            decimal tipAmt = (tipPerc / 100) * subTotal;
            decimal salesTax = subTotal * (SALES_TAX_PERC) / 100;
            decimal total = subTotal + tipAmt + salesTax;

            // output
            lblSubtotal.Text = subTotal.ToString("c");
            lblTipAmt.Text = tipAmt.ToString("c");
            lblSalesTax.Text = salesTax.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            lblTipPerc.Text = (Convert.ToInt32(lblTipPerc.Text) - 5).ToString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            decimal tipPerc = Convert.ToInt32(lblTipPerc.Text);
            decimal newTipPerc = tipPerc + 5;
            lblTipPerc.Text = lblTipPerc.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
