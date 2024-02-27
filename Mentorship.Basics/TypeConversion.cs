namespace Mentorship.Basics;
public class TypeConversion
{
    public static void ConvertStringToInteger(string userAgeString) 
    {
        try
        {
            int age = int.Parse(userAgeString);
            System.Console.WriteLine($"you are {age} years old.");
        }
        catch(FormatException)
        {
            System.Console.WriteLine(new FormatException("invalid age , please enter a correct number"));
        }
    }
}