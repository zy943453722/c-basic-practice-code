﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] a = new double[5];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double element = double.Parse(textBox1.Text);
            a[i] = element;
            textBox2.Text += a[i] + " ";
            i++;
            label5.Text = "请输入第" + (i) + "个元素"; 
          }
        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            textBox3.Text = a[0] + " " + a[1] + " " + a[2] + " " + a[3] + " " + a[4]; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
