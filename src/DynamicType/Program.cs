using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System;

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
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Age : {this.Age}");
            Console.WriteLine($"Standard : {this.StandardID}");
        }
    }
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}
