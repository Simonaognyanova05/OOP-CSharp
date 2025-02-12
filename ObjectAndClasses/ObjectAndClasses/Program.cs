using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Triangle[] triangles = new Triangle[3];

            for (int i = 0; i < triangles.Length; i++)
            {
                triangles[i] = new Triangle();

                Console.WriteLine($"Въведете височината на триъгълник {i + 1}:");
                triangles[i].Height = double.Parse(Console.ReadLine());

                Console.WriteLine($"Въведете основата на триъгълник {i + 1}:");
                triangles[i].Width = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"Площта на триъгълник {i + 1} е: {triangles[i].GetArea():F2}");
            }
        }
    }
}
