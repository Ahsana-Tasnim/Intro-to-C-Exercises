using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopExercises
{
    /** Ahsana Tasnim
     * 16 July, 2021 **/

    public partial class frmSpeedDistance : Form
    {
        public frmSpeedDistance()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                if ((!decimal.TryParse(txtSpeed.Text, out decimal speed)) || (speed <= 0))
                {
                    MessageBox.Show("Please enter a spped that is greater than zero.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSpeed.Focus();
                    txtSpeed.SelectAll();
                    return;
                }

                if ((!int.TryParse(txtHours.Text, out int time)) || (time <= 0))
                {
                    MessageBox.Show("Please enter a valid whole number for hours that is greater than zero.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtHours.Focus();
                    txtHours.SelectAll();
                    return;
                }

                lstDisplay.Items.Add("Hours" + "\t\t" + "Distance");
                decimal distance = speed;

                for (int increment = 1; increment <= time; increment++)
                {
                    distance = increment * speed;
                    string result = increment.ToString() + "\t\t" + distance.ToString();
                    lstDisplay.Items.Add(result);
                }

                lstDisplay.Items.Add("The total distance travelled is " + distance);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }
    }
}
