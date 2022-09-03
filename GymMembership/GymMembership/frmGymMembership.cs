using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembership
{
    /** Ahsana Tasnim 
     * 26 June, 2021 **/

    public partial class frmGymMembership : Form
    {
        public frmGymMembership()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal fee = 0;

                if (rdoStudent.Checked)
                {
                    fee = 30;
                }
                else if (rdoAdult.Checked)
                {
                    fee = 60;
                }
                else
                {
                    fee = 40;
                }

                if (chkPrivateLockerRoom.Checked)
                {
                    fee += 10;
                }
                if (chkSpaAccess.Checked)
                {
                    fee += 20;
                }
                if (chkTowelService.Checked)
                {
                    fee += 15;
                }

                lblTotalFee.Text = fee.ToString("c");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }
    }
}
