using System;

namespace SimpleConsoleIOapp
{
    class Program
    {;
        //simiiar to print
        Console.Writline("*********Basic I/O**********);
        String userName = Console.ReadLine();
        Console.Writeline("Enter your age:  ");
        String userAge = Console.ReadLine();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            //Create a feaature for awaiting user input before teminiation
            Console.ReadLine();
        }
    }
}
