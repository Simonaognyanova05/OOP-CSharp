using System;
using System.Drawing;

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
            return (BaseLength * Height) / 2;
        }

        public override void Draw(Graphics g)
        {
            Point p1 = new Point(X, Y - Height);                          
            Point p2 = new Point(X - BaseLength / 2, Y);                
            Point p3 = new Point(X + BaseLength / 2, Y);               

            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillPolygon(brush, new Point[] { p1, p2, p3 });
                g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
            }
        }

        public override bool Contains(Point p)
        {
            Point p1 = new Point(X, Y - Height);
            Point p2 = new Point(X - BaseLength / 2, Y);
            Point p3 = new Point(X + BaseLength / 2, Y);

            float Area(Point a, Point b, Point c)
            {
                return Math.Abs((a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2f);
            }

            float A = Area(p1, p2, p3);
            float A1 = Area(p, p2, p3);
            float A2 = Area(p1, p, p3);
            float A3 = Area(p1, p2, p);

            return Math.Abs(A - (A1 + A2 + A3)) < 0.5f;
        }

        public override string ToString()
        {
            return $"Triangle: Side = {BaseLength}; Height = {Height}";
        }
    }
}
