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

    public partial class frmPerimeter : Form
    {
        public frmPerimeter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtLength.Text, out decimal numberOfLength))
                {
                    MessageBox.Show("Please enter a valid number of length.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLength.Focus();
                    txtLength.SelectAll();
                    return;
                }

                if (!decimal.TryParse(txtWidth.Text, out decimal numberOfWidth))
                {
                    MessageBox.Show("Please enter a valid number of width.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtWidth.Focus();
                    txtWidth.SelectAll();
                    return;
                }

                CalculatePerimeter(numberOfLength, numberOfWidth);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void CalculatePerimeter(decimal length, decimal width)
        {
            decimal result = (2 * length) + (2 * width);

            lblPerimeter.Text = result.ToString();
        }
    }
}
