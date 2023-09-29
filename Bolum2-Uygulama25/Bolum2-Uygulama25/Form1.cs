using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = 10;
            for (int i = 0; i <=4; i++)
            {
                listBox1.Items.Add(sayi.ToString());
                sayi = sayi * 10;
            }
        }
    }
}
