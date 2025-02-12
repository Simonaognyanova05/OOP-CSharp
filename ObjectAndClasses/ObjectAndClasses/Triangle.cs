using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClasses
{
    internal class Triangle
    {
        public double Height { get; set; }
        public double Width { get; set; }


        public double GetArea()
        {
            return (Height * Width) / 2;  
        }
    }
}
