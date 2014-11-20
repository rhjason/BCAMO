using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCAMO
{
    public partial class Form1 : Form
    {
        private int otets;                  //otets is the default supported ToString autoconversions (one two eight ten sixteen)
        private string stringinput;         //input for textbox1 (aka the input)
        private string stringoutput;        //output for textbox2 (aka output)
        private string displayinput;
        private string displayoutput;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Base Conversion & Mathematics Operations Tool";
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otets = 2;
            convertFromToolStripMenuItem.Text = "From Binary : ";
        }

        private void octalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otets = 8;
            convertFromToolStripMenuItem.Text = "From Octal : ";
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otets = 10;
            convertFromToolStripMenuItem.Text = "From Decimal : ";
        }

        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otets = 16;
            convertFromToolStripMenuItem.Text = "From Hexadecimal : ";
        }

        //Toolstrip menu items for output
        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otets = 2;
            convertIntoToolStripMenuItem.Text = "Into Binary : ";
        }

        private void octalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otets = 8;
            convertIntoToolStripMenuItem.Text = "Into Octal : ";
        }

        private void decimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otets = 10;
            convertIntoToolStripMenuItem.Text = "Into Decimal : ";
        }

        private void hexadecimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otets = 16;
            convertIntoToolStripMenuItem.Text = "Into Hex : ";
        }

        private void convertbutton_Click(object sender, EventArgs e)
        {
            int integer = 0;
            if (Int32.TryParse(textBox1.Text, out integer))
            {
                this.stringoutput = Convert.ToString(integer, otets);
            }
            else
            {
                this.stringoutput = "Error, Value entered was not an integer";
            }
            textBox2.Text = this.stringoutput;
        }
    }
}
