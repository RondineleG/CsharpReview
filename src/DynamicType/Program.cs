using System;

namespace DynamicType
{
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


        }
    }
}
