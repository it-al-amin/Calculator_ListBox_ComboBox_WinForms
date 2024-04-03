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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked==true)
            {
                MessageBox.Show("You have selected : " + radioButton1.Text);
            }
            else if( radioButton2.Checked == true)
            {
                MessageBox.Show("You have selected : " + radioButton2.Text);
            }
           else if( radioButton3.Checked == true)
            {
                MessageBox.Show("You have selected : " + radioButton3.Text);
            }
            else
            {
                MessageBox.Show("Please select a country! ");
            }
        }

        private void Colorbutton_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                groupBox.BackColor = Color.Green;
                MessageBox.Show("You have selected : " + radioButton5.Text);
            }
            else if (radioButton6.Checked == true)
            {
                groupBox.BackColor = Color.Red;
                MessageBox.Show("You have selected : " + radioButton6.Text);
            }
            else if (radioButton7.Checked == true)
            {
                groupBox.BackColor = Color.Blue;
                MessageBox.Show("You have selected : " + radioButton7.Text);
            }
            else if (radioButton8.Checked == true)
            {
                groupBox.BackColor = Color.Orange;
                MessageBox.Show("You have selected : " + radioButton8.Text);
            }
            else
            {
                MessageBox.Show("Please select a color! ");
            }
        }

        private void ChangeColorbutton_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
           else if (radioButton9.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else if (radioButton10.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            else if (radioButton11.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                MessageBox.Show("Please select a color! ");
            }
        }
    }
}
