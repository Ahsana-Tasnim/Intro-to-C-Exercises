using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeBenefitsCheckedChng
{ /** Ahsana Tasnim 
   * 28 June, 2021 **/

    public partial class frmEmpBenefits : Form
    {
        private decimal cost;

        public frmEmpBenefits()
        {
            InitializeComponent();
        }


        private void chkDrugPlan_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkDrugPlan.Checked)
            {
                cost += 45.19m;
            }
            else
            {
                cost -= 45.19m;
            }

            lblMonthlyCost.Text = cost.ToString("c");
        }

        private void chkDental_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkDental.Checked)
            {
                cost += 18.21m;
            }
            else
            {
                cost -= 18.21m;
            }

            lblMonthlyCost.Text = cost.ToString("c");
        }

        private void chkLife_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkLife.Checked)
            {
                cost += 4.32m;
            }
            else
            {
                cost -= 4.32m;
            }

            lblMonthlyCost.Text = cost.ToString("c");
        }

        private void chkLTD_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkLTD.Checked)
            {
                cost += 12.45m;
            }
            else
            {
                cost -= 12.45m;
            }

            lblMonthlyCost.Text = cost.ToString("c");
        }
    }
}
