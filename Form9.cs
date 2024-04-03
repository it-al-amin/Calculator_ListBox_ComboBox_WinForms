using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Calculator_WinForms
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();//if empty stay in same textBox
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Please fill the name!");
                //MessageBox.Show("Please fill the name!");

            }
            else
            {
                errorProvider1.Clear();
              //errorProvider1.Icon = Properties.Resources.check;
            }
        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])" +
            "*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text,pattern))
            {
                textBox3.Focus();//if empty stay in same textBox
                errorProvider3.SetError(this.textBox3, "Invalid email");

               // MessageBox.Show("Please fill the name!");

            }
            else
            {
                errorProvider3.Clear();
            }
        }
        string pass = @"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox4.Text,pass))
            {
                textBox4.Focus();//if empty stay in same textBox
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider4.SetError(this.textBox4, "Please fill the correct password!");
                //MessageBox.Show("Please fill the name!");

            }
            else
            {
                errorProvider4.Clear();
                //errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text!=textBox5.Text)
            {
                textBox5.Focus();//if empty stay in same textBox
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider5.SetError(this.textBox5, "Please fill the correct password!");
                //MessageBox.Show("Please fill the name!");

            }
            else
            {
                errorProvider5.Clear();
                //errorProvider1.Icon = Properties.Resources.check;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();//if empty stay in same textBox
                errorProvider1.SetError(this.textBox1, "Please fill the name!");
                //MessageBox.Show("Please fill the name!");

            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();//if empty stay in same textBox
                errorProvider2.SetError(this.textBox2, "Please fill the age!");
                //MessageBox.Show("Please fill the age!");

            }
            else if (!Regex.IsMatch(textBox3.Text, pattern))
            {
                textBox3.Focus();//if empty stay in same textBox
                errorProvider3.SetError(this.textBox3, "Invalid email!");
                
                // MessageBox.Show("Please fill the name!");

            }
            else if (!Regex.IsMatch(textBox4.Text, pass))
            {
                textBox4.Focus();//if empty stay in same textBox
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider4.SetError(this.textBox4, "Please fill the correct password!");
                //MessageBox.Show("Please fill the name!");

            }
            else if (!Regex.IsMatch(textBox5.Text, pass) || textBox4.Text != textBox5.Text)
            {
                textBox5.Focus();//if empty stay in same textBox
                //errorProvider1.Icon = Properties.Resources.error;
                errorProvider5.SetError(this.textBox5, "Please fill the correct password!");
                //MessageBox.Show("Please fill the name!");

            }
            else 
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1_Leave(sender, e);
                MessageBox.Show("Welcome", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

       
    }
}
