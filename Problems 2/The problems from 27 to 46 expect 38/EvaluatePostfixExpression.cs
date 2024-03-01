using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class EvaluatePostfixExpression
    {
        public static int EvaluatePostfix(string expression)
        {
        

        Stack<int> stack = new Stack<int>();
        foreach (char element in expression)
        {
            if (Char.IsDigit(element))
            {
                // If element is operand, push onto stack
                stack.Push(element - '0'); 
            }
            else if (IsOperator(element))
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();
                int result = Evaluate(operand1, operand2, element);
                stack.Push(result);
            }
        }

            // Return the top element of the stack
            return stack.Peek();
        }

        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private static int Evaluate(int operand1, int operand2, char op)
        {
                switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 == 0)
                    {
                        throw new Exception("Division by zero");
                    }
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator");
            }       
        }
    }
}
