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
    public partial class frmNameAndNumber : Form
    {
        public frmNameAndNumber()
        {
            InitializeComponent();
        }

        private void lblEnter_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your full name";
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your phone number";
        }
    }
}
