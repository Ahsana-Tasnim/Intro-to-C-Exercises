using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercies3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            new frmEx1GrossPay().Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            new frmEx2Speed().Show();
        }

    }
}
