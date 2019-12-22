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
                    Console.WriteLine("Value of loopFor is : {0}", loopFor);
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

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine("Value of i: {0}", i);
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            Console.WriteLine("Value of i: {0}, J: {1}, L: {2}, M: {3} ", i, j, l, m);
                        }
                    }
                }
            }
            for (; ; )
            {
                  Console.WriteLine(1);
            }


        }
    }
}
