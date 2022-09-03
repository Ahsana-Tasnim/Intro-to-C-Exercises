using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryParseDemo
{
    /** Ahsana Tasnim
     * 07 June, 2021 **/


    public partial class frmTryParseDemo : Form
    {
        public frmTryParseDemo()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            /* 
                All numeric types (decimal, double, int) have a TryParse method
                It is used to convert the string representation of a number to its
                numeric equivalent

                It returns a boolean value.  If the string is able to be converted (parsed)
                to the numeric datatype we wish, it will return true, otherwise it will return false

                If it returns true, the numeric equivalent of the string will be stored in
                the "out" parameter
           */

            //int numberValue = 0;

            //bool canConvertToInt = int.TryParse(txtNumber.Text, out numberValue);

            //MessageBox.Show(txtNumber.Text + " can it be converted ?"
            //    + canConvertToInt.ToString() +  ", converted to: " + numberValue);

            bool isInteger = int.TryParse(txtNumber.Text, out int num1);

            string msg = txtNumber.Text + " is not numeric";

            

            if (double.TryParse(txtNumber.Text, out double num2))
            {
                msg = num2 + "is a double";
                

            }

            else if (decimal.TryParse(txtNumber.Text, out decimal num3))
            {
                msg = num3 + " is a decimal";
            }


            if (isInteger)
            {
                msg = num1 + " is an integer";
            }

            MessageBox.Show(msg);
        }
    }
}
