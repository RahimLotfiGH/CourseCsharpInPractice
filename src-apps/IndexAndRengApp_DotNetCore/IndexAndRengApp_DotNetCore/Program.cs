using System;

namespace IndexAndRangApp_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbersArray = new int[] {1,2,3,4,5,6,7,8,9,10 };

            var index = new Index(1, true);
            var index2 = ^2;
            var range = new Range(2, 6);

            var numbers = numbersArray[2..^4];

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
         

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
