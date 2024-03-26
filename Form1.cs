using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // read data from textBox 
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                //MessageBox.Show(result.ToString());//convert int to string 

                Resultlbl.Text = "Addition result is : " + (result.ToString());
                Resultlbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields!!");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            // read data from textBox 
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                //MessageBox.Show(result.ToString());//convert int to string 

                Resultlbl.Text = "Subtraction result is : " + (result.ToString());
                Resultlbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields!!");
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            // read data from textBox 
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                //MessageBox.Show(result.ToString());//convert int to string 

                Resultlbl.Text = "Multiplication result is : " + (result.ToString());
                Resultlbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields!!");
            }
        }

        private void DivisoonButton_Click(object sender, EventArgs e)
        {
            // read data from textBox 
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 / num2;
                //MessageBox.Show(result.ToString());//convert int to string 

                Resultlbl.Text = "Division result is : " + (result.ToString());
                Resultlbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill both fields!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void AnotherPageBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to navigate to
            Form2 anotherForm = new Form2();

            // Show the new form
            anotherForm.Show();

            // Optionally, you can hide the current form if you want
            this.Hide();
        }
    }
}
