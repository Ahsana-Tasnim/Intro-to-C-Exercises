using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercises1
{
    public partial class frmEx1SqRoot : Form
    {
        /** Ahsana Tasnim
         * 5 June, 2021 **/

        public frmEx1SqRoot()
        {
            InitializeComponent();
        }

        private void btnSqRt_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(txtNumber.Text);

                double answer = Math.Sqrt(number);

                if (number < 0)
                {
                    lblDisplay.Text = "Number cannot be negative.";

                    txtNumber.Focus();
                    txtNumber.SelectAll();

                }
                else if (number > 0)
                {
                    lblDisplay.Text = $"The Square root of {number} is {answer}";
                }
                else
                {
                    string message = "Please enter a number greater than zero.";
                    string title = "Invalid Number";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtNumber.Focus();
                    txtNumber.SelectAll();
                }

                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
                
            }
           
        }

    }
}
