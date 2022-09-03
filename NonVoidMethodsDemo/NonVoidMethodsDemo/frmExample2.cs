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

    public partial class frmExample2 : Form
    {
        public frmExample2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
            }
            else if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
            else
            {
                decimal.TryParse(txtDiscount.Text, out decimal discount);

                decimal totalAmount = CalculateTotal(price, discount);
                string productName = txtProductName.Text.Trim();

                MessageBox.Show($"The total for the {productName} is {totalAmount:c}");
            }
        }

        #region User-Defined methods

        private decimal CalculateTotal(decimal price, decimal discount)
        {
            decimal total = price * (1 - discount / 100);
            return total;
        }

        #endregion
    }
}
