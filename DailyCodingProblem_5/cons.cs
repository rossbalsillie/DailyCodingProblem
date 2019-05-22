using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblem_5
{
    class Cons
    {
        public string[] Construct(string key, string value)
        {
            string[] cons = { key, value };
            return cons;
        }

        public string Car(string[] pair)
        {
            return pair[0];
        }

        public string Cdr(string[] pair)
        {
            return pair[1];
        }

    }
}
