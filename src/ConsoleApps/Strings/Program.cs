﻿using System;

namespace Strings
{
    internal class Programs
    {
        private static void Main(string[] args)
        {
            string firstName = "Maria";
            string secondName = "Oliveira";
            Console.WriteLine($"The complete name is {firstName} of {secondName}");

            Console.WriteLine($"The name has {firstName.Length} letters");
            Console.WriteLine(secondName.Length);

            string hello = "      Hello World!       ";
            Console.WriteLine($"({hello})");


            string trimedHello = hello.TrimStart();
            Console.WriteLine($"({trimedHello})");


            trimedHello = hello.TrimEnd();
            Console.WriteLine($"({trimedHello})");

            trimedHello = hello.Trim();
            Console.WriteLine($"({trimedHello})");

            string sayHello = "Hello man!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("man", "World");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine(sayHello.ToUpper());

            // String interpolation

            var author = "Rondinele Guimarães";
            var book = "C# Guide";
            var date = DateTime.Now;

            // Use string interpolation to concatenate strings

            var bookAuthor = $"{author.ToUpper()} is author of {book.ToUpper()} of year {date.Year}";
            Console.WriteLine(bookAuthor);

            //Concatenate string using String.Concate method

            string fName = "Rondinele";
            string lName = " Guimaraes";

            string Name = string.Concat(fName, lName);

            string Name3 = string.Concat(string.Concat(fName, lName), " Sousa");

            Console.WriteLine(Name);
            Console.WriteLine(Name3);

            string[] authors = {"Rondinele ","Beatriz ","Gabriela"," Janaina"," Maria" };

            string arrayAutors = string.Concat(authors);
            string strArrayAuthors = string.Concat("Authors : ", arrayAutors);
           
            Console.WriteLine(arrayAutors);
            Console.WriteLine(strArrayAuthors);

            Console.ReadKey();

        }
    }
}