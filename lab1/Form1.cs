using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
            if (this.red.Checked)
            {
                this.displayedTextBox.ForeColor = Color.Red;
            }
        }
        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            if (this.blue.Checked)
            {
                this.displayedTextBox.ForeColor = Color.Blue;
            }
        }
        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (this.green.Checked)
            {
                this.displayedTextBox.ForeColor = Color.Green;
            }
        }
        private void black_CheckedChanged(object sender, EventArgs e)
        {
            if (this.black.Checked)
            {
                this.displayedTextBox.ForeColor = Color.Black;
            }
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            if (this.bold.Checked)
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style | FontStyle.Bold);
            }
            else
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style & ~FontStyle.Bold);
            }
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            if (this.italic.Checked)
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style | FontStyle.Italic);
            }
            else
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style & ~FontStyle.Italic);
            }
        }

        private void underline_CheckedChanged(object sender, EventArgs e)
        {
            if (this.underline.Checked)
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style | FontStyle.Underline);
            }
            else
            {
                this.displayedTextBox.Font = new Font(this.displayedTextBox.Font, this.displayedTextBox.Font.Style & ~FontStyle.Underline);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.displayedTextBox.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.red.Checked = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
