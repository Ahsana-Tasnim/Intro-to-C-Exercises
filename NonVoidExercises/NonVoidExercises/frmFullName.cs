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

    public partial class frmFullName : Form
    {
        public frmFullName()
        {
            InitializeComponent();
        }

        private void btnDisplayFullName_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                if (firstName == null)
                {
                    MessageBox.Show("Please enter a valid first name.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtFirstName.Focus();
                    return;
                }

                if (lastName == null)
                {
                    MessageBox.Show("Please enter a valid last name.", "Invalid Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLastName.Focus();
                    return;
                }

                lblDisplay.Text = GenerateFullName(firstName, lastName);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }


        private string GenerateFullName(string firstName, string LastName)
        {
            string fullName = firstName + " " + LastName;
            return fullName;
        }
    }
}
