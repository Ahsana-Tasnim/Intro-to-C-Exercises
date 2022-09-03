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
    public partial class IfElseIfForm : Form
    {
        public IfElseIfForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int NUM_SCORES = 5;

            double score1 = Convert.ToDouble(txtTestScore1.Text);
            double score2 = Convert.ToDouble(txtTestScore2.Text);
            double score3 = Convert.ToDouble(txtTestScore3.Text);
            double score4 = Convert.ToDouble(txtTestScore4.Text);
            double score5 = Convert.ToDouble(txtTestScore5.Text);

            double average = Math.Round((score1 + score2 + score3 + score4 + score5) / NUM_SCORES,2);
            string grade;

            lblAverage.Text = average.ToString();

            if(average >= 90)
            {
                grade = "A";
            }
            else if(average >=80) {
                grade = "B";
            }
            else if(average >= 70)
            {
                grade = "C";
            }
            else if(average >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            lblMessage.Text = $"Your grade is {grade}";

            // DISPLAY THE LETTER GRADE TO THE USER
            // 90 and above A
            // 80-89 B
            // 70-79 C
            // 60-69 D
            // Below 60 F
        }
    }
}
