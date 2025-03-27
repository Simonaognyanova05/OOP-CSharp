using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; } = Color.Black;

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract double CalculateArea();

        public abstract void Draw(Graphics g);
         public override string ToString()
         {
            return $"at ({X}, {Y})";
         }
    }
}
