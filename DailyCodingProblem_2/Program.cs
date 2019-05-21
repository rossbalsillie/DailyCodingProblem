/*  Good morning! Here's your coding interview problem for today.

This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division?
Follow-up: what if one of the integers inputted was a 0, how should this be handled?
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
            //Get the list of integers from the user
            List<int> inputtedIntegers = GetListOfNumbersInput();
            //Create a new list of integers which is the product of all values except the one at index[i]
            List<int> productList = OutputNewListOfIntegers(inputtedIntegers);
            foreach (int number in productList)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        private static List<int> OutputNewListOfIntegers(List<int> initialList)
        {
            List<int> productList = new List<int>();

            //Outer loop
            for (int i = 0; i < initialList.Count; i++)
            {
                //Set the product number to 0 & the initial number
                int productNumber = 0;
                int initialNumber = 0;
                //Inner loop
                for (int j = 0; j < initialList.Count; j++)
                {
                    if (j == i) //If the inner loop and outter loop are at the same point then skip over this index
                    {
                        continue;
                    }
                    else if (initialNumber > 0 && productNumber == 0) //If we have an initial number but the product number is 0 then use the initial number for the first multiplication
                    {
                        productNumber = initialNumber * initialList[j];
                    }
                    else if (initialNumber > 0 && productNumber > 0) //We have an initial number and the product number is greater than 0 so we use the product number in the multiplication
                    {
                        productNumber = productNumber * initialList[j];
                    }
                    else // If we hit this condition then it means the initial number has not yet been set
                    {
                        initialNumber = initialList[j];
                    }
                }
                productList.Add(productNumber);
            }

            return productList;
        }

        //Gets the list of integers inputted from the user and casts them into a new list of ints
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
