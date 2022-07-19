using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Similar to print
         Console.WriteLine("**** Basic****");
         GetUserData();
         Console.ReadLine();

         static void GetUserData()
          {
                // Get name and age
                Console.WriteLine("Enter your name: ");
                string username = Console.ReadLine();
                Console.Write("Enter your age:");
                string userage = Console.ReadLine();

                //Echo to the console
            Console.WriteLine("Hello {0}! You are {1} years old.", username, userage);
            }
        }
   
     


       