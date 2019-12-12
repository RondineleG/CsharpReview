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
                i =10;
                j = 5;
                k = 6;
                l= i + j + k;

             int amount, num;

             amount = i * j;
             num = amount * l;

             int n, m,
                p, 
                h =10; 

                n = 50; m =5; p = 99; 
                var sum = h *(p- m) + n / 2;

                int a = 100;
                 // value of b will be 100
                int b = a;

            Console.WriteLine("Hello " + friend + message);

            Console.WriteLine(response);

            Console.WriteLine(amount);

            Console.WriteLine(num);

            Console.WriteLine(sum);
        }
    }
}
