using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum1_Uygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double turkDogru, turkYanlıs, MatDogru, MatYanlıs;

        private void button1_Click(object sender, EventArgs e)
        {
            turkDogru = Convert.ToInt32(turkceDogru.Text);
            turkYanlıs = Convert.ToInt32(turkceYanlıs.Text);
            MatDogru = Convert.ToInt32(matDogru.Text);
            MatYanlıs = Convert.ToInt32(matYanlis.Text);

            double turkNet = turkDogru - (turkYanlıs / 4);
            double MatNet = MatDogru - (MatYanlıs / 4);

            turkceNet.Text = turkNet.ToString();
            matNet.Text = MatNet.ToString();
        }
    }
}
