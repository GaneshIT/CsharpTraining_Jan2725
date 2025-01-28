using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class Test
    {
        public void Find(int[] values)
        {
            //[0,1,0,2,1,0,1,3,2,1,2,1] - 6
            //[4,2,0,3,2,5] - 9

            int sum = 0;
            Array.Sort(values);
            int value = values[values.Length - 2];
            foreach (int i in values) 
            { 
                if(i!=value && i<=value)
                sum += value-i;
            }
            Console.WriteLine(sum);
        }

        public bool Find1(string str)
        {
            //'(', ')', '{', '}', '[' and ']'
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                { ')','(' },
                { '}','{' },
                { ']','[' }
            };
            foreach (var c in str)
            {
                if (dict.ContainsValue(c))
                    stack.Push(c);
                else if (dict.ContainsKey(c))
                {
                    if (stack.Pop() != dict[c])
                        return false;
                }
            }
            bool flag = stack.Count == 0;
            return flag;
        }
    }
}

/*
 * 
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 
Example 1:
Input: s = "()"
Output: true
Example 2:
Input: s = "()[]{}"
Output: true
Example 3:
Input: s = "(]"
Output: false
Example 4:
Input: s = "([])"
Output: true
 */