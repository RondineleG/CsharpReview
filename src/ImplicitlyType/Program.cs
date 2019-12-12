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
        }
    }
}
