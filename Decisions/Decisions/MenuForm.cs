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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnIfStatement_Click(object sender, EventArgs e)
        {
            SimpleIfForm simpleIfForm = new SimpleIfForm();
            simpleIfForm.Show();
        }

        private void btnIfElseStatement_Click(object sender, EventArgs e)
        {
            IfElseForm ifElseForm1 = new IfElseForm();
            ifElseForm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IfElseIfForm ifElseForm2 = new IfElseIfForm();
            ifElseForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IfElseIfStringForm ifElseIfStringForm = new IfElseIfStringForm();
            ifElseIfStringForm.Show();
        }
    }
}
