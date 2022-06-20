﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            labelSecond.Text = DateTime.Now.ToString("ss");
            labelDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
            labelSecond.Location = new Point(labelTime.Location.X+labelTime.Width-5, labelSecond.Location.Y);
        }
    }
}
