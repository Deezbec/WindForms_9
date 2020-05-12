using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Поприветствовать") textBox2.Text = (textBox1.Text != "")?$"Здравствуй, {textBox1.Text}!!!" : "Здравствуй, мир!!!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
