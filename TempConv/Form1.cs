﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConv
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label3.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            label3.Text = " ";
            int Fr = Convert.ToInt32(textBox1.Text);
            result = Math.Round((5m/9m) * (Fr - 32));
            label3.Text = Convert.ToString(result);
            
            
        }
    }
}
