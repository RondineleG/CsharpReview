using System;

namespace ProjectInterfaces
{
    interface IPen
    {
        string Color { get; set; }

        bool Open();

        bool Close();

        void Write(string text);
    }

    public class Cello : IPen   
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
