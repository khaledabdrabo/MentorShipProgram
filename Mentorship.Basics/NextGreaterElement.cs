namespace Mentorship.Basics;

internal class NextGreaterElement
{
    public static Dictionary<int, int> FindNextGreaterElement(int[] array)
    {
        stack<int> myStack = new();
        var resultDictionary = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            while (!myStack.IsEmpty() && array[i] > myStack.Peak())
            {
                resultDictionary[myStack.Peak()] = array[i];
                myStack.Pop();
            }

            myStack.Push(array[i]);
        }

        while (!myStack.IsEmpty())
        {
            resultDictionary[myStack.Peak()] = -1;
            myStack.Pop();
        }

        return resultDictionary;
    }
}
