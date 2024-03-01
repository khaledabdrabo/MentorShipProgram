namespace Mentorship.Basics;

internal class ImplementQueue
{
    public static void QueueImplementation()
    {
        queue<int> myQueue = new();
        myQueue.EnQueue(1);
        myQueue.EnQueue(2);
        myQueue.EnQueue(3);
        myQueue.EnQueue(4);
        while (!myQueue.IsEmpty())
        {
            Write(myQueue.DeQueue()+" ");
        }
    }
}
