﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, bool> filter = (allDividers, number) =>
            {
                bool divisible = true;

                for (int i = 0; i < allDividers.Length; i++)
                {
                    if (number%allDividers[i] !=0)
                    {
                        divisible = false;
                        break;
                    }
                }
                return divisible;
            };

            int[] divisibleNumbers = Enumerable.Range(1, range)
                .Where(number => filter(dividers, number))
                .ToArray();

            Console.WriteLine(string.Join(' ',divisibleNumbers));
        }
    }
}
