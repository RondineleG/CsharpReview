using System.Data;
using System;

namespace ValueReferenceTypes
{
    class Program
    {
        static void ChangeValue(int x)
        {
           x = 500;
           Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
           
        }
    }
}
