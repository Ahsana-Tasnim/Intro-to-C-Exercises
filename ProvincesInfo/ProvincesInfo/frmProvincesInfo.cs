using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvincesInfo
{
    /** Ahsana Tasnim
     * 26 June, 2021 **/

    public partial class frmProvincesInfo : Form
    {
        public frmProvincesInfo()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoNL.Checked)
                {
                    if (rdoPopulation.Checked)
                    {
                        lblInfo.Text = "521,542";
                    }
                    else if (rdoCapital.Checked)
                    {
                        lblInfo.Text = "St. John's";
                    }
                    else
                    {
                        lblInfo.Text = "Pitcher Plant";
                    }
                }
                else if (rdoNS.Checked)
                {

                    if (rdoPopulation.Checked)
                    {
                        lblInfo.Text = "971,395";
                    }
                    else if (rdoCapital.Checked)
                    {
                        lblInfo.Text = "Halifax";
                    }
                    else
                    {
                        lblInfo.Text = "Mayflower";
                    }
                }
                else if (rdoPE.Checked)
                {
                    if (rdoPopulation.Checked)
                    {
                        lblInfo.Text = "156,947";
                    }
                    else if (rdoCapital.Checked)
                    {
                        lblInfo.Text = "Charlottetown";
                    }
                    else
                    {
                        lblInfo.Text = "Pink Lady's Slipper";
                    }
                }
                else
                {
                    if (rdoPopulation.Checked)
                    {
                        lblInfo.Text = "776,827";
                    }
                    else if (rdoCapital.Checked)
                    {
                        lblInfo.Text = "Fredericton";
                    }
                    else
                    {
                        lblInfo.Text = "Purple Violet";
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }
    }
}
