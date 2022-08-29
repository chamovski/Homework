using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            int result;

            Console.WriteLine("Enter Number 1");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");

            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 4");

            num4 = Convert.ToInt32(Console.ReadLine());

            result = num1 * num2 * num3 * num4;

            double res = Convert.ToDouble(result);

            Console.WriteLine("Your Result is  " + res);

        }
    }
}
