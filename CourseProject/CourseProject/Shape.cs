using System.Drawing;

public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color FillColor { get; set; } = Color.LightGray;
    public Color BorderColor { get; set; } = Color.Black;

    public Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract double CalculateArea();
    public abstract void Draw(Graphics g);
    public abstract bool Contains(Point p);

    public override string ToString()
    {
        return $"at ({X}, {Y})";
    }
}
