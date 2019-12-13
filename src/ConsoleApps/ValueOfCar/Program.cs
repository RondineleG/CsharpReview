using System;

namespace ValueOfCar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Inicialization

            double costPrice, taxCost, finalPrice, salesCommission;
            string model, brand;
            Console.WriteLine("How are you brand ?");
            brand = Console.ReadLine();

            Console.WriteLine("How are you model ?");
            model = Console.ReadLine();

            Console.WriteLine("Enter cost price");
            costPrice = double.Parse(Console.ReadLine());

            taxCost = costPrice * 0.45;
            salesCommission = costPrice * 0.28;

            finalPrice = costPrice + taxCost + salesCommission;

            Console.WriteLine("Result :");
            Console.WriteLine($"Brand  : {brand}");

            Console.WriteLine($"Model : {model}");

            Console.WriteLine($"Cost Price : {finalPrice}");


            Console.ReadKey();


        }
    }
}
