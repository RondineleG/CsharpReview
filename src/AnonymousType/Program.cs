using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new {
                fisrtProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };

            Console.WriteLine(myAnonymousType.fisrtProperty);
        }
    }
}
