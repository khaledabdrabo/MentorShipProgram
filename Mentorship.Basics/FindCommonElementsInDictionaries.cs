namespace Mentorship.Basics;
internal class FindCommonElementsInDictionaries
{
    public static Dictionary<int,int> FindCommonElements(Dictionary<int, int> dict1, Dictionary<int, int> dict2)
    {
        Dictionary<int, int> commonElements = new();

        foreach(var item in dict1 )
        {
            if (dict2.Contains(item))
            {
                commonElements.Add(item.Key, item.Value);
            }
        }

        return commonElements;
    }
}