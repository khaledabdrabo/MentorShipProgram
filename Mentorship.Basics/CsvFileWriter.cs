namespace Mentorship.Basics;
internal class CsvFileWriter
{
    public static void WriteToCsvFile(string filePath, string[] headers, string[,] data)
    {
        try
        {
            var csvContent = new StringBuilder();
            csvContent.AppendLine(string.Join(",", headers));
            for (int i = 0; i < data.GetLength(0) - 1; i++)
            {
                string[] row = new string[data.GetLength(1)];
                for (int j = 0; j < data.GetLength(0) - 1; j++)
                {
                    row[j] = data[i,j];
                }
                csvContent.AppendLine(string.Join(",", row));
            }
            File.WriteAllText(filePath, csvContent.ToString());
            WriteLine("Data successfully written to CSV file: " + filePath);
        }
        catch (Exception ex)
        {
            WriteLine("An error occurred: " + ex.Message);
        }
    }
}