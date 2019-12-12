using System.Data;
using System;

namespace ValueReferenceTypes
{
    public class Student
    {
        public string Name { get; set; }
    }
    class Program
    {
        public static void ChangeValueType(int x)
        {
            x = 500;
            Console.WriteLine(x);
        }

        public static void ChangeReferenceType(Student student)
        {
            student.Name = "Bill";
        }

        static void Main(string[] args)
        {
            int i = 100;

            Student student = new Student();

            student.Name = "Steve";

            Console.WriteLine(i);

            ChangeValueType(i);
            Console.WriteLine(student.Name);
            ChangeReferenceType(student);

            Console.WriteLine(i);
            Console.WriteLine(student.Name);



            string message = "Save hte world!!";


        }
    }
}
