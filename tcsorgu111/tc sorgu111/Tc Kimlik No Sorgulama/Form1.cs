﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tc_Kimlik_No_Sorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0;
            string  c,d;
            string sayı1 = textBox1.Text;
            string sayı2 = sayı1[sayı1.Length-1].ToString();
            string deger1 = "Geçerli TC Kimlik Numarası!";
            string deger2 = "Geçersiz TC Kimlik Numarası!";
          

            foreach (var i in sayı1)
            {
                c= i.ToString(); 
                
                toplam = toplam + int.Parse(c);
            }

            toplam = toplam - int.Parse(sayı2);

            d = toplam.ToString();

            d = d[d.Length-1].ToString();

            if (d == sayı2)
                MessageBox.Show(deger1);
            else
                MessageBox.Show(deger2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
