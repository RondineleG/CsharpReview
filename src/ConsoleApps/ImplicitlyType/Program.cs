using System;

namespace ImplicitlyType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // explicitly typed
            int i = 100;

            // inplicitly typed
            int j = 100;
            Console.WriteLine($"This as explicitly typr {i} and this is a implicitly type {j}");

            // Implicitly-Typed variables declarations
            int age = 27;
            Console.WriteLine("Type of age is {0}", age.GetType().ToString());

            string name = "Rondinele";
            Console.WriteLine($"Type of {name} is " + name.GetType().ToString());


            double price = 889.82d;
            Console.WriteLine($"Type of {price} is " + price.GetType().ToString());


            bool live = true;
            Console.WriteLine("Type of live is {0}  ", live.GetType().ToString());



        }
    }
}
