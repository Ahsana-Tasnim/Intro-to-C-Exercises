using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstMethodExample
{
    /** Ahsana Tasnim
     * 07 July, 2021 **/

    public partial class Form1 : Form
    {
        private bool validLastValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (validLastValue)
            {
                Display(txtFirstName.Text + " " + txtLastName.Text);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            TxtBox_Validating(sender, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            TxtBox_Validating(sender, e);
        }

        private void TxtBox_Validating(object sender, CancelEventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox mySender = (TextBox)sender;

                Validate(mySender.Text);
            }
        }

        private void Validate(string value)
        {
            if (value == string.Empty)
            {
                MessageBox.Show("First and Last Name must have a value");
                validLastValue = false;
            }
            else
            {
                validLastValue = true;
            }
        }

        private void Display(string value)
        {
            lblDisplay.Text = value;
        }
    }
}
