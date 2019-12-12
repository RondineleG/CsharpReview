using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                fisrtProperty = "First",
                secondProperty = 2,
                thirdProperty = true,

                anotherAnonymousType = new
                {
                    nestedProperty = "Nested"
                }
            };

            Console.WriteLine(myAnonymousType.fisrtProperty);
            Console.WriteLine(myAnonymousType.anotherAnonymousType.nestedProperty);
            Console.WriteLine(myAnonymousType.GetType().ToString());


        }
    }
}
