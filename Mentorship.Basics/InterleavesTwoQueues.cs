namespace Mentorship.Basics
{
    internal class InterleavesTwoQueues
    {
        public static queue<int> InterleaveTwoQueues(queue<int> queue1, queue<int> queue2)
        {
            queue<int> resultQueue = new();
            while (!queue1.IsEmpty() && !queue2.IsEmpty())
            {
                resultQueue.EnQueue(queue1.DeQueue());
                resultQueue.EnQueue(queue2.DeQueue());
            }

            while (!queue1.IsEmpty())
            {
                resultQueue.EnQueue(queue1.DeQueue());
            }

            while (!queue2.IsEmpty())
            {
                resultQueue.EnQueue(queue2.DeQueue());
            }

            return resultQueue;
        }
    }
}
