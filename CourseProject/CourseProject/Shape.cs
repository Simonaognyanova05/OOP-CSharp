using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    abstract class Shape
    {
        public string ShapeType { get; protected set; }
        public abstract double CalculateArea();
        public override string ToString()
        {
            return $"{ShapeType} - {GetDescription()}";
        }
        protected abstract string GetDescription();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle()
        {
            ShapeType = "Rectangle";
        }
        public override double CalculateArea() { return Width * Height; }
        protected override string GetDescription()
        {
            return $"Width: {Width}, Height: {Height}";
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            ShapeType = "Circle";
        }
        public override double CalculateArea()
        {
            return Math.Round((Math.PI * Radius * Radius), 2);
        }
        protected override string GetDescription()
        {
            return $"Radius: {Radius}";
        }
    }
}
