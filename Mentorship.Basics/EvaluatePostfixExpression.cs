namespace Mentorship.Basics;

internal class EvaluatePostfixExpression
{
    public static string EvaluatePostfix(string expression)
    {
        string[] array = expression.Split(" ");
        stack<string> myStack = new();

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == "+" || array[i] == "-" || array[i] == "*" || array[i] == "/")
            {
                string operand1 = myStack.Peak();
                myStack.Pop();
                string operand2 = myStack.Peak();
                myStack.Pop();
                string result = evaluate(operand1, operand2, array[i]);
                myStack.Push(result);
            }
            else
            {
                myStack.Push(array[i]);
            }
        }

        return myStack.Peak();
    }
    private static string evaluate(string operand1, string operand2, string element)
    {
        string result = "";
        if(element == "+")
        {
            result = (int.Parse(operand1) + int.Parse(operand2)).ToString();
        }
        else if (element == "-")
        {
            result = (int.Parse(operand1) - int.Parse(operand2)).ToString();
        }
        else if (element == "*")
        {
            result = (int.Parse(operand1) * int.Parse(operand2)).ToString();
        }
        else if (element == "/")
        {
            result = ((double)(int.Parse(operand1)) / int.Parse(operand2)).ToString();
        }
        return result;
    }
}