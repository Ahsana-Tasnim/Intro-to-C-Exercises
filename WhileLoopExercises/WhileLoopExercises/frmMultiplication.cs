using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoopExercises
{
    /** Ahsana Tasnim
     * 11 July, 2021 **/

    public partial class frmMultiplication : Form
    {
        public frmMultiplication()
        {
            InitializeComponent();
        }

        private void frmMultiplication_Load(object sender, EventArgs e)
        {
            cboNumber.Items.Add("1");
            cboNumber.Items.Add("2");
            cboNumber.Items.Add("3");
            cboNumber.Items.Add("4");
            cboNumber.Items.Add("5");
            cboNumber.Items.Add("6");
            cboNumber.Items.Add("7");
            cboNumber.Items.Add("8");
            cboNumber.Items.Add("9");
            cboNumber.Items.Add("10");
            cboNumber.Items.Add("11");
            cboNumber.Items.Add("12");
        }

        private void cboNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int selectedNumber = Convert.ToInt32(cboNumber.SelectedItem);
                int increment = 0;

                lstMultiplicationTable.Items.Clear();

                while (increment <= selectedNumber)
                {
                    int result = increment * selectedNumber;
                    lstMultiplicationTable.Items.Add(increment + "x " + selectedNumber + " = " + result);
                    increment++;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
            

           
        }

       
    }
}
