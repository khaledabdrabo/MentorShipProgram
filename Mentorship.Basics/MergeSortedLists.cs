namespace Mentorship.Basics;

internal class MergeSortedLists
{
    public static linkedList<int> MergeSortedListsFunction(linkedList<int> list1, linkedList<int>  list2)
    {
        linkedList<int> mergedList = new();
        while(list1.Head != null && list2.Head != null)
        {
            if(list1.Head.Data >= list2.Head.Data)
            {
                mergedList.AddNode(list1.Head.Data);
                list1.RemoveNode(list1.Head.Data);
            }
            else
            {
                mergedList.AddNode(list2.Head.Data);
                list2.RemoveNode(list2.Head.Data);
            }
        }

        while (list1.Head != null )
        {
            mergedList.AddNode(list1.Head.Data);
            list1.RemoveNode(list1.Head.Data);
        }
        while (list2.Head != null)
        {
            mergedList.AddNode(list2.Head.Data);
            list2.RemoveNode(list2.Head.Data);
        }

            return mergedList;
    }
}