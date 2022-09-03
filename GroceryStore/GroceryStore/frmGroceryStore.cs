using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    /** Ahsana Tasnim
     * 30 June, 2021 **/

    public partial class frmGroceryStore : Form
    {
        public frmGroceryStore()
        {
            InitializeComponent();
        }

        private void frmGroceryStore_Load(object sender, EventArgs e)
        {
            cboProductType.Items.Add("Bakery");
            cboProductType.Items.Add("Produce");
            cboProductType.Items.Add("Dairy");
            cboProductType.Items.Add("Meat");
            cboProductType.Items.Add("Frozen");
            cboProductType.Items.Add("Grocery");

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            string newProduct = txtNewProduct.Text.Trim();

            if (cboProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            if (newProduct == string.Empty)
            {
                MessageBox.Show("Please enter the name of a product");
                return;
            }

            string productType = cboProductType.SelectedItem.ToString();

            lstActiveProducts.Items.Add(newProduct + " - " + productType);

            lblNumActive.Text = lstActiveProducts.Items.Count.ToString();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstActiveProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the product you wish to discontinue");
                return;
            }

            lstDiscontinuedProducts.Items.Add(lstDiscontinuedProducts.SelectedItem);
            lstActiveProducts.Items.Remove(lstDiscontinuedProducts.SelectedItem);

            lblNumActive.Text = lstActiveProducts.Items.Count.ToString();
            lblNumDiscontinued.Text = lstDiscontinuedProducts.Items.Count.ToString();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstDiscontinuedProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the product you wish to activate");
            }
            else
            {
                lstActiveProducts.Items.Add(lstDiscontinuedProducts.SelectedItem);
                lstDiscontinuedProducts.Items.Remove(lstDiscontinuedProducts.SelectedItem);

                lblNumActive.Text = lstActiveProducts.Items.Count.ToString();
                lblNumDiscontinued.Text = lstDiscontinuedProducts.Items.Count.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
