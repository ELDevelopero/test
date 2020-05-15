using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
            

        {
            int i;
            int[] numbers = new int[5];

            Console.WriteLine("Please type 5 numbers..");
            for (i= 0; i < 5; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Reverse
            for (i = 4; i >=0 ; i--)
            {
                Console.Write("{0}", numbers[i]);
                
            }
            Console.Read();

            //Console.WriteLine("Please enter a few numbers");
            //string usrinput = Console.ReadLine();
            //Int32.TryParse(usrinput, out numbers);
            




            //numbers = double.Parse(Console.ReadLine());
            //numbers=usrinput
            //Int32.TryParse(usrinput, out numbers);

            //numbers = vd;
           // Array.Reverse(numbers);
        }
    }
}
