using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            long factorial = RecursiveFactorial(number);
            Console.Write($"Factorial of {number} is: {factorial}");

            Console.ReadLine();
        }
        static long RecursiveFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }
            

        }
    }
}
