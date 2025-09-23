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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // form2.ShowDialog();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close(); // formu kapat
            Application.Exit(); // uygulamayı kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.AdSoyad = textBox1.Text; // ekranda kutucuğa girilen değeri form2 deki property e yolla
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) // text.Box1.Text boş değilse 
            {
                MessageBox.Show("Hoşgeldin " + textBox1.Text); // ekrana mesaj ver
            }
            else
            {
                MessageBox.Show("Lütfen adınızı giriniz!", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
