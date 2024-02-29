using static System.Net.Mime.MediaTypeNames;

namespace Mentorship.Basics;

internal class WordFrequencyCounter
{
    public static void CountWordFrequency(string text)
    {
        string[] words = text.Split(' ');
        Dictionary<string, int> dictionary = new();
        foreach(var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }
        foreach( var pair in dictionary)
        {
            WriteLine($"the word {pair.Key} has appeared {pair.Value} times");
        }
    }
}