namespace Mentorship.Basics;

internal class DetectLoopInLinkedList
{
    public static bool DetectLoop(linkedList<int> myLinkedList)
    {
        if (myLinkedList == null || myLinkedList.Head == null)
        {
            return false;
        }
        var slowPointer = myLinkedList.Head;
        var fastPointer = myLinkedList.Head;

        while (slowPointer != null && fastPointer.Next != null)
        {
            slowPointer = slowPointer.Next;
            fastPointer = fastPointer.Next.Next;
        }

        if(slowPointer == fastPointer)
        {
            return true;
        }
        return false;
    }
}