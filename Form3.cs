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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (HobbiesComboBox.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("This Item is already exists!");
                }
                else
                {
                    HobbiesComboBox.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();//cursor still this box
                }
            }
            else
            {
                MessageBox.Show("Enter one item first!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total items are " + HobbiesComboBox.Items.Count);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (HobbiesComboBox.SelectedIndex != -1)
            {
                HobbiesComboBox.Items.RemoveAt(HobbiesComboBox.SelectedIndex);
                MessageBox.Show("Remove one time successfully!");
            }
            else
            {
                MessageBox.Show("Please select one item first !");

            }
        }

        private void HobbiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label2.Text ="Your selected item is "+HobbiesComboBox.SelectedItem.ToString();
            label2.Visible = true;

        }

        private void linkLabelbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to navigate to
            Form4 anotherForm = new Form4();

            // Show the new form
            anotherForm.Show();

            // Optionally, you can hide the current form if you want
            this.Hide();
        }
    }
}
