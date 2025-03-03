using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class Shape
    {
        public string Type { get; set; }
        public int X {  get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{Type} - X: {X}; Y: {Y}";
        }
    }
}
