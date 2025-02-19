﻿using System;

namespace DynamicType
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int StandardID { get; set; }

        public void DisplayStudentDatails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Standard : {StandardID}");
        }
    }

    internal class Program
    {
        public static void PrintValues(dynamic value)
        {
            Console.WriteLine(value);
        }

        private static void Main(string[] args)
        {
            dynamic dynamicVar = "Rondinele";

            Console.WriteLine(dynamicVar.GetType().ToString());

            dynamic dynamicVariable = 100;
            Console.WriteLine($"Dynamic variable value: {dynamicVariable}, Type: " + dynamicVariable.GetType().ToString());

            dynamicVariable = "Save the World!!";
            Console.WriteLine($"Dynamic variable value: {dynamicVariable}, Type: " + dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamic dynamicStudent = new Student();

            dynamicStudent.DisplayStudentDatails();

            PrintValues("Hello World!!");
            PrintValues(100);
            PrintValues(100.50);
            PrintValues(true);
            PrintValues(DateTime.Now);




        }
    }
}
