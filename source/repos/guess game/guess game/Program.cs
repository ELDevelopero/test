using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_game
{
    class Program
    {
        static void Main(string[] args)
        {

            static int GetGuess()
            int outNumber = 10; 
            Console.WriteLine("Please guess the number");
            String answer = Console.ReadLine);
            int guessNumber = 0;
            Int32.TryParse(answer, out guessNumber);
            if (guessNumber == ourNumber)
            {
                Console.WriteLine("Correct, well done!")
            }
            else if (guessNumber > ourNumber) ;

            {
                Console.WriteLine("Sorry Too high number");            }

            else
            {
                Console.WriteLine("Sorry, too low!");
            }

            Console.WriteLine("Press any key to quit");
            Console.Read();
        }
    }
}
