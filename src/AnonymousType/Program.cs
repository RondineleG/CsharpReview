using System;

namespace AnonymousType
{
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

        }

        static void DoSomething(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }
    }
}
