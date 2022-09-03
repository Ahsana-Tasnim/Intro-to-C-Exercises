using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFunctionExercises1
{
    /** Ahsana Tasnim
     * 02 July, 2021 **/

    public partial class frmFour : Form
    {
        public frmFour()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;

            int space = name.IndexOf(' ');


            if (space == -1)
            {
                MessageBox.Show("The name you enter must have a space in it.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFullName.Focus();
                txtFullName.SelectAll();
            }
            else
            {

                string firstName = name.Substring(0, space);
                string lastName = name.Substring(space);

                lblFirstName.Text = firstName;
                lblLastName.Text = lastName;
            }

        }
    }
}
