using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrinput;
            double num1;
            char operat;
            double num2;
            double result = 0;
            Console.WriteLine("Enter the first number: ");
            usrinput = Console.ReadLine();
            num1 = Convert.ToDouble(usrinput);
            Console.WriteLine("Enter the operation: +, -, *, / ");
            usrinput = Console.ReadLine();
            operat = Convert.ToChar(usrinput);
            Console.WriteLine("Enter the second number: ");
            usrinput = Console.ReadLine();
            num2 = Convert.ToDouble(usrinput);

            if (operat == '+') 
            {
                result = num1 + num2;
            }
            else if (operat == '-' )
            {
                result = num1 - num2;
            }
            else if (operat == '/' )
            {
                result = num1 / num2;
            }
            else if (operat == '*')
            {
                result = num1 * num2;
                Console.WriteLine("Result is: " + result);
            }
            
            //Console.WriteLine($"Result is: {result}");
            else
            {
                Console.WriteLine("Wrong input or division by zero, please try again");
            }
            Console.Read();
            
           /* int y = 20;
            int ggg = x + y;
            Console.WriteLine(ggg);
            Console.Read();
            */
        }
    }
}
