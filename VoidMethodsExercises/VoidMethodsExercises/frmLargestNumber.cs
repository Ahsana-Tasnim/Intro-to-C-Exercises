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

    public partial class frmLargestNumber : Form
    {
        public frmLargestNumber()
        {
            InitializeComponent();
        }

        private void frmLargestNumber_Load(object sender, EventArgs e)
        {
            for (int firstNum = 1; firstNum < 11; firstNum++)
            {
                cboFirstNum.Items.Add(firstNum);
            }

            for (int secondNum = 1; secondNum < 11; secondNum++)
            {
                cboSecondNum.Items.Add(secondNum);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(cboFirstNum.SelectedItem);
                int secondNumber = Convert.ToInt32(cboSecondNum.SelectedItem);

                if (cboFirstNum.SelectedItem == null)
                {
                    MessageBox.Show("Please select the first number");
                    return;
                }

                if (cboSecondNum.SelectedItem == null)
                {
                    MessageBox.Show("Please select the second number");
                    return;
                }

                FindLargest(firstNumber, secondNumber);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }



        private void FindLargest(int firstNum, int secondNum)
        {

            if (firstNum > secondNum)
            {
                MessageBox.Show($"The largest number is the first number");
            }
            else
            {
                MessageBox.Show($"The largest number is the second number");
            }
        }
    }
}
