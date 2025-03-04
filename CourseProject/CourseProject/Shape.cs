using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Shape
    {
        public string Type { get; set; }
        public double A { get; set; }
        public double B { get; set; }

        public override string ToString()
        {
            return $"{Type} - A: {A}, B: {B}";
        }
        public virtual double CalculateArea()
        {
            return A * B;
        }
    }


    public class Square : Shape
    {
        public override double CalculateArea()
        {
            return A * A; 
        }
    }
    public class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            return A * B;
        }
    }
    public class Triangle : Shape
    {
        public override double CalculateArea()
        {
            return (A * B) / 2;
        }
    }
    public class Circle : Shape
    {
        public override double CalculateArea()
        {
            return Math.Round((Math.PI * A * A), 2);
        }
    }
}
