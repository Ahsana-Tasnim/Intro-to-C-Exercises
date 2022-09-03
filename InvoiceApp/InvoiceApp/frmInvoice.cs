using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPerc = Convert.ToDecimal(lblDiscountPerc.Text);

            decimal discountAmt = subTotal * (discountPerc / 100);
            decimal total = subTotal - discountAmt;

            lblDiscountAmt.Text = discountAmt.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = string.Empty;
            lblDiscountAmt.Text = string.Empty;
            lblTotal.Text = string.Empty;

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
