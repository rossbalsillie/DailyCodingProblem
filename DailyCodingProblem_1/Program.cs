/* Good morning! Here's your coding interview problem for today.

This problem was recently asked by Google.

Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

Bonus: Can you do this in one pass?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello, please enter a space separated list of numbers!");
            string input = Console.ReadLine();
            List<int> listOfInts = GetListOfIntegers(input);

            Console.WriteLine("Now please add a number for me to check for.");
            int checkForNumber = int.Parse(Console.ReadLine());

            if  (CheckIfListOfIntsCanEqualNumberX(listOfInts, checkForNumber))
            {
                Console.WriteLine(string.Format("The number {0} can be added together by the numbers in the list you provided!", checkForNumber));
            } else
            {
                Console.WriteLine(string.Format("The number {0} can not be added together by the numbers in the list you provided!", checkForNumber));
            }
            Console.ReadKey();            
        }

        private static bool CheckIfListOfIntsCanEqualNumberX(List<int> listOfInts, int checkForNumber)
        {            
            for (int i = 0; i < listOfInts.Count; i++)
            {
                for (int j = i + 1; j < listOfInts.Count; j++)
                {
                    int addTogether = listOfInts[i] + listOfInts[j];
                    if (addTogether == checkForNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static List<int> GetListOfIntegers(string input)
        {
            string[] inputArr = input.Split(' ');
            List<int> intList = new List<int>();
            foreach (string item in inputArr)
            {
                if (int.TryParse(item, out int intConverted))
                {
                    intList.Add(intConverted);
                }
            }
            return intList;
        }
    }
}
