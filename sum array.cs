using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprob1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraydata = { 3, 4, 5, 7, 6, 5, 4, 3, 5, 6, 7, 7, 8, 9, 7, 6, 5 };
            Console.WriteLine("\narray 1:[{0}]", string.Join(",", arraydata));
            var sum = 0;
            for (var k=0; k<arraydata.Length;k++)
            {
                sum += arraydata[k];
            }
            Console.WriteLine("The sum of the ellements is " + sum);
            Console.ReadLine();
        }
    }
}
