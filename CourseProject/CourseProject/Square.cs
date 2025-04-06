using System.Drawing;

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
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, 2))
            {
                g.FillRectangle(brush, X, Y, A, A);
                g.DrawRectangle(pen, X, Y, A, A);
            }
        }

        public override bool Contains(Point p)
        {
            return p.X >= X && p.X <= X + A &&
                   p.Y >= Y && p.Y <= Y + A;
        }

        public override string ToString()
        {
            return $"Square: Side = {A}";
        }
    }
}
