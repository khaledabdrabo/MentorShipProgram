namespace Mentorship.Basics;

internal class DoWhileLoop
{
    public static void RepeatBasedOnUserInput()
    {
        WriteLine("This while continue until you write \"exit\"");
        string userInput;
        do
        {
            userInput = ReadLine();
        } while (userInput.ToLower() != "exit");
    }
}