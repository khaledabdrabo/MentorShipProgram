using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems.File_Handling
{
    public class FileHandling
    {
       public static void ReadAndProcessDataFromFile(string filePath)
        {
            try
            {
                string fileData = ReadFile(filePath);
                ProcessData(fileData);
            } catch (Exception ex)
            {
                Console.WriteLine($"An Error occureed: {ex.Message}");
            }
        }
        public static string ReadFile(string filePath)
        {
            try
            {
              return File.ReadAllText(filePath);
            } 
            catch (Exception)
            {
                throw new Exception("Error");
            }
        }
        public static void ProcessData(string filedata)
        {
            Console.WriteLine($"Data processed: {filedata}");
        }
    }
}
