using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopDemo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPopulation_Click(object sender, EventArgs e)
        {
            new frmPopulation().Show();
        }

        private void btnStepDemo_Click(object sender, EventArgs e)
        {
            new frmStepDemo().Show();
        }
    }
}
