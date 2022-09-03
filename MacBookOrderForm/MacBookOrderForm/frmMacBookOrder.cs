using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacBookOrderForm
{
    /** Ahsana Tasnim 
     * 23 June, 2021 **/

    public partial class frmMacBookOrder : Form
    {
        public frmMacBookOrder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;

                if (rdo15.Checked)
                {
                    if (rdoModel1.Checked)
                    {
                        total += 1729;
                    }
                    else if (rdoModel2.Checked)
                    {
                        total += 1979;
                    }
                    else
                    {
                        total += 2399;
                    }
                }
                else
                {

                    if (rdoModel1.Checked)
                    {
                        total += 2499;
                    }
                    else if (rdoModel2.Checked)
                    {
                        total += 3199;
                    }
                    else
                    {
                        total += 3699;
                    }
                }

                if (chkFinalCut.Checked)
                {
                    total += 399.99m;
                }
                if (chkLogic.Checked)
                {
                    total += 279.99m;
                }

                lblTotalCost.Text = total.ToString("c");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
