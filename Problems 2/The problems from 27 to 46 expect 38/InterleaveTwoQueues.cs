using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    internal class InterleaveTwoQueues
    {
        public static Queue<T> InterleaveQueues<T>(Queue<T> queue1, Queue<T> queue2)
        {
            Queue<T> resultQueue = new Queue<T>();

            while (queue1.Count > 0 && queue2.Count > 0)
            {
                resultQueue.Enqueue(queue1.Dequeue());
                resultQueue.Enqueue(queue2.Dequeue());
            }

            // Enqueue remaining elements from non-empty queue1
            while (queue1.Count > 0)
            {
                resultQueue.Enqueue(queue1.Dequeue());
            }

            // Enqueue remaining elements from non-empty queue2
            while (queue2.Count > 0)
            {
                resultQueue.Enqueue(queue2.Dequeue());
            }

            return resultQueue;
        }


    }
}
