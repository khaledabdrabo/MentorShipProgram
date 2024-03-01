namespace Mentorship.Basics;
internal class SortStack
{
    public static stack<int> SortStackFunction(stack<int> myStack)
    {
        stack<int> sortedStack = new();
        while (!myStack.IsEmpty())
        {
            int element = myStack.Peak();
            myStack.Pop();
            while (!sortedStack.IsEmpty() && element < sortedStack.Peak())
            {
                myStack.Push(sortedStack.Peak());
                sortedStack.Pop();
            }
            sortedStack.Push(element);
        }
        return sortedStack;
    }
}


