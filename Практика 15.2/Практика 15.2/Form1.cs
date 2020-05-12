using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15._2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Перевести в километры") label2.Text = (textBox1.Text != "") ? $"Указанное число миль равно {(Convert.ToDouble(textBox1.Text) * 1.609):F2}км" : "Ошибка : не введено количество миль";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
