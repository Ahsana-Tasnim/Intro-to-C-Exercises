using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBooks
{
    /** Ahsana Tasnim
     * 26 July, 2021 **/

    public partial class frmEBookOrder : Form
    {
        private const decimal BOOK_PRICE = 19.99m;
        private const decimal EXPEDITED_SHIPPING_PRICE = 5.99m;
        private int totalQty;
        public frmEBookOrder()
        {
            InitializeComponent();
        }

        private void frmEBookOrder_Load(object sender, EventArgs e)
        {
            cboAvailableBooks.Items.Add("ASP.NET 4.7");
            cboAvailableBooks.Items.Add("SQL Server 2017");
            cboAvailableBooks.Items.Add("Visual Studio 2017");
            cboAvailableBooks.Items.Add("C# 2015");
            cboAvailableBooks.Items.Add("Database Systems");
            cboAvailableBooks.Items.Add("Class Design");
            cboAvailableBooks.Items.Add("SQL Server 2017 Administration");
            cboAvailableBooks.Items.Add("UML Patterns and Design");

            Setup();
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboAvailableBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an e-book.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < lstCart.Items.Count; i++)
                {
                    totalQty = Convert.ToInt32(lstCart.Items[i]);
                }

                btnCheckout.Text += ":" + txtQuantity.Text;

                lstCart.Items.Add("(" + txtQuantity.Text + ") " + cboAvailableBooks.SelectedItem);

                btnCheckout.Enabled = true;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                grpOrderDetails.Enabled = true;
                grpShipping.Enabled = true;

                grpChooseBooks.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                txtMemberNumber.Enabled = true;
                btnPlaceOrder.Enabled = true;

                decimal shippingCost = 0;
                decimal subTotal = 0;

                GetOrderTotal(shippingCost, subTotal);

                grpOrderConfirmation.Enabled = true;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!IsValidMemberNumber())
            {
                MessageBox.Show("Please enter a valid member number.", "Valid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thank you for your order!", "Order processed",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void frmEBookOrder_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult formClose = MessageBox.Show("Are you sure you want to exit?", "Exit?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (formClose == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (formClose == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Methods

        private void Setup()
        {
            btnCheckout.Enabled = false;
            grpOrderInfo.Enabled = false;

        }

        private decimal GetOrderTotal(decimal subTotal, decimal shippingCost)
        {

            shippingCost = 0;
            subTotal = BOOK_PRICE * totalQty;
            decimal total = shippingCost + subTotal;


            if (chkExpedited.Checked)
            {
                lblSubtotal.Text = string.Empty;
                lblShipping.Text = string.Empty;
                lblTotal.Text = string.Empty;

                shippingCost = EXPEDITED_SHIPPING_PRICE;

                btnCalculateOrder.Enabled = true;
            }
            lblSubtotal.Text = subTotal.ToString("c");
            lblShipping.Text = shippingCost.ToString("c");
            lblTotal.Text = total.ToString("c");

            return total;
        }

        private bool IsValidMemberNumber()
        {
            int length = txtMemberNumber.Text.Length;
            bool endsWithX = txtMemberNumber.Text.EndsWith("X");
            bool containsB = txtMemberNumber.Text.Contains("B");

            if (length == 6 && endsWithX == true && containsB == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
