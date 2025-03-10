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

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, 2);
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width}; Height = {Height}";
        }
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, 2);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }

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
            return 0.5 * BaseLength * Height;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, 2);

            Point[] points = {
                new Point(X, Y),
                new Point(X + BaseLength / 2, Y - Height),
                new Point(X - BaseLength / 2, Y - Height)
            };

            g.DrawPolygon(pen, points);
        }

        public override string ToString()
        {
            return $"Triangle: Side = {BaseLength}; Height = {Height}";
        }
    }
}
