using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class SortStack
    {
        public static Stack<int> SortedStack(Stack<int> stack)
        {
            Stack<int> sortedStack = new Stack<int>();

            while (stack.Count > 0)
            {
                int temp = stack.Pop();

                while (sortedStack.Count > 0 && temp < sortedStack.Peek())
                {
                    stack.Push(sortedStack.Pop());
                }
            }
            return sortedStack;
        }
    }
}
