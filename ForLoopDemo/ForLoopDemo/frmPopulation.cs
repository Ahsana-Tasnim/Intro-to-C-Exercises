using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopDemo
{
    /** Ahsana Tasnim 
     * 05 July, 2021 **/

    public partial class frmPopulation : Form
    {
        public frmPopulation()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double population = 100000;

            for (int i = 2017; i < 2021; i++)
            {
                string output = i.ToString() + "\t\t" + Math.Round(population).ToString();
                lstResults.Items.Add(output);
                population *= 1.04;
            }
        }
    }
}
