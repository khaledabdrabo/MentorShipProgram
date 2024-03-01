using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class ImplementQueue
    {
       public static void ImplementQueu()
       {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            // Dequeue elements from the queue
            while (queue.Count > 0)
            {
                int dequeuedElement = queue.Dequeue();
                Console.WriteLine(dequeuedElement);
            }
        }
    }
}
