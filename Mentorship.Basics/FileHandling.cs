namespace Mentorship.Basics;
internal class FileHandling
{
    public static void ReadAndProcessDataFromFile(string filePath)
    {
        using (FileStream file = new(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            byte[] fileData = new byte[file.Length];
            file.Read(fileData, 0, (int)file.Length);
            ProcessData(fileData);
            file.Write(fileData);
        }
    }

    // procssing the data after reading it from the file
    private static void ProcessData(byte[] fileData)
    {
        for (int i = 0; i < fileData.Length; i++)
        {
            fileData[i] += 32;
        }
    }
}