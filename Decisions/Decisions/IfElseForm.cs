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
    public partial class IfElseForm : Form
    {
        public IfElseForm()
        {
            InitializeComponent();
        }

        private void btnDisplayLargest_Click(object sender, EventArgs e)
        {
            // if the user is older than 19, tell them that they are LEGAL
            int age = Convert.ToInt32(txtAge.Text);

            // Otherwise tell them that they are still underage.
            if(age >= 19)
            {
                MessageBox.Show("You are of legal age");
            }
            else
            {
                MessageBox.Show($"You are under age, you are only {age}");

            }
        }
    }
}
