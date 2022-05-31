using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showellement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
                Console.ReadLine();

            }
        }
    }
}
