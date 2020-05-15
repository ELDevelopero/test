using System;
using System.Dynamic;

namespace SwitchProgram

{
    class Program
    {
        
        static void Main(string[] args)
        {

        string usrinput;
        int usroutput = 0;
        Console.WriteLine("Please enter the text mark: ");
        usrinput = Console.ReadLine();
        Int32.TryParse(usrinput, out usroutput);
            if ( (usroutput == 9) || (usroutput == 10))
            {
                Console.WriteLine("Excellent");
            }
            else if ((usroutput == 7) || (usroutput == 8))

            {
                Console.WriteLine("Notable");
            }

            else if (usroutput==6)
            {
                Console.WriteLine("Good");
            }

            else if (usroutput == 5)
            {
                Console.WriteLine("Pass");
            }

            else if  ((usroutput >= 0) && (usroutput <5 ))
            {
                Console.WriteLine("Fail");
            }

            else
            {
                Console.WriteLine("Incorrect mark, please enter marks from 0 to 10");
            }

            Console.ReadLine();







        }
    }
}