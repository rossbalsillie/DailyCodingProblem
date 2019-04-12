/* Good morning! Here's your coding interview problem for today.

This problem was asked by Google.

Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.

For example, given the following Node class

class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

The following test should pass:

node = Node('root', Node('left', Node('left.left')), Node('right'))
assert deserialize(serialize(node)).left.left.val == 'left.left'
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Tree library? Implement own?
            //Node class would need to be implemented as well.

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
