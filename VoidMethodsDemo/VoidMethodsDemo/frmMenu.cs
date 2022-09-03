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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new frmExample1().Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            new frmExample2().Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            new frmExample3().Show();
        }
    }
}
