using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsExercises
{
    /** Ahsana Tasnim
     * 16 July, 2021 **/

    public partial class frmAddNumbers : Form
    {
        public frmAddNumbers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = 3;
                int number2 = 4;
                int number3 = 6;
                AddNumbs(number1, number2, number3);

                number1 = 8 * 4;
                number2 = 2;
                number3 = 7;
                AddNumbs(number1, number2, number3);

                number1 = 10 * 3;
                number2 = 4 / 2;
                number3 = 3 - 1;
                AddNumbs(number1, number2, number3);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void AddNumbs(int num1, int num2, int num3)
        {
            int total = num1 + num2 + num3;

            lstDisplay.Items.Add(total);
        }
    }
}
