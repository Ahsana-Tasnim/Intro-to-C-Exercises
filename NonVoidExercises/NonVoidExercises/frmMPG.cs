using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonVoidExercises
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
                if (!double.TryParse(txtGallons.Text, out double numberOfGallons))
                {
                    MessageBox.Show("Please enter valid number of gallons.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtGallons.Focus();
                    txtGallons.SelectAll();
                    return;
                }

                if (!double.TryParse(txtMiles.Text, out double numberOfMiles))
                {
                    MessageBox.Show("Please enter valid number of miles.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMiles.Focus();
                    txtMiles.SelectAll();
                    return;
                }

                lblMPG.Text = CalcMPG(numberOfGallons, numberOfMiles).ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }


        private double CalcMPG(double gallons, double miles)
        {
            double result = miles / gallons;
            return result;
        }
    }
}
