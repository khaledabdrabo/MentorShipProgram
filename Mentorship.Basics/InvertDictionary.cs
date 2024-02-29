namespace Mentorship.Basics;

internal class InvertDictionary
{
    public static Dictionary<int,int> InvertDictionaryFunction(Dictionary<int, int> originalDictionary)
    {
        Dictionary<int, int> invertedDictionary = new();

        foreach(var item in originalDictionary)
        {
            invertedDictionary.Add(item.Value, item.Key);
        }

        return invertedDictionary;
    }

}