namespace Mentorship.Basics;

public class linkedList<T>
 {
    public linkedListNode<T> Head { get; set; } = null;
    public linkedList() { }
    public linkedList(T[] array)
    {
        foreach(T item in array)
        {
            linkedListNode<T> node = new();
            node.Data = item;
            node.Next = Head;
            Head = node;
        }
    }
    public void AddNode(T data)
        {
            linkedListNode<T> node = new();
            node.Data = data;
            node.Next = Head;
            Head = node;
        }

        public void RemoveNode(T data)
        {
            for(var i = Head; i!=null; i = i.Next)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    return;
                }
                if (i.Next != null&& (i.Next).Data.Equals(data))
                {
                    i.Next = (i.Next).Next;
                    return;
                }
            }
        }
        public void DisplayList()
        {
            for(var i = Head; i != null; i = i.Next)
            {
                Write(i.Data + " ");
            }
     }
 }
