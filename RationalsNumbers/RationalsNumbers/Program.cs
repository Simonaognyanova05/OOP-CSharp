using RationalsNumbers.PoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalsNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber num1 = new RationalNumber(3, 4); 
            RationalNumber num2 = new RationalNumber(2, 5); 

            Console.WriteLine("Rational Numbers:");
            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");

            // Събиране
            RationalNumber sum = num1 + num2;
            Console.WriteLine($"\nSum: {num1} + {num2} = {sum}");

            // Изваждане
            RationalNumber difference = num1 - num2;
            Console.WriteLine($"Difference: {num1} - {num2} = {difference}");

            // Умножение
            RationalNumber product = num1 * num2;
            Console.WriteLine($"Product: {num1} * {num2} = {product}");

            // Деление
            RationalNumber quotient = num1 / num2;
            Console.WriteLine($"Quotient: {num1} / {num2} = {quotient}");

            // Преобразуване към decimal
            decimal decimalValue = (decimal)num1;
            Console.WriteLine($"\nDecimal value of {num1}: {decimalValue}");

            // Сравнения
            Console.WriteLine("\nComparisons:");
            Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
            Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
            Console.WriteLine($"{num1} > {num2}: {num1 > num2}");

            // Проверка за канонична форма
            RationalNumber invalidNum = new RationalNumber(-8, -12); // -8/-12 -> 2/3
            Console.WriteLine($"\nCanonical form of -8/-12: {invalidNum}");

            Console.WriteLine("\nEnd of program.");
        }
    }
}
