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

    public partial class frmMultiHandleRB : Form
    {
        public frmMultiHandleRB()
        {
            InitializeComponent();
        }


        private void ColourChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rb = (RadioButton)sender;

                if (rb.Checked)
                {
                    string name = txtName.Text.Trim();

                    lblDisplay.Text = name + "'s favourite colour is: " + rb.Text;
                }

                if (sender == rdoBlue)
                {
                    lblDisplay.Text += " Blue !";
                }
            }
        }

    }
}
