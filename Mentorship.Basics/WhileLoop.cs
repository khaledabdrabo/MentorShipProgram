namespace Mentorship.Basics;

public class WhileLoop
{
    public static void UserInputValidation()
    {
        bool validInput = false;
        while (!validInput) 
        {
            WriteLine("please enter a valid input");
            if (ReadLine().ToLower() == "dotnet")
            {
                validInput = true;
            }
        }
    }

}