using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo_TimeZones
{
    /** Ahsana Tasnim
     * 30 June, 2021 **/

    public partial class frmTimeZones : Form
    {
        public frmTimeZones()
        {
            InitializeComponent();
        }

        private void frmTimeZones_Load(object sender, EventArgs e)
        {
            lstCities.Items.Add("Vancouver");
            lstCities.Items.Add("Calgary");
            lstCities.Items.Add("Regina");
            lstCities.Items.Add("Toronto");
            lstCities.Items.Add("Moncton");
            lstCities.Items.Add("St. John's");
        }

        private void btnTimeZones_Click(object sender, EventArgs e)
        {
            if (lstCities.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a city");
            }
            else
            {
                string city = lstCities.SelectedItem.ToString();

                string timeZone = string.Empty;

                switch (timeZone)
                {
                    case "Vancouver":
                        timeZone = "Pacific";
                        break;
                    case "Calgary":
                        timeZone = "Mountain";
                        break;
                    case "Regina":
                        timeZone = "Central";
                        break;
                    case "Toronto":
                        timeZone = "Eastern";
                        break;
                    case "Moncton":
                        timeZone = "Atlantic";
                        break;
                    case "St. John's":
                        timeZone = "Newfoundland";
                        break;
                }

                lblTimeZone.Text = timeZone;

                //if(city == "Vancouver")
                //{
                //    timeZone = "Pacific";
                //}
                //else if(city == "Calgary")
                //{
                //    timeZone = "Mountain";
                //}
                //else if(city == "Regina")
                //{
                //    timeZone = "Central";
                //}
                //else if(city == "Toronto")
                //{
                //    timeZone = "Eastern";
                //}
                //else if(city == "Moncton")
                //{
                //    timeZone = "Atlantic";
                //}
                //else if(city == "St. John's")
                //{
                //    timeZone = "Newfoundland";
                //}


            }
        }
    }
}
