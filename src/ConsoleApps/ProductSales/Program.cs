﻿using System;

namespace ProductSales
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int quantity;
            double price, discountPercent, finalPrice;
            string name;
            Console.WriteLine("How name of product ?");
            name = Console.ReadLine();

            Console.WriteLine("Enter quantity of product");
            quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price product");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter discount percent");
            discountPercent = double.Parse(Console.ReadLine());


            finalPrice = quantity * price;

            double finalPriceDiscount = finalPrice - (discountPercent / 100) * finalPrice;

            Console.WriteLine("Result :");

            Console.WriteLine($"Cost Price product is : {finalPriceDiscount}");
            Console.ReadKey();
        }
    }
}
