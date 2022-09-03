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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNameAndNumber_Click(object sender, EventArgs e)
        {
            new frmNameAndNumber().Show();
        }

        private void btnFaces_Click(object sender, EventArgs e)
        {
            new frmFace().Show();
        }

        private void btnSwapText_Click(object sender, EventArgs e)
        {
            new frmSwapText().Show();
        }

        private void btnKingOfTheWorld_Click(object sender, EventArgs e)
        {
            new frmKingOfTheWorld().Show();
        }

        private void btnTrafficLight_Click(object sender, EventArgs e)
        {
            new frmTrafficLight().Show();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            new frmConcatenation().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
