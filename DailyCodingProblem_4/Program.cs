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
            //Get the list of integers from the user
            DCP4 dcp4 = new DCP4();
            List<int> inputtedIntegers = dcp4.GetListOfNumbersInput();
            int lowestPositiveInt = dcp4.FindLowestPositiveIntegerNotInList(inputtedIntegers);
            Console.WriteLine(string.Format("The lowest possible integer out of the list provided was {0}", lowestPositiveInt));
            Console.ReadKey();
        }

        public int FindLowestPositiveIntegerNotInList(List<int> ints)
        {
            //Only works currently for sorted lists
            //Needs reworked to function correctly for unsorted lists
            ints.Sort();
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

        //Gets the list of integers inputted from the user and casts them into a new list of ints
        public List<int> GetListOfNumbersInput()
        {
            Console.WriteLine("Please Provide a list of space separated numbers!");
            List<string> listOfStrings = new List<string>(Console.ReadLine().Split(' '));
            List<int> listOfIntegers = new List<int>();
            foreach (string item in listOfStrings)
            {
                if (int.TryParse(item, out int intConverted))
                {
                    listOfIntegers.Add(intConverted);
                }
            }            
            return listOfIntegers;
        }

    }
}
