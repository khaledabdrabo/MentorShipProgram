public class TypeConversion
{
    public static void ConvertStringToInteger(string userAgeString) 
    {
        try
        {
            int age = int.Parse(userAgeString);
            System.Console.WriteLine($"you are {age} years old.");
        }
        catch(FormatException formatException)
        {
            System.Console.WriteLine("invalid age , please enter a correct number");
        }
    }
}