using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic IO");
            GetUserData();
            Console.ReadLine();

            static void GetUserData()
            {
                //Get name
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your age: ");
                string userAge = Console.ReadLine();

                //Echo to console
                Console.WriteLine("Hello {0} You are {1} years old.", userName, userAge);

            }
        }
    }
}
