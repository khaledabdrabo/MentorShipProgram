using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class PrintBinaryNumbers
    {
       public static void PrintFirstNBinaryNumbers(int n)
        {
            Queue<string> binaryQueue = new Queue<string>();

            for (int i=1; i<=n; i++)
            {
                binaryQueue.Enqueue(i.ToString());
            }
            while (binaryQueue.Count > 0)
            {
                Console.WriteLine(binaryQueue.Dequeue());
            }
        }
    }
}
