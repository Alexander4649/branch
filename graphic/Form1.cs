using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic
{
    public partial class graphic : Form
    {
        public graphic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void graphic_Paint(object sender, PaintEventArgs e)
        {
            /*
            e.Graphics.DrawRectangle(Pens.Red, 30, 30, 60, 200);
            e.Graphics.FillRectangle(Brushes.Blue, 150, 30, 60, 200);
            e.Graphics.DrawEllipse(Pens.Red, 30, 30, 60, 200);
            e.Graphics.FillEllipse(Brushes.Blue, 150, 30, 60, 200);
            */
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /*
            e.Graphics.DrawLine(Pens.Red, 0, 0, 100, 150);
            long xx = pictureBox1.Width - 50;
            e.Graphics.DrawEllipse(Pens.Blue, xx, 50, 100, 100);

            Graphics gg = button1.CreateGraphics();
            gg.DrawEllipse(Pens.Red, 10, 2, 50, 20);
            gg.Dispose();
            */

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics gg = pictureBox1.CreateGraphics();
            Bitmap img = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            //Graphics gg = Graphics.FromImage(img);
            for(int i=0; i<150; i++)
            {
                img.SetPixel(i, i, Color.Blue);
                img.SetPixel(i, 80, Color.Red);
            }

            //gg.FillEllipse(Brushes.Yellow, 50, 50, 80, 80);
            //gg.FillRectangle(Brushes.Orange, 100, 80, 80, 80);
            pictureBox1.Image = img;
            //gg.Dispose();
        }
    }
}
