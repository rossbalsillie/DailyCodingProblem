/* Good morning! Here's your coding interview problem for today.

This problem was asked by Facebook.

Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.

For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.

You can assume that the messages are decodable. For example, '001' is not allowed.*/
using System;
using System.Collections.Generic;

namespace DailyCodingProblem_7
{
    public class DCP7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mapping map = new Mapping();
            Dictionary<string, int> dict = map.GetMap();
        }

        public int FindAllPossibleDecodings(string input, Dictionary<string, int> dict)
        {

            return 0;
        }

    }
}
