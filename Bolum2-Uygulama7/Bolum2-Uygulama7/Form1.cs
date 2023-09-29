using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool carp, topla;
        float sayi1, sayi2, sonuc;
        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            carp = carpRadio.Checked;
            topla = toplaRadio.Checked;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (carp)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (topla)
            {
                sonuc = sayi1 + sayi2;
            }

            label3.Text = "Sonuç : " + sonuc;
        }
    }
}
