using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Ashraful";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && ! outOfGuesses) 
            {
                if (guessCount< guessLimit)
                    {
                    Console.WriteLine("Enter Guess");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
               
            }
            if(outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
            
            Console.ReadLine();
        }
    }
}
