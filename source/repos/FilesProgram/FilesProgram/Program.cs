using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;

namespace ReadATextFile
{
    class Program
    {
        // Default folder path    
        //static readonly string rootFolder = (@"C:\Users\samot\source\repos\FilesProgram");    
  //Default file path.   
  static readonly string textFile = (@"C:\Users\samot\source\repos\FilesProgram\File1.txt");
  static readonly string textFile2 = (@"C:\Users\samot\source\repos\FilesProgram\File2.txt");

        static void Main(string[] args)
        {   

            Console.WriteLine("Unsorted: ");
            Console.WriteLine(" ");


            if (File.Exists(textFile))
            {
                 
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                Console.WriteLine(line);
            }
            Console.WriteLine(" ");
            Console.WriteLine("And:");
            Console.WriteLine(" ");

            if (File.Exists(textFile2))
            {
                  
                string[] lines = File.ReadAllLines(textFile2);
                
                foreach (string line in lines)
                Console.WriteLine(line);
            }

            
            Console.WriteLine(" ");
            Console.WriteLine("Sorted alphabetically: ");
            Console.WriteLine(" ");

            
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                Array.Sort(lines);
                foreach (string line in lines)
                Console.WriteLine(line);
            }
                Console.WriteLine(" ");
                Console.WriteLine("And:");
                Console.WriteLine(" ");

            if (File.Exists(textFile2))
            {
                 string[] lines = File.ReadAllLines(textFile2);
                 Array.Sort(lines);
                 foreach (string line in lines)
                 Console.WriteLine(line);              
            }
        }
    }           
}
    



//string txtPath = Path.Combine(Environment.CurrentDirectory, @"C:\\Users\samot\source\repos\FilesProgram\File1.txt");
