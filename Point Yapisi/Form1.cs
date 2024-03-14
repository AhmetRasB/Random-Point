using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point bambambam = new Point();
            int sayi1, sayi2;
            Random random = new Random();
            sayi1 = random.Next(100, 400);
            sayi2 = random.Next(100, 400);
            bambambam.X = sayi1;
            bambambam.Y = sayi2;
            pictureBox1.Location = bambambam;
        }
    }
}
