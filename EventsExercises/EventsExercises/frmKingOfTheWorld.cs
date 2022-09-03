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

    public partial class frmKingOfTheWorld : Form
    {
        public frmKingOfTheWorld()
        {
            InitializeComponent();
        }

        private void lblSecond_MouseEnter(object sender, EventArgs e)
        {
            lblSecond.ForeColor = Color.Red;

        }

        private void lblSecond_MouseLeave(object sender, EventArgs e)
        {
            lblSecond.ForeColor = Color.Black;
        }

        private void lblFirst_MouseEnter(object sender, EventArgs e)
        {
            lblFirst.ForeColor = Color.Red;
        }

        private void lblFirst_MouseLeave(object sender, EventArgs e)
        {
            lblFirst.ForeColor = Color.Black;
        }

        private void lblThird_MouseEnter(object sender, EventArgs e)
        {
            lblThird.ForeColor = Color.Red;
        }

        private void lblThird_MouseLeave(object sender, EventArgs e)
        {
            lblThird.ForeColor = Color.Black;
        }
    }
}
