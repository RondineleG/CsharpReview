using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Value of i : {0}", i);
            }

            int loopFor = 0;

            for(; ; )
            {
                if(loopFor < 10)
                {
                    Console.WriteLine("Value of i : {0}", loopFor);
                    loopFor++;

                }
                else
                {
                    break;
                }
            }
            

            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of d : {0}", d);
            }


            for (int i = 10; i>0; i--)
            {
                Console.WriteLine("Value of i : {0}", i);
            }
            for (; ; )
            {
                Console.WriteLine(1);
            }


        }
    }
}
