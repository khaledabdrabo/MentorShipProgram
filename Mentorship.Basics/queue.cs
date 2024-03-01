namespace Mentorship.Basics;
internal class queue<T>
{
    public queue()
    {
        Head = null;
        Tail = null;
    }

    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }
    private int _size { get; set; }
    public int Size => _size;

    public void EnQueue(T data)
    {
        Node<T> temp = new(null, data);

        if (Tail == null)
        {
            Head = temp;
            Tail = temp;
        }
        else
        {
            Tail.Next = temp;
            Tail = temp;
        }
        _size++;
    }

    public T DeQueue()
    {
        T item = Head.Data;
        Head = Head.Next;
        _size--;
        return item;
    }

    public T Front() => Head.Data;

    public bool IsEmpty() => Size == 0; // Head == null || Tail == null;

    private class Node<T>
    {
        public Node(Node<T> next, T data)
        {
            Next = next;
            Data = data;
        }

        public Node<T> Next { get; set; }
        public T Data { get; set; }
    }
}