using System.Linq.Expressions;

namespace Mentorship.Basics;

internal class ErrorHandling
{
    public static void HandleInvalidInput(string userInput)
    {
        try 
        {
            int number = int.Parse(userInput);
        }
        catch(FormatException exception)
        {
            WriteLine(exception.Message);
        }
    }
}