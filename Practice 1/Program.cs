using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                Console.WriteLine("");
            }
        }
    }
}
