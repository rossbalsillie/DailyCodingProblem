using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = displayFirstNumbers();
            int[] productNumbers;
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                for (int x = 0; x < firstNumbers.Length; x++)
                {
                    int newNumber = firstNumbers[i];
                    if (i == x)
                    {
                        continue;
                    } else
                    {
                        newNumber *= firstNumbers[x];
                    }
                    productNumbers[i] = newNumber;
                }
            }
            Console.ReadKey();
        }

        private static int[] displayFirstNumbers()
        {
            Console.WriteLine("Please enter a list of space seperated number");
            string sNumbers = Console.ReadLine();

            var firstNumbers = sNumbers.Split(' ').Select(Int32.Parse).ToArray();

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                Console.WriteLine(firstNumbers[i]);
            }
            return firstNumbers;
        }
    }
}
