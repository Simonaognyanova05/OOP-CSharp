using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFraction
{
    internal class Fraction
    {
        public int Numerator { set; get; }
        public int Denomirator { set; get; }    

        public Fraction(int numerator, int denomirator)
        {
            if(denomirator == 0)
            {
                throw new Exception("Denominator cannot be Zero!");
            }
            Numerator = numerator;
            Denomirator = denomirator;
        }

        private void Simplify()
        {
            int gcd = GCD(Numerator, Denomirator);
            Numerator /= gcd;
            Denomirator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return Math.Abs(a);
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denomirator + f2.Numerator * f1.Denomirator;
            int denominator = f1.Denomirator * f2.Denomirator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denomirator}";
        }
    }
}
