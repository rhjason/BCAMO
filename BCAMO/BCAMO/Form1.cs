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
        private int otetsin;                //otets is the default supported ToString autoconversions (one two eight ten sixteen)
        private int otetsout;               //otets is the default supported ToString autoconversions (one two eight ten sixteen)
        private string stringinput;         //input for textbox1 (aka the input)
        private string stringoutput;        //output for textbox2 (aka output)
        private int intermediateint;
        private string displayinput;
        private string displayoutput;
        basetootherbase baseconvert = new basetootherbase(); 

        public Form1()
        {
            InitializeComponent();
            this.Text = "Base Conversion & Mathematics Operations Tool";
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.otetsin = 2;
            convertFromToolStripMenuItem.Text = "From Binary : ";
            //intermediateint = baseconvert.Tobase10(otetsin, textBox1.Text);
        }

        private void octalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otetsin = 8;
            convertFromToolStripMenuItem.Text = "From Octal : ";
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.otetsin = 10;
            convertFromToolStripMenuItem.Text = "From Decimal : ";
        }

        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.otetsin = 16;
            convertFromToolStripMenuItem.Text = "From Hexadecimal : ";
        }

        //Toolstrip menu items for output
        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otetsout = 2;
            convertIntoToolStripMenuItem.Text = "Into Binary : ";
        }

        private void octalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otetsout = 8;
            convertIntoToolStripMenuItem.Text = "Into Octal : ";
        }

        private void decimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otetsout = 10;
            convertIntoToolStripMenuItem.Text = "Into Decimal : ";
            intermediateint = baseconvert.Tobase10(otetsin, textBox1.Text);
        }

        private void hexadecimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.otetsout = 16;
            convertIntoToolStripMenuItem.Text = "Into Hex : ";
        }

        private void convertbutton_Click(object sender, EventArgs e)
        {
            int integer;
            if ((baseconvert.basic(otetsout)) && (otetsin == 10))
            {
                if (Int32.TryParse(textBox1.Text, out integer))
                {
                    this.stringoutput = Convert.ToString(integer, otetsout);
                }
                else
                {
                    this.stringoutput = "Error, Value entered was not an integer";
                }
            }
            if(otetsout == 10)
            {
                this.stringoutput = intermediateint.ToString();
            }
            textBox2.Text = this.stringoutput;
        }
    }


    public class basetootherbase
    {
        private int trackbase;
        private bool noerrorflag = true;
        public basetootherbase()
        {}
        
        public bool sizefit(int basevalue, string inputstring)
        {
            bool tempoutput = false;
            switch (basevalue)
            {
                case 0:
                    tempoutput = false;
                    break;
                case 1:
                    tempoutput = false;
                    break;;
                case 2:
                    if(inputstring.Length > 31)
                    {
                        tempoutput = false;
                    }
                    else tempoutput = true;
                    break;
                case 8:
                    if (inputstring.Length > 11)
                    {
                        tempoutput = false;
                    }
                    else tempoutput = true;
                    break;
                case 10:
                    if (inputstring.Length > 10)
                    {
                        tempoutput = false;
                    }
                    else tempoutput = true;
                    break;
                case 16:
                    if (inputstring.Length > 8)
                    {
                        tempoutput = false;
                    }
                    else tempoutput = true;
                    break;
            }
            return tempoutput;
        }

        public int Tobase10(int basevalue, string valuetoconvert)
        {
            int temp = basevalue;
            int templen = valuetoconvert.Length;
            string tempvalue = valuetoconvert;
            int output = 0;
            switch (temp)
            {
                case 2:
                    for (int j = 0; j < templen; j++)
                    {
                        int tempactualvalue = templen - 1;
                        switch (valuetoconvert[j])
                        {
                            case '0':
                                break;
                            case '1':
                                output = output + (int)Math.Pow(2, tempactualvalue - j);
                                break;
                            default:
                                noerrorflag = false;
                                break;
                        }
                        /*
                        if (tempvalue[j] == '0')
                        {
                            output = output + 0;
                        }
                        else if (tempvalue[j] == '1')
                        {
                            output = output + (int)Math.Pow(2, j);
                        }
                        else output = -1;
                        */
                    }
                        break;
            }
            /*
            if (basevalue == 3)
            {
                return output;
            }
            else if (basevalue == 4)
            {
                int templength = valuetoconvert.Length;
                for (int i = 0; i < templength; i++)
                {
                    //valuetoconvert[i];
                }
                return output;
            }
            */
            return output;
        }

        public string Tobase3(int basevalue, string valuetoconvert)
        {
            trackbase = basevalue;
            if (basevalue == 3)
            {
                return valuetoconvert;
            }
            else if(basevalue == 4)
            {
                int templength = valuetoconvert.Length;
                for (int i = 0; i < templength; i++ )
                {
                    //valuetoconvert[i];
                }
                    return "0";
            }
            return "0";
        }

        public bool basic(int basevalue)
        {
            if ((basevalue == 1) || (basevalue == 2) || (basevalue == 8) || (basevalue == 10) || (basevalue == 16))
            {
                return true;
            }
            else return false;
        }

        public bool error()
        {
            return this.noerrorflag;
        }
    }
}
