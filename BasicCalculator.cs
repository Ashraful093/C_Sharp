using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class BasicCalculator : BasicCalculatorInterface
    { 
            int result = 0;
            public int sum(int number1, int number2)
            {
                Console.WriteLine("Number1 : " + number1 + " Number2 : " + number2);
                result = number1 + number2;
                return result;
            }
            public int sub(int number1, int number2)
            {
                Console.WriteLine("Number1 : " + number1 + " Number2 : " + number2);
                result = number1 - number2;
                return result;
            }
            public int multi(int number1, int number2)
            {
                Console.WriteLine("Number1 : " + number1 + " Number2 : " + number2);
                result = number1 * number2;
                return result;
            }
            public int div(int number1, int number2)
            {
                Console.WriteLine("Number1 : " + number1 + " Number2 : " + number2);
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine("Result : " + result);
                    return 0;
                }
                else
                {
                    Console.WriteLine("Divide by zero error");
                    return 0;
                }
                return result;
            }
            public void displayResult()
            {
                Console.WriteLine("Result : " + result);
            }
        }
    }
