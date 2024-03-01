namespace Mentorship.Basics;

internal class ReverseFirstKElement
{
    public static void ReverseFirstKElementImplementation(queue<int> myQueue, int k)
    {
        int[] array = new int[k];
        queue<int> tempQueue = new();

        for (int i = 0; i < k; i++)
        {
            array[i] = myQueue.DeQueue();
        }

        Array.Reverse(array);

        while (!myQueue.IsEmpty())
        {
            tempQueue.EnQueue(myQueue.DeQueue());
        }

        foreach(int item in array)
        {
            myQueue.EnQueue(item);
        }
        while (!tempQueue.IsEmpty())
        {
            myQueue.EnQueue(tempQueue.DeQueue());
        }
    }
}