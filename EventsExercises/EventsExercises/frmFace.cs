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
    public partial class frmFace : Form
    {
        public frmFace()
        {
            InitializeComponent();
        }

        private void lblHappy_MouseEnter(object sender, EventArgs e)
        {
            lblFace.Text = "J";
        }

        private void lblSad_MouseEnter(object sender, EventArgs e)
        {
            lblFace.Text = "L";
        }

        private void lblSad_MouseLeave(object sender, EventArgs e)
        {
            lblFace.Text = string.Empty;
        }

        private void lblHappy_MouseLeave(object sender, EventArgs e)
        {
            lblFace.Text = string.Empty;
        }
    }
}
