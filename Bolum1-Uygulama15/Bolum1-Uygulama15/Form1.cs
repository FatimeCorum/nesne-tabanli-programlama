using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum1_Uygulama15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fiyat;
        int indirimliFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat =Convert.ToInt32(textBox1.Text);
            indirimliFiyat =fiyat-( fiyat * 10 / 100);
            label2.Text = "İndirimli Fiyat : " + indirimliFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = fiyat-(fiyat * 25 / 100);
            label2.Text = "İndirimli Fiyat : " + indirimliFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = fiyat -( fiyat * 50 / 100);
            label2.Text = "İndirimli Fiyat : " + indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = fiyat -( fiyat * 75 / 100);
            label2.Text = "İndirimli Fiyat : " + indirimliFiyat.ToString();
        }
    }
}
