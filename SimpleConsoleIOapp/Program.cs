using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //simiiar to print
            Console.WriteLine("*********Basic I/O**********");
            GetUserData();
            Console.ReadLine();
        }
        static void GetUserData()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age:  ");
            string userAge = Console.ReadLine();

            //Echo to the console
            Console.WriteLine("Hello {0} you are {1} years old.", userName, userAge);



        }
    }
}
