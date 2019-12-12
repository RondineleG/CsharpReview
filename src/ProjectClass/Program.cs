using System.Security.Cryptography.X509Certificates;
using System;

namespace ProjectClass
{
    class Program
    {
        //Creating class using acces modifier public
        public class MyClass
        {
            //field
            public string myField = string.Empty;
            // Constructor 
            public MyClass()
            {
                
            }

            public void MyMethod (int parametrerOne, int parametrerTwo)
            {
                Console.WriteLine("First paramenter {0}, second paramentera {1}", parametrerOne, parametrerTwo);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
