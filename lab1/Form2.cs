using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.link.LinkArea = new LinkArea(0, this.link.Text.Length);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            Process.Start("https://vnexpress.net/");
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
            }
        }
        private void dob_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dob.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dob.Focus();
            }
        }
        private void address__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address_.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                address_.Focus();
            }
        }
        private void city__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(city_.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                city_.Focus();
            }
        }
        private void country_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(country.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                country.Focus();
            }
        }
        private void qualification_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(qualification.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qualification.Focus();
            }
        }
        private void doj_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(doj.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doj.Focus();
            }
        }
        private void phone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.Focus();
            }
        }
        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text)
                || string.IsNullOrEmpty(dob.Text)
                || string.IsNullOrEmpty(address_.Text)
                || string.IsNullOrEmpty(city_.Text)
                || string.IsNullOrEmpty(country.Text)
                || string.IsNullOrEmpty(qualification.Text)
                || string.IsNullOrEmpty(phone.Text)
                || string.IsNullOrEmpty(email.Text)
                || string.IsNullOrEmpty(doj.Text) 
             ){
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"{name.Text} \n {dob.Text} \n {address_.Text} \n {city_.Text} \n {country.Text} \n {qualification.Text} \n {phone.Text} \n {email.Text} \n {doj.Text}", "Information in details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
