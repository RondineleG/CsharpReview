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
             string message;
             //value can be assigned after it declared
             message = " How are you ?";
             string response = "Fine, thanks";

             int i, j, k, l = 0;

             int amount, num;

            Console.WriteLine("Hello " + friend + message);

            Console.WriteLine(response);
        }
    }
}
