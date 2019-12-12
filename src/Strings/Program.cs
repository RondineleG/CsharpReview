using System;

namespace Strings
{
    class Programs
    {
        static void Main(string[] args)
        {
            string firstName = "Maria";
            string secondName = "Oliveira";
            Console.WriteLine($"The complete name is {firstName} of {secondName}");

            Console.WriteLine($"The name has {firstName.Length} letters");
            Console.WriteLine(secondName.Length);

            string hello = "      Hello World!       ";
            Console.WriteLine($"({hello})");


            string trimedHello = hello.TrimStart();
            System.Console.WriteLine($"({trimedHello})");

        }
    }
}