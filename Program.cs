//Joseph Matulewicz

using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Basic IO ****");
            GetUserData();
            Console.WriteLine();

            Console.ReadLine();

            static void GetUserData()
            {
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your age: ");
                string userAge = Console.ReadLine();

                Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
            }
        }
    }
}

