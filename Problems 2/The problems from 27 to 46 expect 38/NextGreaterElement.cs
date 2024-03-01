using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class NextGreaterElement
    {
        public static Dictionary<int, int> FindNextGreaterElement(int[] array)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                while (stack.Count > 0 && array[i] > stack.Peek())
                {
                    resultDictionary[stack.Pop()] = array[i];
                }
                stack.Push(array[i]);
            }

            // Remaining elements in stack have no greater element
            while (stack.Count > 0)
            {
                resultDictionary[stack.Pop()] = -1;
            }

            return resultDictionary;
        }
    }
}
