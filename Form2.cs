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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cnt= FruitsListBox.Items.Count;
            MessageBox.Show("List of items are : " + cnt.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitsListBox.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FruitsListBox.Items.Remove(FruitsListBox.SelectedItem);
            if (FruitsListBox.SelectedIndex!=-1)
            {
                FruitsListBox.Items.RemoveAt(FruitsListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select the specific Item");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to navigate to
            ComboBox anotherForm = new ComboBox();

            // Show the new form
            anotherForm.Show();

            // Optionally, you can hide the current form if you want
            this.Hide();
        }
    }
}
