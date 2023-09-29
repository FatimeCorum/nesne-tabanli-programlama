using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1, sayi2;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi1>sayi2)
            {
                MessageBox.Show("Büyük Sayi : " + sayi1.ToString() + " Küçük Sayi : " + sayi2.ToString());
            }
            else if (sayi1<sayi2)
            {
                MessageBox.Show("Büyük Sayi : " + sayi2.ToString() + " Küçük Sayi : " + sayi1.ToString());
            }
            else
            {
                MessageBox.Show("Sayılar Eşit");
            }
        }
    }
}
