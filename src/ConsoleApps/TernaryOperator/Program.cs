using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;
            int result3 = 0;


            var result = x > y ? "x is greater than y" : "x is less than or iqual to y";
            var result2 = x > y ? x : y;

            if(x >y )
            {
                result3 = x;
            }
            else if (x < y)
            {
                result3 = y;
            }

            Console.WriteLine(result);

            Console.WriteLine(result2);
            
            Console.WriteLine(result3);

        }
    }
}
