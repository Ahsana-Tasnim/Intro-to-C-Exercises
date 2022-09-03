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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            new frmOne().Show();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            new frmTwo().Show();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            new frmThree().Show();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            new frmFour().Show();
        }
    }
}
