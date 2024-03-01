namespace Mentorship.Basics;
internal class TextFileWriter
{
    public static void WriteToTextFile(string filePath, string data)
    {
        try
        {
            File.WriteAllText(filePath, data);
            Console.WriteLine("Data successfully written to file: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}