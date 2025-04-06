using System.Drawing;

namespace CourseProject
{
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
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override bool Contains(Point p)
        {
            return p.X >= X && p.X <= X + Width &&
                   p.Y >= Y && p.Y <= Y + Height;
        }
        public override Shape Clone()
        {
            return new Rectangle(X, Y, Width, Height)
            {
                FillColor = this.FillColor,
                BorderColor = this.BorderColor
            };
        }

        public override string ToString()
        {
            return $"Rectangle: Width = {Width}; Height = {Height}";
        }
    }
}
