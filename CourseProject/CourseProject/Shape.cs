using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public abstract class Shape
    {
        public string ShapeType { get; protected set; }
        public float X { get; set; }
        public float Y { get; set; }
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
    class Square : Shape
    {
        public double A { get; set; }
        public Square()
        {
            ShapeType = "Square";
        }
        public override double CalculateArea() { return A * A; }
        protected override string GetDescription()
        {
            return $"A: {A}, A: {A}";
        }
    }
    class Triangle : Shape
    {
        public double A { get; set; }
        public double H { get; set; }
        public Triangle()
        {
            ShapeType = "Triangle";
        }
        public override double CalculateArea() { return (A * H) / 2; }
        protected override string GetDescription()
        {
            return $"A: {A}, H: {H}";
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
