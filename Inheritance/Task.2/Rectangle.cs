using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Rectangle
    {
        public Point Position {  get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void Paint(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
        }
    }
}
