﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "НАЖМИ МЕНЯ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Вы нажа-а-а-а-ли меня!!!!") Close();
            if (button1.Text == "НАЖМИ МЕНЯ") button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
        }
    }
}
