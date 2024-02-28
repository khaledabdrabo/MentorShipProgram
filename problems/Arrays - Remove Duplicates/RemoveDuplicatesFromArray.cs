using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace problems.Arrays___Remove_Duplicates
{
    public class RemoveDuplicatesFromArray
    {
        public static int[] RemoveDuplicates(int[] array)
        {
            List<int> uniqueElements = new List<int>();
            foreach (int element in array)
            {
                if (!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                }
            }
            int[] resultArray = uniqueElements.ToArray();
            return resultArray;

        }
    }
}
