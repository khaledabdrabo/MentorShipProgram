using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class ImplementStack
    {
        public static void StackImplementation()
        {
            Stack<int> stack = new Stack<int>();

            // Push elements onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            
            // Pop elements from the stack
            Console.WriteLine("Popped elements:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
