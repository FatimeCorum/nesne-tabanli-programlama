using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2,sonuc;

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1;
            for (int i = sayi1; i <= sayi2; i++)
            {
                sonuc =sonuc+i;
            }
            MessageBox.Show("Sonuç : " + sonuc);
        }
    }
}
