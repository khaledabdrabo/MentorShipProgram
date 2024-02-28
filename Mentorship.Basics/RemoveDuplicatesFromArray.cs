namespace Mentorship.Basics;

internal class RemoveDuplicatesFromArray
{
    public static int[] RemoveDuplicates(int[] array)
    {
        List<int> uniqueElements = new();
        for(int i = 0; i < array.Length; i++) 
        {
            if (!uniqueElements.Contains(array[i]))
            {
                uniqueElements.Add(array[i]);
            }
        }
        return uniqueElements.ToArray();
    }
}