using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numArray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            Console.WriteLine("Written with for.");
            Console.WriteLine();
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 == 0)
                {
                    evens.Add(numArray[i]);
                    Console.WriteLine($"{i} is an odd number.");
                }
                else
                {
                    odds.Add(numArray[i]);
                    Console.WriteLine($"{i} is an even number.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Written with for each.");
            Console.WriteLine();
            foreach (var num in numArray)
            { 
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{num} is an odd number.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Displaying layout of numbers in the 'evens' list.");
            Console.WriteLine();
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (var mun in evens)
            {
                Console.WriteLine($"{mun} is an even number.");
            }
            Console.WriteLine();
            Console.WriteLine("Displaying layout of numbers in the 'odds' list.");
            Console.WriteLine();
            foreach (var mun in odds)
            {
                Console.WriteLine($"{mun} is an odd number.");
            }
            Console.WriteLine();
            Console.WriteLine("Making similar attempt, but with for.");
            Console.WriteLine();
            Console.WriteLine("Evens.");
            Console.WriteLine();
            for (int a = 0; a < evens.Count + evens.Count; a += 2)
            {
                Console.WriteLine($"{a} is most certainly an even number.");
            }
            Console.WriteLine();
            Console.WriteLine("Odds.");
            Console.WriteLine();
            for (int b = 1; b < odds.Count + odds.Count; b += 2)
            {
                Console.WriteLine($"{b} certainly seems like an odd number.");
            }
        }
    }
}
