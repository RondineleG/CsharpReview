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

            int intAlias = 10;
            Int32 intNormal= 10; //same as above

            long longAlias = 45545;
            Int64 longNormal = 45545;

            /*
            
              Alias        .net Type
              
              byte         System.Byte
              sbyte        System.SByte
              int          System.Int32
              uint         System.UInt32
              short        System.Int16
              long         System.Int64
              ulong        System.UInt64
              float        System.Single
              double       System.Double
              char         System.Char
              bool         System.Boolean
              decimal      System.Decimal
              DateTime     System.DateTime

              All types are struct

              object       System.Object     type class
              string       System.Sting      type class
            
            
            */

            int defaultInt = default;
            float defaultFloat = default;
            decimal defaultDecimal = default;
            bool defaultBool = default;
            char defaultChar = default;

               Console.WriteLine(defaultInt);
               Console.WriteLine(defaultFloat);
               Console.WriteLine(defaultDecimal);
               Console.WriteLine(defaultBool);
                              Console.WriteLine(defaultChar);


        }
    }
}
