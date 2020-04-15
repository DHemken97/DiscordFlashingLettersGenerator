using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animated_Char_replacement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chars = richTextBox1.Text.ToArray();
            richTextBox1.Text = string.Empty;
            foreach(var chr in chars)
            {
                if (chr.ToString().ToUpper() == chr.ToString().ToLower())
                    richTextBox1.Text += chr.ToString();
                else
                    richTextBox1.Text += $":0{chr.ToString().ToUpper()}:";
            }
            Clipboard.SetText(richTextBox1.Text);
        }
    }
}
