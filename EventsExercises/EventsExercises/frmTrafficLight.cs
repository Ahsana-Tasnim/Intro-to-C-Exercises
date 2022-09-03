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


    public partial class frmTrafficLight : Form
    {
        public frmTrafficLight()
        {
            InitializeComponent();
        }

        private void txtYellow_Enter(object sender, EventArgs e)
        {
            txtRed.BackColor = Color.White;
            txtYellow.BackColor = Color.Yellow;
        }

        private void txtGreen_Enter(object sender, EventArgs e)
        {
            txtYellow.BackColor = Color.White;
            txtGreen.BackColor = Color.Green;
        }

        private void txtRed_Enter(object sender, EventArgs e)
        {
            txtGreen.BackColor = Color.White;
            txtRed.BackColor = Color.Red;
        }
    }
}
