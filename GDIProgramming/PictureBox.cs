using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIProgramming
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Left;
            int y = pictureBox1.Top;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            x -= 10;

            if (x <= -pictureBox1.Width)
                x = Width;

            pictureBox1.SetBounds(x, y, width, height);
        }
    }
}
