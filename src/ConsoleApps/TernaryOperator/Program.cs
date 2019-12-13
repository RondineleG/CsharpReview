using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 80, y = 80;
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

            var result4 = x > y ? "x is greater than y" : x < y ? 
                "x is less than y" : x == y ?
                "x is equal to y" : "No result";

            Console.WriteLine(result);

            Console.WriteLine(result2);
            
            Console.WriteLine(result3);

            Console.WriteLine(result4);

        }
    }
}
