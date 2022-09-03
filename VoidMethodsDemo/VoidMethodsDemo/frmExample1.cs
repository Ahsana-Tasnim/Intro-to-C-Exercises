using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidMethodsDemo
{
    /** Ahsana Tasnim
     * 12 July, 2021 **/

    public partial class frmExample1 : Form
    {
        public frmExample1()
        {
            InitializeComponent();
        }

        private void frmExample1_Load(object sender, EventArgs e)
        {
            FillNamesList();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();

                if (name == string.Empty)
                {
                    MessageBox.Show("Please enter a name.");
                    return;
                }

                int newNameIndex = cboNames.Items.Add(name);
                cboNames.SelectedIndex = newNameIndex;

                txtName.Focus();
                txtName.SelectAll();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.GetType().ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillNamesList();
            txtName.Text = string.Empty;
        }

        private void FillNamesList()
        {
            cboNames.Items.Clear();

            cboNames.Items.Add("Fred");
            cboNames.Items.Add("Sally");
            cboNames.Items.Add("Jack");
            cboNames.Items.Add("Alice");
            cboNames.Items.Add("Judy");

            cboNames.Sorted = true;
            cboNames.SelectedIndex = 0;
        }
    }
}
