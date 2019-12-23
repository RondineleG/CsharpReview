using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i <10)
            {
                Console.WriteLine("Value of i : {0}", i);
                i++;
            }
            Console.WriteLine(i);

            int age = 0;

            while(true)
            {
                Console.WriteLine("Value of age is : {0}", age);
                age++;

                if (age > 18)
                {
                    break;
                }
                else if (age  == 18)
                {
                    Console.WriteLine("it's equal than 18.");
                }
                else
                {
                    Console.WriteLine("it's smaller than 18.");
                }
            }

            int number = 0;
            while(number < 10)
            {

                Console.WriteLine($"Value of i is : {number} .");
                var j = 1;
                number++;

                
                while(j <5)
                {
                    Console.WriteLine($"Value of j is : {j}.");
                    j++;
                }

            }
        }
    }
}
