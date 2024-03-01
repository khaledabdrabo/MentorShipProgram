namespace Mentorship.Basics;

internal class BalancedParentheses
{
    public static bool CheckBalancedParentheses(string expression)
    {
        stack<char> myStack = new stack<char>();
        foreach(char item in expression)
        {
            if (item == '(' || item == '[' || item == '{' || item == '<')
            {
                myStack.Push(item);
            }
            else
            {
                if (!myStack.IsEmpty() &&
                    (item == ')' && myStack.Peak() == '(')
                    || (item == '}' && myStack.Peak() == '{')
                    || (item == ']' && myStack.Peak() == '[')
                    || (item == '>' && myStack.Peak() == '<'))
                {
                    myStack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
     
        return myStack.IsEmpty() ? true : false;
    }
}