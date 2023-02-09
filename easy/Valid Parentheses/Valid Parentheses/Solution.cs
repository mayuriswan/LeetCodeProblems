using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class Solution
    {
        public bool isValid(string s)
        {
            if (s.Length % 2 != 0 || s[0] == ')' || s[0] == '}' || s[0] == ']')
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                    Console.WriteLine("push " + s[i]);
                }
                else if (stack.Count > 0 && stack.Peek() == '{' && s[i] == '}')
                {
                    stack.Pop();
                    Console.WriteLine("remove " + s[i]);
                }
                else if (stack.Count > 0 && stack.Peek() == '[' && s[i] == ']')
                {
                    stack.Pop();
                    Console.WriteLine("remove " + s[i]);
                }
                else if (stack.Count > 0 && stack.Peek() == '(' && s[i] == ')')
                {
                    stack.Pop();
                    Console.WriteLine("remove " + s[i] + "3");
                }
                else {
                    stack.Push(s[i]);
                }

            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
