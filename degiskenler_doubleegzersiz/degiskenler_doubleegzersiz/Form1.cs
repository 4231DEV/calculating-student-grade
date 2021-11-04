using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenler_doubleegzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            int numara;
            numara = Convert.ToInt32(textBox6.Text);
            double s1, s2, proje, ortalama;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);
            ortalama = ((s1 %80) + (s2 %80) + (proje%60)) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + numara + " " + "ortalama: " +  ortalama);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
