using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonVoidExercises
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnValidateInput_Click(object sender, EventArgs e)
        {
            new frmValidateInput().Show();
        }

        private void btnAddNumbers_Click(object sender, EventArgs e)
        {
            new frmAddNumbers().Show();
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            new frmFullName().Show();
        }

        private void frmMPG_Click(object sender, EventArgs e)
        {
            new frmMPG().Show();
        }
    }
}
