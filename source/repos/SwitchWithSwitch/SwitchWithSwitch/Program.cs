using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace SwitchWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int qualification;
            Console.WriteLine("Please enter qualification");
            qualification = Convert.ToInt32(Console.ReadLine());

            if ((qualification==9)||(qualification==10))
            {
                Console.WriteLine("Excellent");
            }
            else if ((qualification == 7) || (qualification == 8))
            {
                Console.WriteLine("Notable");
            }
            else if (qualification == 6)
            {
                Console.WriteLine("Good");
            }

            else if (qualification == 5)
            {
                Console.WriteLine("Pass");
            }

            else if ((qualification >= 0) && (qualification < 5))
            {
                Console.WriteLine("Fail");
            }

            else
            {
                Console.WriteLine("Incorrect mark, please enter marks from 0 to 10");
            }

            switch (qualification)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Fail");
                    break;
                case 5:
                    Console.WriteLine("Congrats");
                    break;
                case 6:
                    Console.WriteLine("Good");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }

            Console.ReadLine();
        }
    }
}
