using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproggramme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers to add substract multiple and devide");
            int number1, number2 = 0;
            int  add, substract, multiple, devide = 0;
            Console.WriteLine("please enter first numvber ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter socend numvber ");
            number2 = Convert.ToInt32(Console.ReadLine());

            add = number1 + number2;
            substract = number1 - number2;
            multiple = number1 * number2;
            devide = number1 / number2;

            Console.WriteLine("Results");
            Console.WriteLine("Addition{0}", add);
            Console.WriteLine("Subtraction{0}", substract);
            Console.WriteLine("Multipication{0}", multiple);
            Console.WriteLine("Devide{0}",devide);
            Console.ReadLine();



        }
    }
}
