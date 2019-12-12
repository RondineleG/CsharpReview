using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVar = "Hello guys ";
            int  intVar = 55;
            float floatVar = 10.2f;
            char charVar = ' ';
            bool boolVar = true;

            var merge = stringVar + charVar + intVar + charVar
             + floatVar + charVar + boolVar;

            Console.WriteLine(merge);
        }
    }
}
