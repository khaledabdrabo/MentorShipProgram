using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace problems.Arrays___Two_Sum_Problem
{
    public class Two_Sum_Problem
    {
        public static int[] FindTwoSum(int[] arr, int target)
        {
            Dictionary<int, int> dictionry = new Dictionary<int, int>();
            for (int i=0; i< arr.Length -1 ; i++)
            {
                int complement = target - arr[i];
                if (dictionry.ContainsKey(complement))
                {
                    return new int[] { dictionry[complement],i};
                }
                else
                {
                    dictionry[arr[i]] = i;
                }
            }
            return new int[0]; //return empty array if no solution not found
        }
    }
}
