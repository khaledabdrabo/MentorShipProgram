namespace Mentorship.Basics;

internal class MergeDictionaries
{
    public static Dictionary<int,int> MergeTwoDictionaries(Dictionary<int, int>  dict1, Dictionary<int, int> dict2)
    {
        Dictionary<int, int> mergedDictionary = new(dict1);
        foreach(var item in dict2)
        {
            if(!mergedDictionary.Contains(item))
            {
                mergedDictionary.Add(item.Key,item.Value);
            }
        }
        return mergedDictionary;
    }
}