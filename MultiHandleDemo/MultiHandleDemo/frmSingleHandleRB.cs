using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiHandleDemo
{
    /** Ahsana Tasnim
     * 28 June, 2021 **/

    public partial class frmSingleHandleRB : Form
    {
        public frmSingleHandleRB()
        {
            InitializeComponent();
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (rdoRed.Checked)
            {
                lblDisplay.Text = name + "'s favourite colour is: " + rdoRed.Text;
            }
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (rdoGreen.Checked)
            {
                lblDisplay.Text = name + "'s favourite colour is: " + rdoGreen.Text;
            }
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (rdoBlue.Checked)
            {
                lblDisplay.Text = name + "'s favourite colour is: " + rdoBlue.Text;
            }
        }
    }
}
