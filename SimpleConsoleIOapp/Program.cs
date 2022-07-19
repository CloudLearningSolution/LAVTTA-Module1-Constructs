using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Similar to print
            Console.WriteLine("****Basic I0****");
            GetUserData();
            Console.ReadLine();

            static void GetUserData()
            {
                // Get name and age 
                Console.Write(" Enter your name:");
                String UserName = Console.ReadLine();
                Console.WriteLine("enter your age:");
                string userAge = Console.ReadLine();

                //Echo to the console
                Console.WriteLine("Hello {0}! You are {1} years old.", UserName, userAge);
            }


        }

    }

}







