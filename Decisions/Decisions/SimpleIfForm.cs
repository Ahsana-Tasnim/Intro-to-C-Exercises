using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class SimpleIfForm : Form
    {
        const int HIGH_SCORE = 90;
        const int NUM_SCORES = 5;

        public SimpleIfForm()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal testValue1 = Convert.ToDecimal(txtTestScore1.Text);
            decimal testValue2 = Convert.ToDecimal(txtTestScore2.Text);
            decimal testValue3 = Convert.ToDecimal(txtTestScore3.Text);
            decimal testValue4 = Convert.ToDecimal(txtTestScore4.Text);
            decimal testValue5 = Convert.ToDecimal(txtTestScore5.Text);

            decimal average = (testValue1 + testValue2 + testValue3 + testValue4 + testValue5);
            // Calculate average and display it in the label
            lblAverage.Text = average.ToString();
            // Show congratulations message to user if they get a high score

            if (average > HIGH_SCORE)
            {
                lblMessage.Text = "Congratulations!"; 
            }
            else
            {
                lblMessage.Text = string.Empty;
            }
        }   

    }
}
