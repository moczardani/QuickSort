using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QuickSort
{
    class Golyo
    {
        public Point currentpos;
        public Point targetpos;
        public int value;

        static public List<Golyo> lista = new List<Golyo>();

        public Golyo(int érték, int x, int y, PictureBox palya)
        {
            currentpos = new Point(x, y);
            targetpos = new Point(x, y);
            value = érték;
        }
        public static bool Rajzold_le_mind_ide(PictureBox palya)
        {
            Bitmap kep = new Bitmap(palya.Width, palya.Height);
            Graphics graphics = Graphics.FromImage(kep);
            bool moving = false;

            foreach (Golyo golyo in Golyo.lista)
                moving = golyo.Rajzoldle(graphics) || moving;

            palya.Image = kep;
            palya.Refresh();
            return moving;
        }

        bool Rajzoldle(Graphics graphics)
        {
            bool moving = false;
            int r =25;
            if(currentpos != targetpos)
            {
                currentpos = new Point(targetpos.X > currentpos.X ? currentpos.X + 1 : currentpos.X - 1, currentpos.Y);
                moving = true;
            }
            Brush brush = new SolidBrush(Color.Blue);
            graphics.FillEllipse(brush, new Rectangle(currentpos, new Size(2*r,2*r)));

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            graphics.DrawString(value.ToString(), drawFont, drawBrush, currentpos.X+10, currentpos.Y+10);
            return moving;
        }
    }
}
