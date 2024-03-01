using System.Drawing;

namespace Mentorship.Basics;

internal class stack<T>
{
    private linkedList<T> list;
    private int _size { get; set; }
    public int Size => _size;
    public stack()
    {
        list = new();
    }
    public void Push(T data)
    {
        linkedListNode<T> node = new(data);
        node.Next = list.Head;
        list.Head = node;
        _size++;
    }
    public void Pop()
    {
        if (list.Head == null)
        {
            return;
        }
        list.RemoveNode(list.Head.Data);
        _size--;
    }
    public bool IsEmpty() => list.Head == null; // Size == 0;
    public T Peak() => list.Head.Data; 
}