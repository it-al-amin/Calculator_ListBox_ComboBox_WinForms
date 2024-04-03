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
    public partial class Form5 : Form
    {
        public static string text1;
        public static string text2;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                text1 = textBox1.Text;
                text2 = textBox2.Text;
                Form6 ano = new Form6();
                ano.Show();
            }
            else
            {
                MessageBox.Show("Fill all the fields first!");
            }
           
        }
    }
}
