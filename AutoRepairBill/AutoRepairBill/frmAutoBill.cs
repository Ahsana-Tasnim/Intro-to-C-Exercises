using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepairBill
    /* 
     * Ahsana Tasnim
     * 31st May, 2021 
     */
{
    public partial class frmAutoBill : Form
    {
        private const decimal LABOUR_RATE = 85;
        private const decimal TAX_RATE = 0.15m;
        private const decimal IMPORT_RATE = 0.05m;

        private int itemNo = 0;

        private decimal totalLabourCost;
        private decimal totalPartCost;

        public frmAutoBill()
        {
            InitializeComponent();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            try
            {
                string partName = txtPartName.Text;
                decimal partCost = Convert.ToDecimal(txtPartCost.Text);
                decimal importFee = partCost * IMPORT_RATE;
                decimal partCostwithImportFee = importFee + partCost;
                decimal labourperHour = Convert.ToDecimal(txtLabourHours.Text);
                decimal labourCost = labourperHour * LABOUR_RATE;
                decimal subTotal = partCostwithImportFee + labourCost;
                decimal tax = subTotal * TAX_RATE;


                totalLabourCost += labourCost;
                totalPartCost += partCostwithImportFee;

                txtBill.Text += $"-----ITEM # {++itemNo} {Environment.NewLine}" +
                               $"Part Name: {partName} {Environment.NewLine}" +
                               $"Part Cost: {Math.Round(partCostwithImportFee, 2, MidpointRounding.ToEven).ToString("C")} {Environment.NewLine}" +
                               $"Labour Cost: {labourCost:c} {Environment.NewLine}" +
                               $"Tax: {tax:c} {Environment.NewLine}" +
                               (Environment.NewLine);


                txtPartName.Text = string.Empty;
                txtPartCost.Text = string.Empty;
                txtLabourHours.Text = string.Empty;
                txtPartName.Focus();

            }
            catch (Exception px)
            {
                MessageBox.Show($"Error with {px.Message}");
                
            }
            
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            decimal subtotal = totalLabourCost + totalPartCost;
            decimal totalTax = subtotal * TAX_RATE;
            decimal totalInvoice = subtotal + totalTax;

            txtBill.Text = $"-----YOUR INVOICE----- {Environment.NewLine}" +
                          $"Total Labour: {Math.Round(totalLabourCost,2, MidpointRounding.ToEven).ToString("c")} {Environment.NewLine}" +
                          $"Total Parts: {Math.Round(totalPartCost,2, MidpointRounding.ToEven).ToString("c")} {Environment.NewLine}" +
                          $"Total Tax: {Math.Round(totalTax,2, MidpointRounding.ToEven).ToString("c")} {Environment.NewLine}" +
                          $"Total Invoice: {Math.Round(totalInvoice,2, MidpointRounding.ToEven).ToString("c")} {Environment.NewLine}" +
                          (Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPartName.Text = string.Empty;
            txtPartCost.Text = string.Empty;
            txtLabourHours.Text = string.Empty;
            txtBill.Text = string.Empty;
            txtPartName.Focus();

            totalLabourCost = 0;
            totalPartCost = 0;
            itemNo = 0;
        }
    }
}
