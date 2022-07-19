using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {   // Similar to print
            Console.WriteLine("***** Basic ID ****");
            GetUserData();
            Console.ReadLine();

            static void GetUserData()
            {
                // Get name and age
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
