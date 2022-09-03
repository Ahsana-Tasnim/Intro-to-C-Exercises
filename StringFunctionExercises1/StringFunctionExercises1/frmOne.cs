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

    public partial class frmOne : Form
    {
        public frmOne()
        {
            InitializeComponent();
        }

        private void txtPhrase_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = txtPhrase.Text;
                string trim = text.Trim();

                int lenghtWithWhiteSpace = text.Length;

                int lenghtWithoutWhiteSpace = trim.Length;

                lblDisplay.Text = $"Lenght with whitespaces: {lenghtWithWhiteSpace} {Environment.NewLine}" +
                                  $"Lenght without leading/trailing whitespaces: {lenghtWithoutWhiteSpace} ";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }

        }
    }
}
