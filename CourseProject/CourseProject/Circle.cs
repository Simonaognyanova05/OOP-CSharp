using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (Brush brush = new SolidBrush(ShapeColor))
            {
                g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }

}
