using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStringFunctions
{
    /** Ahsana Tasnim
     * 28 June, 2021 **/

    public partial class frmStringFunctions : Form
    {
        private const string DEMO_STRING = " The cow jumped over the moon  ";

        public frmStringFunctions()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.tt1.SetToolTip(lblLengthDisplay, "A property that calculates the length " +
                "of the string and returns an integer");

            this.tt1.SetToolTip(lblContainsDisplay, "Checks to see if a specified substring occurs " +
                "in the string, and returls a boolean");

            this.tt1.SetToolTip(lblStartsWithDisplay, "Determines if the beginning of the string\r\n" +
                "matches the specifed string and returns a boolean");

            this.tt1.SetToolTip(lblEndsWithDisplay, "Determines if the end of the string\r\n" +
                "matches the specifed string and returns a boolean");

            this.tt1.SetToolTip(lblToUpperDisplay, "Converts the string to upper case and " +
                "returns the string as upper case");

            this.tt1.SetToolTip(lblToLowerDisplay, "Converts the string to lower case and " +
                "returns the string as lower case");

            this.tt1.SetToolTip(lblTrimDisplay, "Removes all white-space characters from beginning and end " +
                "of string and returns the string without the whitespace.");

            this.tt1.SetToolTip(lblSubstring1Display, "Returns a new string that is a substring of the string. " +
                "The substring starts at a specified character\r\n" +
                "position and continues to the end of the string. The position of the characters in\r\n" +
                "a string begin at zero.  It is zero indexed");

            this.tt1.SetToolTip(lblSubstring2Display, "Retrieves a substring from the string. " +
                "The substring starts at a specified character\r\n" +
                "position and has a specified length. The position of the characters in\r\n" +
                "a string begin at zero.  It is zero indexed");

            this.tt1.SetToolTip(lblIndexOf1Display, "Returns the zero based index of the first occurance " +
                "in the string of the specified character(s).  \r\nIf the sepcified characters do not exist, it will\r\n" +
                "return -1");

            this.tt1.SetToolTip(lblIndexOf2Display, "Returns the zero based index of the first occurance " +
                "in the string beginning at the\r\nspecified position of the specified character(s). If the sepcified\r\n characters do not exist, it will" +
                "return -1");


        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            int strLength = DEMO_STRING.Length;
            lblLength.Text = strLength.ToString();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool containsUmp = DEMO_STRING.Contains("ump");
            lblContains.Text = containsUmp.ToString();
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            bool startsWithThis = DEMO_STRING.StartsWith("This");
            lblStartsWith.Text = startsWithThis.ToString();
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            bool endsWithoon = DEMO_STRING.EndsWith("oon");
            lblEndsWith.Text = endsWithoon.ToString();
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            lblToUpper.Text = DEMO_STRING.ToUpper();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            lblToLower.Text = DEMO_STRING.ToLower();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            lblTrim.Text = DEMO_STRING.Trim();
        }

        private void btnSubstring1_Click(object sender, EventArgs e)
        {
            string position10ToEnd = DEMO_STRING.Substring(10);
            lblSubstring1.Text = position10ToEnd;
        }

        private void btnSubstring2_Click(object sender, EventArgs e)
        {
            string position10With14Chars = DEMO_STRING.Substring(10, 14);
            lblSubstring2.Text = position10With14Chars;
        }

        private void btnIndexOf1_Click(object sender, EventArgs e)
        {
            int positionOfE = DEMO_STRING.IndexOf("e");
            lblIndexOf1.Text = positionOfE.ToString();
        }

        private void btnIndexOf2_Click(object sender, EventArgs e)
        {
            int positionOfE = DEMO_STRING.IndexOf("e", 6);
            lblIndexOf2.Text = positionOfE.ToString();
        }
    }
}
