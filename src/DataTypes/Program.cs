using Microsoft.VisualBasic.CompilerServices;
using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVar = "Hello guys ";
            int intVar = 55;
            float floatVar = 10.2f;
            char charVar = ' ';
            bool boolVar = true;

            var merge = stringVar + charVar + intVar + charVar
             + floatVar + charVar + boolVar;

            Console.WriteLine(merge);
            uint ui = 100U;
            float fl = 15.2F;
            long lo = 4444444444444447474L;
            ulong ul = 4444444444444444444UL;
            double d = 1212121212.45454D;
            decimal dec = 10006.45M;


            Console.WriteLine(ui);
            Console.WriteLine(fl);
            Console.WriteLine(lo);
            Console.WriteLine(ul);
            Console.WriteLine(d);
            Console.WriteLine(dec);

        }
    }
}
