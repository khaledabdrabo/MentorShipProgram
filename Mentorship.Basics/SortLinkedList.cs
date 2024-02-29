namespace Mentorship.Basics;

internal class SortLinkedList
{
    public static void SortLinkedListFunction(linkedList<int> mylinkedList)
    {
        for(var i =mylinkedList.Head; i!=null; i=i.Next)
        {
            for(var j = mylinkedList.Head; j!=null; j=j.Next)
            {
                if (i.Data < j.Data)
                {
                    (i.Data,j.Data) = (j.Data, i.Data);
                }
            }
        }
    }
}