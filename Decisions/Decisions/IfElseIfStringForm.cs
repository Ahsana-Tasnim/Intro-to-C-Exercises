using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class IfElseIfStringForm : Form
    {
        public IfElseIfStringForm()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string likeIceCream = txtAnswer.Text.ToLower();

            if(likeIceCream.ToLower() == "yes" || likeIceCream.ToLower() == "y")
            {
                MessageBox.Show("I like Ice cream too !");
            }
            else
            {
                MessageBox.Show("That's too bad");
            }
        }
    }
}
