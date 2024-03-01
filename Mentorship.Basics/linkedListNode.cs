namespace Mentorship.Basics;

public class linkedListNode<T>
{
    public T Data { get; set; }
    public linkedListNode<T> Next { get; set; }
    public linkedListNode<T> Previous { get; set; }
    public linkedListNode() { }
    public linkedListNode(T data) => this.Data = data;
}