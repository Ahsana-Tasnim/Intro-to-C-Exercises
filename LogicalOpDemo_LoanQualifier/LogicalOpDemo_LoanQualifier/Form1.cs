using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalOpDemo_LoanQualifier
{
    public partial class Form1 : Form
    {
        /** Ahsana Tasnim 
    * 02 June 2021 **/

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal annualSalary = Convert.ToDecimal(txtSalary.Text);
            int numYears = Convert.ToInt32(txtNumYears.Text);

            if((annualSalary >= 30000 && numYears >= 2) || numYears >=5)
            {
                lblDisplay.Text = "Congrats ! You qualify for the loan";
                lblDisplay.ForeColor = Color.Green;
            }
            else
            {
                lblDisplay.Text = "Sorry you don't qualify for the loan";
                lblDisplay.ForeColor = Color.Red;
            }

            txtSalary.Focus();
            txtSalary.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Text = string.Empty;
            txtNumYears.Text = string.Empty;

            lblDisplay.Text = string.Empty;

            txtSalary.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
