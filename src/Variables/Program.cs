using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var friend = "Dog";   
             Console.WriteLine($"Hello {friend}");
            Console.WriteLine(friend); 
                friend = "Cat";
            Console.WriteLine(friend);

            Console.WriteLine("Hello " + friend);
        }
    }
}
