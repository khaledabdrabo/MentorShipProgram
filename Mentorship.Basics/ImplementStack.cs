namespace Mentorship.Basics;

internal class ImplementStack
{
    public static void StackImplementation()
    {
        stack<int> myStack = new stack<int>();
        myStack.Push(3);
        myStack.Push(2);
        myStack.Push(1);
        myStack.Push(0);
        if (!myStack.IsEmpty())
        {
            myStack.Pop();
        }
        while (!myStack.IsEmpty())
        {
            Write(myStack.Peak() + " ");
            myStack.Pop();
        }
    }
}