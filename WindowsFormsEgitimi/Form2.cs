﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string AdSoyad { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "Hoşgeldin " + AdSoyad;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            // form1.ShowDialog();
            form1.Show();
        }
    }
}
