using System;
using System.Collections.Generic;
using System.Text;

namespace CheckParanthesis
{
    internal class ValidParenthesis
    {
        public Boolean check(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }

                char top = stack.Peek();
                if (top == '(' && ch == ')' || top == '{' && ch == '}' || top == '[' && ch == ']')
                {
                    stack.Pop();
                    if (stack.Count == 0)
                        return true;
                }
            }
            return false;
        }
    }
}
