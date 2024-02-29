namespace Mentorship.Basics;

internal partial class LinkedListImplementation
{
    public static void ImplementLinkedList()
    {
        linkedList<int> myLinkedList = new();
        myLinkedList.AddNode(1);
        myLinkedList.AddNode(2);
        myLinkedList.AddNode(3);
        myLinkedList.AddNode(4);
        myLinkedList.RemoveNode(4);
        myLinkedList.DisplayList();
    }
}