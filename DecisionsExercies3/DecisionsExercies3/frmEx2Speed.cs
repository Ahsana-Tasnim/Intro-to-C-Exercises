using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercies3
{
    /** Ahsana Tasnim
     * 08 June, 2021 **/

    public partial class frmEx2Speed : Form
    {
        public frmEx2Speed()
        {
            InitializeComponent();
        }

        private void btnCheckSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentSpeed = Convert.ToDecimal(txtCurrentSpeed.Text);

                 if (currentSpeed < 0)
                {
                    MessageBox.Show("Please provide a valid number.");
                }
                else if (currentSpeed >= 30 && currentSpeed <= 75)
                {
                    MessageBox.Show("Your speed is under the speed limit.");
                }
                else if (currentSpeed > 75 || currentSpeed < 30)
                {
                    MessageBox.Show("Your speed is outside the speed limit.");
                }
               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
                
            }
           
        }
    }
}
