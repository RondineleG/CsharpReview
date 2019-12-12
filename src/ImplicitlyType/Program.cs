using System;

namespace ImplicitlyType
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicitly typed
            int i = 100;

            // inplicitly typed
            var j = 100;
            Console.WriteLine($"This as explicitly typr {i} and this is a implicitly type {j}");

            // Implicitly-Typed variables declarations
            var age = 27;
            Console.WriteLine("Type of age is {0}", age.GetType().ToString());

            var name = "Rondinele";
            Console.WriteLine($"Type of {name} is " + name.GetType().ToString());


             var price = 889.82d;
            Console.WriteLine($"Type of {price} is " + price.GetType().ToString());


             var live = true;
            Console.WriteLine("Type of live is {0}  ",live.GetType().ToString());



        }
    }
}
