﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if(saniye==60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if(dakika==60)
                {
                    saat = saat + 1;
                    label1.Text=saat.ToString();
                    dakika = 0;
                }
                if(saat==24)
                {
                    saniye = 0;
                    dakika = 0;
                    saat = 0;
                }
            }
        }
    }
}
