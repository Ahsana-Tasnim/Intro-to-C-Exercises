using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class WhatShouldIWearIfElseForm : Form
    {
        public WhatShouldIWearIfElseForm()
        {
            InitializeComponent();
        }

        private void btnWhatToWear_Click(object sender, EventArgs e)
        {
            // if the temperature is 12 or less, tell the user that it is going to be a bit
            // cool and that they should wear their jacket.  Also tell them that the sun 
            // may or may
            // not come out depending on what is entered.
            // otherwise, tell them that it is going to be a nice warm day, 
            // so jacket is optional Also tell them that the sun 
            // may or may


        }

        private void btnOtherSuggestions_Click(object sender, EventArgs e)
        {
            // if it will be sunny AND the temperature will be greater than 22, tell them 
            // it will be a gread day to wear shorts

            // if it will be sunny OR the temperature will be greater than 30
            // tell them it would be a good day to stay in some air conditioning
        }
    }
}
