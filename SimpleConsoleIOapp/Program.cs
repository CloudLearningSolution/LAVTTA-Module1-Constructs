using System;

namespace SimpleConsoleIOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Similar to print
            Console.WriteLine("**** Basic IO ****");
            GetUserData();
            Console.WriteLine("Value 99999 in different formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            */

            //Console.WriteLine("data types and variables");
            //LocalVardeclarations();  

            SimpleStringFunction();
            
            Console.ReadLine();

            #region This is my SimpleStringFunction
            static void SimpleStringFunction()
            {
                Console.WriteLine(" Simple Strings ");
                string FirstName = "Benjamin";
                Console.WriteLine("Value of FirstName: {0}", FirstName);
                Console.WriteLine("FirstName has {0} characters.", FirstName.Length);
                Console.WriteLine("FirstName in uppercase: {0}", FirstName.ToUpper());
                Console.WriteLine("FirstName in lowercase: {0}", FirstName.ToLower());
                Console.WriteLine("FirstName contains the letter d?: {0}", FirstName.Contains("d"));
                Console.WriteLine("New first name: {0}", FirstName.Replace("in", ""));
                Console.WriteLine();
            }


            #endregion

            #region This is my localvardeclarations function
            //New method/function
            static void LocalVardeclarations()
            {
                //loval variables
                //data types
                int myInt = 0;
                string myString;
                myString = "This is my string of data";
                Console.WriteLine();
            }
            #endregion

            #region This is the GetUserData Method
            static void GetUserData()
            {
                //Get name and age
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your age: ");
                string userAge = Console.ReadLine();

                //Echo to the console
                Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
            }
            #endregion
        }
    }
}