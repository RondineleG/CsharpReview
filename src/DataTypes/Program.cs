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
            Int32 intNormal = 10; //same as above

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

            //Implicit conversion
            int num = 10;
            float num2 = num;

            Console.WriteLine(num2);
            /*
                Implicit conversion
             
             from                to
             
             sbyte   =>  short, int , long, float, double decimal
             
             byte   =>  short, ushort, int, uint , long, ulong, float, double , decimal

             short  =>  int, long , float, double, decimal

             ushort  =>  int, uint , long, ulong, float, double , decimal

             int =>  long, float, double , decimal

             uint =>  long, ulong, float, double , decimal

             long => float, double , decimal

             ulong =>  float, double , decimal

             char => ushort, int, uint, long, ulong, float, double , decimal

             float => double          

             */

             int exp = 1000;

             uint uin = (uint) exp; // Explicit conversion

             Console.WriteLine(uin);

        }
    }
}
