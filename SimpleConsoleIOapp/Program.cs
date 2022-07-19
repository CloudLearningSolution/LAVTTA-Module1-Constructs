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

            //Create a feature for awaiting user input before terminating
            Console.ReadLine();

            static void GetUserData()
            {
                //Getname and age
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your age: ");
                string userAge = Console.ReadLine();

                //Echo to the console
                Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
            }
        }
    }
}
