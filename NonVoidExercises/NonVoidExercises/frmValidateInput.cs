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

    public partial class frmValidateInput : Form
    {
        public frmValidateInput()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                if (IsValid())
                {
                    lblDisplay.Text = "Account Created Successfully.";
                }
                else
                {
                    lblDisplay.Text = "Account Creation Failed.";

                    txtUserName.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }


        private bool IsValid()
        {
            int length = txtUserName.TextLength;
            bool lastLetter = txtUserName.Text.EndsWith("K");

            if ((length >= 6) && (lastLetter == true) && (txtPassword.Text != string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
