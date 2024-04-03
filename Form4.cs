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
namespace Calculator_WinForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void GooglelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "http://www.google.com",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.GooglelinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;//remove link under line
            this.PassingData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void PassingData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 an = new Form5();
            an.Show();
            this.Hide();
        }

        private void Radio_Button_Control_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 an = new Form7();
            an.Show();
            this.Hide();
        }

        private void CheckBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 an = new Form8();
            an.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 an = new Form9();
            an.Show();
            this.Hide();
        }
    }
}
