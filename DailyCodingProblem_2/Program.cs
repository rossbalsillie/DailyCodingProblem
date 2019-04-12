/*  Good morning! Here's your coding interview problem for today.

This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputtedIntegers = GetListOfNumbersInput();
            List<int> productList = OutputNewListOfArray(inputtedIntegers);
            foreach (int number in productList)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        private static List<int> OutputNewListOfArray(List<int> initialList)
        {
            List<int> productList = new List<int>();

            for (int i = 0; i < initialList.Count; i++)
            {
                int productNumber = 0;
                int initialNumber = 0;
                for (int j = 0; j < initialList.Count; j++)
                {                    
                    if (j == i)
                    {
                        continue;
                    }
                    else if (initialNumber > 0 && productNumber == 0)
                    {
                        productNumber = initialNumber * initialList[j];
                    }
                    else if (initialNumber > 0 && productNumber > 0)
                    {
                        productNumber = productNumber * initialList[j];
                    }
                    else
                    {
                        initialNumber = initialList[j];
                    }                    
                }
                productList.Add(productNumber);
            }

            return productList;
        }

        private static List<int> GetListOfNumbersInput()
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
