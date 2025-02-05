using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numerator and denominator of the first fraction (separated by space):");
                var input1 = Console.ReadLine().Split(' ');
                Fraction fraction1 = new Fraction(int.Parse(input1[0]), int.Parse(input1[1]));

                Console.WriteLine("Enter the numerator and denominator of the second fraction (separated by space):");
                var input2 = Console.ReadLine().Split(' ');
                Fraction fraction2 = new Fraction(int.Parse(input2[0]), int.Parse(input2[1]));

                Fraction result = Fraction.Add(fraction1, fraction2);

                Console.WriteLine($"The sum of {fraction1} and {fraction2} is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
