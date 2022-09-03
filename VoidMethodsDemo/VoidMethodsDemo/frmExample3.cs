using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsDemo
{
    /** Ahsana Tasnim
     * 12 July, 2021 **/

    public partial class frmExample3 : Form
    {
        public frmExample3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
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
                else if (!decimal.TryParse(txtDiscount.Text, out decimal discount))
                {
                    MessageBox.Show("Please enter a valid discount.");
                    txtDiscount.Focus();
                    txtDiscount.SelectAll();
                }
                else
                {
                    CalculateTotal(price, discount, txtPrice.Text.Trim());
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }

        }

        private void CalculateTotal(decimal price, decimal discount, string productName)
        {
            decimal total = price * (1 - discount / 100);
            MessageBox.Show($"The total for the {productName} is {total:c}");
        }
    }
}
