using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblem_7
{
    public class Mapping
    {
        Dictionary<string, int> _dict;
        public Mapping()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 1);
            dict.Add("b", 2);
            dict.Add("c", 3);
            dict.Add("d", 4);
            dict.Add("e", 5);
            dict.Add("f", 6);
            dict.Add("g", 7);
            dict.Add("h", 8);
            dict.Add("i", 9);
            dict.Add("j", 10);
            dict.Add("k", 11);
            dict.Add("l", 12);
            dict.Add("m", 13);
            dict.Add("n", 14);
            dict.Add("o", 15);
            dict.Add("p", 16);
            dict.Add("q", 17);
            dict.Add("r", 18);
            dict.Add("s", 19);
            dict.Add("t", 20);
            dict.Add("u", 21);
            dict.Add("v", 22);
            dict.Add("w", 23);
            dict.Add("x", 24);
            dict.Add("y", 25);
            dict.Add("z", 26);
            _dict = dict;
        }

        public Dictionary<string, int> GetMap()
        {
            return _dict;
        }

    }
}
