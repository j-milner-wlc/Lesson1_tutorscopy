using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArt2CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] origAsciiArtByLine = textBoxOrigAsciiArt.Lines;
            string cSharpCode = "String asciiArt = ";
            string linePrefix = "";
            Boolean origAsciiArtFitsIn80CharTerminal = true;

            foreach(string asciiArtLine in origAsciiArtByLine)
            {
                if (asciiArtLine.Length > 80)
                {
                    origAsciiArtFitsIn80CharTerminal = false;
                }
                cSharpCode += linePrefix + "\"" + asciiArtLine.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
                linePrefix = " + " + Environment.NewLine;
            }
            cSharpCode += ";";
            textBoxGeneratedCSharpCode.Text = cSharpCode;


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
