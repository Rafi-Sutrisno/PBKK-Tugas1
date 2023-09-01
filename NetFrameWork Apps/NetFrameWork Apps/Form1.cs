using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFrameWork_Apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_Clicks(object sender, EventArgs e){

            int n1 = int.Parse(textBox2.Text);
            int n2 = int.Parse(textBox3.Text);
            int n3 = int.Parse(textBox4.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            int total = (n1 * 1000) + (n2 * 2000) + (n3 * 3000);

            textBox5.Text = total.ToString();
        }

        private void but2(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
