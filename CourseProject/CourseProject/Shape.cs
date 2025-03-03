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
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"{Type} - X: {X}, Y: {Y}";
        }
        public virtual double CalculateArea()
        {
            return X * Y;
        }
    }


    public class Square : Shape
    {
        public override double CalculateArea()
        {
            return X * Y; 
        }
    }
}
