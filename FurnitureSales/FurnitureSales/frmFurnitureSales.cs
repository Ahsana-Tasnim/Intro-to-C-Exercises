using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSales
{
    public partial class frmFurnitureSales : Form
    {
        private const decimal COMMISSION_RATE = .07m;

        private decimal total;  

        public frmFurnitureSales()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;

            try
            {
                decimal price = Convert.ToDecimal(txtPrice.Text);

                total += price;

                lblDisplay.Text += $"{item}: {price:c} {Environment.NewLine}";

                txtItem.Text = string.Empty;
                txtPrice.Text = string.Empty;

                txtItem.Focus();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }


        }  
        private void btnCommission_Click(object sender, EventArgs e)
        {
            decimal commission = total * COMMISSION_RATE;

            lblDisplay.Text += $"Total Commission: {commission:c}"; 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItem.Text = string.Empty;
            txtPrice.Text = string.Empty;
            lblDisplay.Text = string.Empty;
            txtItem.Focus();
            total = 0;
        }
    }
}
