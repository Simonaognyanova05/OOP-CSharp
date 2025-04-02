using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Square : Shape
    {
        public int A { get; set; }

        public Square(int x, int y, int a) : base(x, y)
        {
            A = a;
        }

        public override double CalculateArea()
        {
            return A * A;
        }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(ShapeColor))
            {
                g.FillRectangle(brush, X, Y, A, A);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, X, Y, A, A);
            }
        }
        public override string ToString()
        {
            return $"Square: Side = {A}";
        }
    }
}
