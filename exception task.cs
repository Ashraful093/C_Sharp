using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions_task
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int number1 = 4535;
            int number2 = 0;
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);  
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(" the result is undefined");
            }

           
            Console.WriteLine("Your age:");
            string line = Console.ReadLine();
            try
            {
                int age = Int32.Parse(line);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);


            }
            finally
            {
                Console.WriteLine("{0} is not an integer , so it can't be your age", line);

            }
            bool flag = true;
            try
            {
                IConvertible conv = flag;
                Char ch = conv.ToChar(null);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException ie)
            {
                Console.WriteLine(ie.Message);

            }

            try
            {
                Char ch = Convert.ToChar(flag);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException ie)
            {
                Console.WriteLine(ie.Message);
            }
            finally
            {
                Console.WriteLine("Cannot convert a Boolean to a Char.");
                Console.WriteLine("Cannot convert a Boolean to a Char.");
            }
        }
    }
}
