using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Triangle : Shape
    {
        public int BaseLength { get; set; }
        public int Height { get; set; }

        public Triangle(int x, int y, int baseLength, int height) : base(x, y)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return (BaseLength *  Height) / 2;
        }

        public override void Draw(Graphics g)
        {
            Point p1 = new Point(X, Y - Height);                         // Връх
            Point p2 = new Point(X - BaseLength / 2, Y);                // Ляво
            Point p3 = new Point(X + BaseLength / 2, Y);                // Дясно

            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillPolygon(brush, new Point[] { p1, p2, p3 });
                g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
            }
        }

        public override string ToString()
        {
            return $"Triangle: Side = {BaseLength}; Height = {Height}";
        }
    }
}
