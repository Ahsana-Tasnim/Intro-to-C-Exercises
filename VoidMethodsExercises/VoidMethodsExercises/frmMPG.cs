using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsExercises
{
    /** Ahsana Tasnim
     * 17 July, 2021 **/

    public partial class frmMPG : Form
    {
        public frmMPG()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtGallons.Text, out decimal numberOfGallons))
                {
                    MessageBox.Show("Please enter a valid number of gallons.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtGallons.Focus();
                    txtGallons.SelectAll();
                    return;
                }

                if (!decimal.TryParse(txtMiles.Text, out decimal numberOfMiles))
                {
                    MessageBox.Show("Please enter a valid number of miles.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMiles.Focus();
                    txtMiles.SelectAll();
                    return;
                }

                CalculateMPG(numberOfGallons, numberOfMiles);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }


        private void CalculateMPG(decimal gallons, decimal miles)
        {
            decimal result = miles / gallons;

            lblMPG.Text = result.ToString();
        }
    }
}
