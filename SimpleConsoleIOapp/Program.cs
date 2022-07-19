using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        //Define Main() method.
        static void Main(string[] args)
        {// Begining of Main() method.
            Console.WriteLine("**** Basic IO ****");

            // Call GetUserData() method.
            GetUserData();
            Console.ReadLine();

            // Define GetUserData() method.
            static void GetUserData()
            {// Begining of GetUserData() method.
                // Get name and age.
                Console.Write("What is your name: ");
                string userName = Console.ReadLine();
                Console.Write("What is your age: ");
                string userAge = Console.ReadLine();

                //Echo to the Console.
                Console.WriteLine("Hello {0}! You are {1} years old." , userName , userAge);
            }// End of GetUserData() method.
        }// End of Main() method.
    }
}
