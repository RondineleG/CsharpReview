﻿using System;

namespace IfConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =20 , j =20;

            if(i > j)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(" if");
                Console.WriteLine("i is greater than j");
            }
            else if(i < j)
            {
                Console.WriteLine("i is less than j");
            }

            else if(i == j)
            {
                Console.WriteLine("i is iqual than j");
            }

            else if(i ==j)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("else if");
                Console.WriteLine("i is greater than j");
            }

            else                
            {
                Console.WriteLine("i is less than j");
            }

        }
    }
}
