using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"https://d2r9epyceweg5n.cloudfront.net/stores/061/972/products/enzzoo21-502bad272f91ef8bb916333845591302-1024-1024.jpg";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("\\link do site se for site e se for executavel coloca .exe no final");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) 
            {
                string sexo = (radioButton1.Text);
                MessageBox.Show(sexo);
            }

            else
            {
                string sexo = (radioButton2.Text);
                MessageBox.Show(sexo);
            }
        }
    }
}
