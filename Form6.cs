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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
        //whem click the button data will be showed;
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Form5.text1;
            label3.Text = Form5.text2;
            label2.Visible = true;
            label3.Visible = true;
        }
    }
}
