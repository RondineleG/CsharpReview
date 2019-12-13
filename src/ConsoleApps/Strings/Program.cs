using System;
using System.Text;

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


            // Concatenate string using String.Join method 
            int[] intArray = { 1, 3, 5, 7, 9 };
            string seperator = ",";
            string result = "Int , ";

            result += string.Join(seperator, intArray);

            Console.WriteLine($"Result : {result}");
            Console.WriteLine($"Result : {result.ToUpper()}");

            // String.Join method specified the starting index of the array
            string[] stringArray = { "Rondinele ", "Beatriz ", "Gabriela", " Janaina", " Maria" };

            string result2 = "First Author, ";

            result2 += string.Join(seperator, stringArray,0,1);

            Console.WriteLine($"Result : {result2}");

            //Concatenate string using String.Format method

            string strDate = string.Format("Today's data is {0}", DateTime.Now);
            Console.WriteLine(strDate);
            Console.WriteLine(strDate.Length);

            // Insert multiple objects in a string     

            string actor = "Rondinele";
            string movie = "Life developer";
            int year = 2006;
            int price = 89;
            string publisher = "Cpress";

            var movieDetails = string.Format("{0} is actor of movie {1} \n" + 
                "published  by {2} in the year {3}.\n movie price is R$ {4}",
                actor, movie, publisher, year,price);

            Console.WriteLine(movieDetails);


            // StringBuilder.Append method

            StringBuilder builder = new StringBuilder("Rondinele Guimaraes");
            builder.Append(",");
            builder.Append("Beatriz");
            builder.Append(", Gabriela");
            
            Console.WriteLine(builder);

            StringBuilder numbers = new StringBuilder();
            for (int counter = 0; counter <= 999; counter++)
            {
                numbers.Append(counter);
                numbers.Append(",");
            }

            Console.WriteLine(numbers);

            Console.ReadKey();

        }
    }
}