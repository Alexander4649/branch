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
            // e.Graphics.DrawRectangle(Pens.Red, 30, 30, 60, 200);
            // e.Graphics.FillRectangle(Brushes.Blue, 150, 30, 60, 200);
            //e.Graphics.DrawEllipse(Pens.Red, 30, 30, 60, 200);
            //e.Graphics.FillEllipse(Brushes.Blue, 150, 30, 60, 200);

        }
    }
}
