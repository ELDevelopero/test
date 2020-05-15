using System;

namespace ArrayEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] numbers = new int[11];
            Console.WriteLine("Please type 10 numbers");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0}", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Even Numbers :");
            for (i = 0; i <= 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }



            Console.WriteLine();

        }
              
        }         
            
        }
              
                
            
    

    

