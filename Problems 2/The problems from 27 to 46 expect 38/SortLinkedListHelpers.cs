internal static class SortLinkedListHelpers
{


    public static LinkedList SortedLinkedList(LinkedList linkedList)
    {
        if (linkedList == null || linkedList.head == null)
        {
            return linkedList;
        }

        Node sortedList = linkedList.head;

        for (Node node = sortedList; node != null; node = node.next)
        {
            for (Node nextNode = node.next; nextNode != null; nextNode = nextNode.next)
            {
                if (node.data > nextNode.data)
                {
                    int temp = node.data;
                    node.data = nextNode.data;
                    nextNode.data = temp;
                }
            }
        }
        return linkedList;
    }
}