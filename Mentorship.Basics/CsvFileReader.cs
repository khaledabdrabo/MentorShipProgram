namespace Mentorship.Basics;
internal class CsvFileReader
{
    public static void ReadAndParseCsvFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] headers = lines[0].Split(',');
                WriteLine("CSV Headers: " + string.Join(", ", headers));
                for (int i = 1; i < lines.Length; i++)
                {
                    var values = lines[i].Split(",");
                    WriteLine("CSV Row " + i + ": " + string.Join(", ", values));
                }
            }

        }
        catch (Exception ex)
        {
            WriteLine("An error occurred: " + ex.Message);
        }

    }
}
