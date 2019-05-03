/* Good morning! Here's your coding interview problem for today.

This problem was asked by Stripe.

Given an array of integers, find the first missing positive integer in linear time and constant space. In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.

For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.*/

using System;
using System.Collections.Generic;

namespace DailyCodingProblem_4
{
    public class DCP4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public int FindLowestPositiveInteger(List<int> ints)
        {
            //Only works currently for sorted lists
            //Needs reworked to function correctly for unsorted lists
            int lowestPositiveInteger = 1;
            foreach (int number in ints)
            {
                if (number == lowestPositiveInteger)
                {
                    lowestPositiveInteger++;
                }
            }
            return lowestPositiveInteger;
        }

    }
}
