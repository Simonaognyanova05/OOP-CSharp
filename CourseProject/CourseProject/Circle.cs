using System;
using System.Drawing;

namespace CourseProject
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round((Math.PI * Radius * Radius), 2);
        }

        public override void Draw(Graphics g)
        {
            int diameter = Radius * 2;
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
                g.DrawEllipse(pen, X - Radius, Y - Radius, diameter, diameter);
            }
        }

        public override bool Contains(Point p)
        {
            int dx = p.X - X;
            int dy = p.Y - Y;
            return dx * dx + dy * dy <= Radius * Radius;
        }
        public override Shape Clone()
        {
            return new Circle(X, Y, Radius)
            {
                FillColor = this.FillColor,
                BorderColor = this.BorderColor
            };
        }
        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }
}
