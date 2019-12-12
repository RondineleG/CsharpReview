using System.Collections.Generic;
using System;
using System.Linq;
namespace AnonymousType
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true,

                anotherAnonymousType = new
                {
                    nestedProperty = "Nested"
                }
            };

            Console.WriteLine(myAnonymousType.firstProperty);
            Console.WriteLine(myAnonymousType.anotherAnonymousType.nestedProperty);
            Console.WriteLine(myAnonymousType.GetType().ToString());

            DoSomething(myAnonymousType);

            IList<Student> studentList = new List<Student>()
            {
                new Student(){Id =1, Name ="Rondinele", Age=27},
                new Student(){Id =2, Name ="Leticia", Age=25},
                new Student(){Id =3, Name ="Ronaldo", Age=43},
                new Student(){Id =4, Name ="Elen", Age=48},
                new Student(){Id =5, Name ="Maria", Age=17}
            };

            var studentNames = from s in studentList
                               select new
                               {
                                   Id = s.Id,
                                   Name = s.Name
                               };

        }

        static void DoSomething(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }
    }
}
