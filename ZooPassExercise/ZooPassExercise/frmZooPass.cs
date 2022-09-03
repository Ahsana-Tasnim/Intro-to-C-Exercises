using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPassExercise
{
    /** Ahsana Tasnim
     * 03 July, 2021 **/

    public partial class frmZooPass : Form
    {
        private int optionCount = 0;
        public frmZooPass()
        {
            InitializeComponent();
        }

        private void frmZooPass_Load(object sender, EventArgs e)
        {
            cboPassLength.Items.Add("1 Day");
            cboPassLength.Items.Add("2 Day");
            cboPassLength.Items.Add("5 Day");

            lblNumPasses.Text = "0";
        }

        private void btnAddPass_Click(object sender, EventArgs e)
        {
            try
            {

                if (cboPassLength.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a pass lenght.", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedPass = cboPassLength.SelectedItem.ToString();


                string selectOption;

                if (rdoAdult.Checked)
                {
                    selectOption = "Adult";
                }
                else
                {
                    selectOption = "Child";
                }

                string selectType = string.Empty;

                if (chkVip.Checked)
                {
                    selectType += chkVip.Text;
                    optionCount++;
                }
                if (chkTrainor.Checked)
                {
                    if (optionCount > 0)
                    {
                        selectType += ",";
                    }
                    selectType += chkTrainor.Text;
                    optionCount++;
                }
                if (chkMonkeyShow.Checked)
                {
                    if (optionCount > 0)
                    {
                        selectType += ",";
                    }
                    selectType += chkMonkeyShow.Text;
                    optionCount++;
                }

                if (optionCount < 2)
                {
                    MessageBox.Show("You must select at least two options.");
                }
                else
                {
                    lstPasses.Items.Add(selectedPass + " - " + selectOption + " - " + selectType);

                    lblNumPasses.Text = lstPasses.Items.Count.ToString();

                    cboPassLength.Text = string.Empty;
                    rdoAdult.Checked = true;
                    chkMonkeyShow.Checked = false;
                    chkTrainor.Checked = false;
                    chkVip.Checked = false;

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }

        }

        private void RemovePass_Click(object sender, EventArgs e)
        {

            if (lstPasses.SelectedIndex >= 0)
            {
                lstPasses.Items.Remove(lstPasses.SelectedItem);
                optionCount--;
                lblNumPasses.Text = lstPasses.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Please select a pass to remove.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPasses_DoubleClick(object sender, EventArgs e)
        {
            RemovePass_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmZooPass_Load(sender, e);
        }


        private void frmZooPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult formClose = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (formClose == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            if (formClose == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}