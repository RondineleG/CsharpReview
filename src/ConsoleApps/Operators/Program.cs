using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello";

            // string concatenation 
            var printMessage = message + "World!";

            Console.WriteLine(printMessage);

            int i = 10, j = 50, l = 80;

            // Basic Math operators
            var sum = i + j + l;
            var multiplication = i * l;
            var division = j / i;
            var subtract = l - i - j;

            Console.WriteLine(sum);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(subtract);
            Console.ReadKey();

            // Operator precedence

            var a = 2 + 2 * 2; // output : 6

            //Use parentheses to change the order of evaluation imposed by operator precedence:

            var b = (2 + 2) * 2; // output : 8

        }
    }
}
