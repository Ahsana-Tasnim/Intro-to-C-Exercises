using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppRadioButtonEx
{
    /** Ahsana Tasnim 
     * 26 June, 2021 **/

    public partial class frmWeather : Form
    {
        public frmWeather()
        {
            InitializeComponent();
        }

        private void btnWhatToDo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtTemperature.Text, out decimal temp))
                {
                    MessageBox.Show("Please enter a valid temperature", "Invalid Data!");
                }
                else
                {
                    if (rdoCloudy.Checked)
                    {
                        MessageBox.Show("Stay Inside!");
                    }
                    else if (rdoSunny.Checked && temp > 25)
                    {
                        MessageBox.Show("Go to beach!");
                    }
                    else if (temp < 10 && (rdoSnowy.Checked || rdoRainy.Checked))
                    {
                        MessageBox.Show("Bundle up!");
                    }
                    else
                    {
                        MessageBox.Show("I have no idea what you should do.");
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
