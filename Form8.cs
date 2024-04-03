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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string text1 = "";
        string text2 = "";
        string text3 = "";
        string text4 = "";
        string text5 = "";
        string text6 = "";
        private void Samsung_CheckedChanged(object sender, EventArgs e)
        {
            if(Samsung.Checked==true)
            {
                text1 = Samsung.Text;
            }
            else
            {
                text1 = "";

            }
        }

        private void Shawami_CheckedChanged(object sender, EventArgs e)
        {
            if (Shawami.Checked == true)
            {
                text2 = Shawami.Text;
            }
            else
            {
                text2 = "";

            }
        }

        private void Oppo_CheckedChanged(object sender, EventArgs e)
        {
            if (Oppo.Checked == true)
            {
                text3 = Oppo.Text;
            }
            else
            {
                text3 = "";

            }
        }

        private void Redme_CheckedChanged(object sender, EventArgs e)
        {
            if (Redme.Checked == true)
            {
                text4 = Redme.Text;
            }
            else
            {
                text4 = "";

            }
        }

        private void Iphone_CheckedChanged(object sender, EventArgs e)
        {
            if (Iphone.Checked == true)
            {
                text5 = Iphone.Text;
            }
            else
            {
                text5 = "";

            }
        }

        private void Nokia_CheckedChanged(object sender, EventArgs e)
        {
            if (Nokia.Checked == true)
            {
                text6 = Nokia.Text;
            }
            else
            {
                text6 = "";

            }
        }

        private void MOBILEBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selected companies are : "+text1+" "+text2+" "+text3+" "+text4+" "+text5+" "+text6);

        }

        private void Enable_CheckedChanged(object sender, EventArgs e)
        {

            MyBtn.Enabled = Enable.Checked;

        }
    }
}
