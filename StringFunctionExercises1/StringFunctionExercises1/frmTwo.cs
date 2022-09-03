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

    public partial class frmTwo : Form
    {
        public frmTwo()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string pass = txtPassword.Text.Trim();

                int usernameLength = username.Length;
                int passLength = pass.Length;

                if (usernameLength < 4 || usernameLength > 8)
                {
                    MessageBox.Show("The username must be between 4 and 8 characters in length.");

                    txtUserName.Focus();
                    txtUserName.SelectAll();

                }
                else if (passLength < 8 || passLength > 12)
                {
                    MessageBox.Show("The password must be between 8 and 12 characters in length.");

                    txtPassword.Focus();
                    txtPassword.SelectAll();

                }
                else
                {
                    MessageBox.Show($"Username: {username} {Environment.NewLine}" +
                              $"Password: {pass} ");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }


        }
    }
}
