namespace Mentorship.Basics;

public class WhileLoop
{
    public static void UserInputValidation()
    {
        bool validInput = false;
        WriteLine("please enter a valid input");
        while (!validInput) 
        {
            if (ReadLine().ToLower() == "dotnet")
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

}