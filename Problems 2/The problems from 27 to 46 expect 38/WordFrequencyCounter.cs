using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Problems_2.The_problems_from_27_to_46
{
    public class WordFrequencyCounter
    {
        public static Dictionary<string,int> CountWordFrequency(string text)
        {
           Dictionary<string,int> wordFrequencyDictionary = new Dictionary<string, int>();
            string[] words = TokenizeTextIntoWords(text);

            foreach (string word in words)
            {
                if (wordFrequencyDictionary.ContainsKey(word))
                {
                    wordFrequencyDictionary[word] ++;
                }
                else
                {
                    wordFrequencyDictionary[word] = 1;
                }
            }
            return wordFrequencyDictionary;


        }
        public static string[] TokenizeTextIntoWords(string text)
        {
            string[] words = Regex.Split(text.ToLower(), @"\W+");
            return words;
        }
    }
}
