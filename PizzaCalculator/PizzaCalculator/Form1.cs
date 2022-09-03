using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCalculator
{
    /** Ahsana Tasnim
     * 04 July, 2021 **/

    public partial class Form1 : Form
    {
        const decimal TAX_RATE = 0.15m;
        private decimal grandTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoSmall.Checked = true;
        }


        private void rdoAndCheckBox_Click(object sender, EventArgs e)
        {
            try
            {
                decimal basePrice = 8;
                decimal total;


                if (rdoMedium.Checked)
                {
                    basePrice = 11;
                }
                else if (rdoLarge.Checked)
                {
                    basePrice = 13;
                }
                else if (rdoExtraLarge.Checked)
                {
                    basePrice = 18;
                }


                decimal toppings = 0;

                if (chkExtraCheese.Checked)
                {
                    toppings += 2;
                }
                if (chkGreenPeppers.Checked)
                {
                    toppings += 1;
                }
                if (chkOnion.Checked)
                {
                    toppings += 1;
                }
                if (chkPepperoni.Checked)
                {
                    toppings += 1;
                }
                if (chkPineapple.Checked)
                {
                    toppings += 1;
                }

                decimal subtotal = basePrice + toppings;

                decimal deliveryCharge = 5;

                if (subtotal >= 15)
                {
                    deliveryCharge = 3;
                }

                total = subtotal + deliveryCharge;
                decimal totalTax = total * TAX_RATE;
                grandTotal = totalTax + total;


                lblSubtotal.Text = subtotal.ToString("c");
                lblDeliveryCharge.Text = deliveryCharge.ToString("c");
                lblTax.Text = totalTax.ToString("c");
                lblGrandTotal.Text = grandTotal.ToString("c");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string emailAddress = txtEmail.Text.Trim();

                int indexOfSign = emailAddress.IndexOf("@");
                int indexOfLastDot = emailAddress.LastIndexOf(".");
                bool indexOfLastDotAtLeastTwoAfterSign = (indexOfSign + 2) <= indexOfLastDot;

                if (emailAddress.Contains("@") && emailAddress.Contains(".") && emailAddress.Length >= 5 &&
                    indexOfLastDotAtLeastTwoAfterSign == true)
                {
                    MessageBox.Show($"Your order is on the way! {Environment.NewLine}" +
                        $"Total: {grandTotal:c}");
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            //try
            //{
            //    string email = txtEmail.Text.Trim();

            //    int emailLength = email.Length;
            //    bool containsSign = email.Contains("@");
            //    bool containsDot = email.Contains(".");
            //    int positionOfSign = email.IndexOf("@");
            //    int positionOfDot = email.IndexOf(".");

            //    if ((emailLength < 5) || (containsSign == false) || (containsDot == false)
            //        || (positionOfSign < 1) || (positionOfDot < 3) || (email == string.Empty))
            //    {
            //        MessageBox.Show("Please enter a valid email address.", "Invalid Data",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        txtEmail.Focus();
            //        txtEmail.SelectAll();
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Your order is on the way!{Environment.NewLine}" +
            //                        $"Total: {grandTotal.ToString("c")}", "Enjoy!");
            //    }
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message, er.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}


        }
    }
}
