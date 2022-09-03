using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsExercises2
{
    /** Ahsana Tasnim
     * 06 June 2021 **/


    public partial class frmEx2Pencils : Form
    {
        const decimal SMALL_ORDER_RATE = 0.25m;
        const decimal BIG_ORDER_RATE = 0.2m;
        public frmEx2Pencils()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int numberofPencil = Convert.ToInt32(txtNumPencils.Text);

                decimal smallOrderPrice = Convert.ToDecimal(numberofPencil) * SMALL_ORDER_RATE;
                decimal bigOrderPrice = Convert.ToDecimal(numberofPencil) * BIG_ORDER_RATE;

                if (numberofPencil > 0 && numberofPencil < 100)
                {
                    lblDisplay.Text = smallOrderPrice.ToString("c");
                }
                else
                {
                    lblDisplay.Text = bigOrderPrice.ToString("c");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
               
            }
           
        }
    }
}
