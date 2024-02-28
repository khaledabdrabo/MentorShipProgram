using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems.Arrays___Find_Maximum_Element
{
    public class FindMaximumElement
    {
        public static int FindMaxElement(int[] array) 
        {
            int maxElement = array[0];
            for (int i =1; i<array.Length-1; i++ )
            {
                if (array[i]> maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
    }
}
