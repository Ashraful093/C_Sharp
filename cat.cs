using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.name = "Nicky";
            cat1.colour = "yellow";
            cat1.body = "slim";


            Cat cat2 = new Cat();
            cat2.name = "Dicky";
            cat2.colour = "Black";
            cat2.body = "Fat";

            Cat cat3 = new Cat();
            cat3.name = "Nicky";
            cat3.colour = "Black";
            cat3.body = "Fat";

            Cat cat4 = new Cat();

            Console.WriteLine("Cat Name");
            Console.ReadLine();
        }
    }
}
