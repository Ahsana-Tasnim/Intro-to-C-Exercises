using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsDemo
{
    /** Ahsana Tasnim
     * 12 July, 2021 **/

    public partial class frmExample2 : Form
    {
        public frmExample2()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            DisplayNumber(10);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            DisplayNumber(10 + 6);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                DisplayNumber(i);
            }
        }

        private void DisplayNumber(int number)
        {
            MessageBox.Show(number.ToString());
        }
    }
}
