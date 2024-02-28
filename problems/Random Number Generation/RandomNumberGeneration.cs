using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems.Random_Number_Generation
{
    public class RandomNumberGeneration
    {
        

        public static int GenerateRandomIndex(int length)
        {
            Random random = new Random();
            return random.Next(length);
        }
        public static string GenerateRandomQuestion(string[] questions)
        {
            int randomIndex = GenerateRandomIndex(questions.Length);
            string randomQuestion = questions[randomIndex];
            return randomQuestion;
        }
        
    }
}
