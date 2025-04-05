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
            int diameter = Radius * 2;
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
                g.DrawEllipse(pen, X - Radius, Y - Radius, diameter, diameter);
            }
        }
        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }

}
