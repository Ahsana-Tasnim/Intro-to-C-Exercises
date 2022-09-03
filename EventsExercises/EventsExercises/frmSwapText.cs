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
    /** Ahsana Tasnim 
    * 22 May, 2021 **/

    public partial class frmSwapText : Form
    {
        public frmSwapText()
        {
            InitializeComponent();
        }

        private void txtSecond_Click(object sender, EventArgs e)
        {
        
            txtSecond.Text = txtFirst.Text;
            txtFirst.Text = string.Empty;
        }

        private void txtFirst_Click(object sender, EventArgs e)
        {
            txtFirst.Text = txtSecond.Text;
            txtSecond.Text = string.Empty;
        }
    }
}
