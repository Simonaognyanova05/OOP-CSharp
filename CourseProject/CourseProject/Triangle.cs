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
            Point[] points = new Point[]
            {
            new Point(X, Y - Height), 
            new Point(X - BaseLength / 2, Y), 
            new Point(X + BaseLength / 2, Y) 
            };

            using (Brush brush = new SolidBrush(ShapeColor))
            {
                g.FillPolygon(brush, points);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, points);
            }
        }

        public override string ToString()
        {
            return $"Triangle: Side = {BaseLength}; Height = {Height}";
        }
    }
}
