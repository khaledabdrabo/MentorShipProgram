using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class NestedLoops
    {
       public static void  CreatePattern(string rows, string columns)
        {
            for (int i=1; i <= rows.Length; i++)
            {
                for (int j = 1; j <= columns.Length; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
        }
    }
}
