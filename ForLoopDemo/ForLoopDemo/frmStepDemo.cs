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
    public partial class frmStepDemo : Form
    {
        /** Ahsana Tasnim
         * 05 July, 2021 **/

        public frmStepDemo()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtFrom.Text, out int from) == false)
            {
                MessageBox.Show("Please enter a valid from number.");
                txtFrom.Focus();
                txtFrom.SelectAll();
                return;
            }

            if(int.TryParse(txtTo.Text, out int to) == false)
            {
                MessageBox.Show("Please enter a valid to number.");
                txtTo.Focus();
                txtTo.SelectAll();
                return;
            }

            if (int.TryParse(txtIncrement.Text, out int increment) == false || increment > 0)
            {
                MessageBox.Show("Please enter a positive valid increment number.");
                txtIncrement.Focus();
                txtIncrement.SelectAll();
                return;
            }

            for (int i = from; i <= to; i += increment)
            {
                lstDisplay.Items.Add(i);
            }
        }
    }
}
