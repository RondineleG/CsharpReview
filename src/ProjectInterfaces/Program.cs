using System.Net.NetworkInformation;
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
        public string Color { get; set; }

        private bool isOpen = false;

        public bool Close()
        {
            isOpen = false;
            Console.WriteLine("Cello closed for wrinting");

            return isOpen;

        }

        public bool Open()
        {
            isOpen = true;
            Console.WriteLine("Cello open for writing");

            return isOpen;

        }

        public void Write(string text)
        {
            if (isOpen)
            {
                Console.WriteLine($"Cello : {text}");
            }
        }

    }

    public class Pencil : IPen
    {
        string IPen.Color { get; set; }

        private bool isOpen = false;

        bool IPen.Close()
        {
            isOpen = false;
            Console.WriteLine("Pencil closed for wrinting");

            return isOpen;

        }

        bool IPen.Open()
        {
            isOpen = true;
            Console.WriteLine("Pencil open for wrinting");

            return isOpen;
        }

        void IPen.Write(string text)
        {
            if (isOpen)
            {
                Console.WriteLine($"Pencil : {text}");
            }
        }

    }
    class Parker : IPen
    {
        public string Color { get; set; }

        private bool canWrite = false;

        public bool Close()
        {
            canWrite = false;
            Console.WriteLine("Parker is closed ");

            return canWrite;
        }

        public bool Open()
        {
            canWrite = true;
            Console.WriteLine("Parker is open ");

            return canWrite;
        }

        public void Write(string text)
        {
            //write text if open
            if (canWrite)
                Console.WriteLine("Parker: " + text);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPen pen = new Cello();
            pen.Open();
            pen.Write("This is may Pen .");
            pen.Close();

            IPen pencil = new Pencil();
            pencil.Open();
            pencil.Write("This is may pencil .");
            pencil.Close();


            IPen parker = new Parker();
            parker.Open();
            parker.Write($"Parker : {parker}");
            parker.Close();

            //Example o interfaces type variable

            IPen pen1 = new Cello();
            IPen pen2 = new Parker();
            IPen pen3 = new Pencil();


            pen3 = new Cello();
            pen1 = new Parker();
            pen2 = new Pencil();

        }
    }
}
