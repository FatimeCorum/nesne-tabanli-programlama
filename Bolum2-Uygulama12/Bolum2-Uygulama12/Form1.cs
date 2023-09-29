using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_Uygulama12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                label1.Text = "SES YOK";
                label1.ForeColor = Color.Black;
            }


            else if (trackBar1.Value > 0 && trackBar1.Value <= 10)
            {
                label1.Text = "SES NORMAL";
                label1.ForeColor = Color.Green;
            }

            else if (trackBar1.Value>10)
            {
                label1.Text = "SES YÜKSEK";
                label1.ForeColor = Color.Red;
            }
               
        }
    }
}
