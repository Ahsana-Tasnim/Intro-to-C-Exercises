using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExercises
{
    /** Ahsana Tasnim 
     * 22 May, 2021 **/


    public partial class frmConcatenation : Form
    {
        public frmConcatenation()
        {
            InitializeComponent();
        }


        private void btnShowDate_Click(object sender, EventArgs e)
        {
            lblDisplay1.Text = txtDayOfWeek.Text + ", " +
                               txtMonth.Text + " " + txtDayOfMonth.Text
                                + ", " + txtYear.Text;
            

        }

        private void btnShowDateWithName_Click(object sender, EventArgs e)
        {
           
            lblDisplay2.Text = txtName.Text + Environment.NewLine + txtDayOfWeek.Text + ", " +
                                txtMonth.Text + " " + txtDayOfMonth.Text
                                + ", " + txtYear.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
