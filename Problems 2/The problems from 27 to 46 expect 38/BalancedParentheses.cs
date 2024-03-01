using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class BalancedParentheses
    {
        public static bool CheckBalancedParentheses(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char character in expression)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else if (character == ')' || character == '}' || character == ']')
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Peek(), character))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        public static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') || (opening == '{' && closing == '}') || (opening == '[' && closing == ']');
        }
    }
}
