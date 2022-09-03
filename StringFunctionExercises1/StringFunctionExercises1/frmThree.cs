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

    public partial class frmThree : Form
    {
        string DEMO = "STACKOVERFLOW IS MY BEST FRIEND!";
        public frmThree()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string letter = txtLetter.Text.ToUpper();

                int letterPosition = DEMO.IndexOf(letter);


                if (string.IsNullOrEmpty(letter))
                {
                    MessageBox.Show("Please enter a letter.");
                }
                else if (letterPosition == -1)
                {
                    lblDisplay.Text = $"{letter} does not occur anywhere in the sentence.";
                }
                else
                {
                    lblDisplay.Text = $"{letter} first occurs at position {letterPosition}.";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }

        }
    }
}
