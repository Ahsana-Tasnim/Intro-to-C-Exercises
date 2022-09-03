using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchExercise
{
    /** Ahsana Tasnim
     * 26 June, 2021 **/

    public partial class frmBookPoints : Form
    {
        public frmBookPoints()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumBooks.Text, out int number) || number < 0)
                {
                    MessageBox.Show("Please enter a valid number of books.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    switch (number)
                    {
                        case 0:
                            lblDisplay.Text = "0";
                            break;
                        case 1:
                            lblDisplay.Text = "5";
                            break;
                        case 2:
                            lblDisplay.Text = "15";
                            break;
                        case 3:
                            lblDisplay.Text = "30";
                            break;
                        default:
                            lblDisplay.Text = "60";
                            break;
                    }
                }
                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
                
            }
        }
    }
}
