using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCalc
{
    /** Ahsana Tasnim
     * 22 June, 2021 **/

    public partial class frmShippingCalc : Form
    {
        
        public frmShippingCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double packageWeight;
            double miles;

            if (!double.TryParse(txtWeight.Text, out packageWeight))
            {
                if (txtWeight.Text == "")
                {
                    MessageBox.Show("Please provide a number.");
                    
                    txtWeight.Focus();
                }
                else
                {
                    string msg = txtWeight.Text + " is not a number.";
                    MessageBox.Show(msg);

                    txtWeight.Focus();
                }
            }


            if (!double.TryParse(txtDistance.Text, out miles))
            {
                if (txtDistance.Text == "")
                {
                    MessageBox.Show("Please provide a number.");

                    txtDistance.Focus();
                }
                else
                {
                    string msg = txtDistance.Text + " is not a number.";
                    MessageBox.Show(msg);

                    txtDistance.Focus();
                }
            }

            double shippingRate = 0.01;

            if(miles < 20 || miles > 3000)
            {
                lblShippingCharge.Text = "incorrect";
                
                txtDistance.Focus();
                txtDistance.SelectAll();
            }

            if (packageWeight <= 0 || packageWeight > 20)
            {

                lblShippingCharge.Text = "incorrect";

                txtWeight.Focus();
                txtWeight.SelectAll();
            }

            else if (packageWeight > 2 && packageWeight <= 6)
            {
                shippingRate = 0.015;

                double shippingCost = miles * shippingRate;

                lblShippingCharge.Text = shippingCost.ToString("c");
            }
            else if(packageWeight > 6 && packageWeight <= 10)
            {
                shippingRate = 0.02;

                double shippingCost = miles * shippingRate;

                lblShippingCharge.Text = shippingCost.ToString("c");
            }
            else if(packageWeight > 10 && packageWeight <= 20)
            {
                shippingRate = 0.025;

                double shippingCost = miles * shippingRate;

                lblShippingCharge.Text = shippingCost.ToString("c");
            }

           




        }
    }
}
