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

    public class Cello: IPen 
    {
       public string Color{get; set;}

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
            if(isOpen)
            {
                Console.WriteLine($"Cello : {text}");
            }
       }

    }
    
    public class Pencil : IPen
    { 
        string IPen.Color {get;set;}

        private bool isOpen = false;

        bool IPen.Close()
        {
             isOpen = false;
           Console.WriteLine("Pencil closed for wrinting");

           return isOpen;

        }

        bool IPen.Open()
        {
            isOpen = false;
           Console.WriteLine("Pencil open for wrinting");

           return isOpen;
        }

        void IPen.Write(string text)
        {
             if(isOpen)
            {
                Console.WriteLine($"Pencil : {text}");
            }
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

        }
    }
}
