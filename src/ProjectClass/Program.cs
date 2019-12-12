using System.Dynamic;
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

            //Method/Function
            public void MyMethod(int parametrerOne, int parametrerTwo)
            {
                Console.WriteLine("First paramenter {0}, second paramentera {1}", parametrerOne, parametrerTwo);
            }
             
             // Auto-implemented property
        public MyClass(int autoProperty) 
        {
            this.AutoProperty = autoProperty;
               
        }
                     public int AutoProperty { get; set; }

             private int _myProperty;

             //property with encapsulates a private field
             public int MyProperty
             {
                 get{return _myProperty;}
                 set{_myProperty = value;}
             }

             public int MyPropertyWithLogic
             {
                 get {
                     return _myProperty /2;
                 }
                 set{
                     if(value >100)
                     {
                         _myProperty = 100;
                     }
                     else
                     {
                         _myProperty = value;
                     }
                 }
             }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
