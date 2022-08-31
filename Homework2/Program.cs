using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wrong
            //int i;
            //for (i = 1; i < 10; i++)
            //{
            //    if ((i % 2) = 0)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //correct
            int i;
            for (i = 1; i < 10; i++)
            {
                if ((i % 2) == 0) //se koristeshe operator za dodeluvanje na vrednost a treba da se koristi operator za sporedba
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
