namespace Mentorship.Basics;
internal class ReverseFirstKElement
{
    public static queue<int> ReverseFirstKElementImplementation(queue<int> myQueue, int k)
    {
        int[] array = new int[myQueue.Size];
        for (int i = k - 1; i >= 0; i--)
        {
            array[i] = myQueue.DeQueue();
        }
        for (int i = k; i < array.Length; i++)
        {
            array[i] = myQueue.DeQueue();
        }
        for (int i = 0; i < array.Length; i++)
        {
            myQueue.EnQueue(array[i]);
        }

        return myQueue;
    }
}