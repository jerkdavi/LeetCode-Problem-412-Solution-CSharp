using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //412.
            //int n = 3;
            //int n = 5;
            //int n = 15;
            Console.Write("Enter value of number n: ");
            int n = int.Parse(Console.ReadLine());

            IList<string> list = Solution.FizzBuzz(n);
            
            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(",");
                }
                Console.Write(list[i]);
            }

            Console.WriteLine("\nDone processing");
            Console.ReadLine();
        }
    }
}
