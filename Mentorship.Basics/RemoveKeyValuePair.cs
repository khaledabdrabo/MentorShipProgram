namespace Mentorship.Basics;
internal class RemoveKeyValuePair
{
    public static void RemoveKeyValuePairFunction(Dictionary<int,int> originalDictionary, int keyToRemove)
    {
        if(originalDictionary.ContainsKey(keyToRemove))
        {
            originalDictionary.Remove(keyToRemove);
        }
    }
}