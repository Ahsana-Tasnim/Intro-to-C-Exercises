using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsExercises
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnDisplayMsg_Click(object sender, EventArgs e)
        {
            new frmAddNumbers().Show();
        }

        private void btnLargestNumber_Click(object sender, EventArgs e)
        {
            new frmLargestNumber().Show();
        }

        private void btnMPG_Click(object sender, EventArgs e)
        {
            new frmMPG().Show();
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            new frmPerimeter().Show();
        }
    }
}
