using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems.Arrays___Reverse_Array
{
    public class ReverseArray
    {
        public static void ArrayReverse(int[] array)
        {
            for (int i=0; i<array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length -1 -i];
                array[array.Length - 1 - i] = temp;
            }
        }
    }
}
