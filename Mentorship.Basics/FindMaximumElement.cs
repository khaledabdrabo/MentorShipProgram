namespace Mentorship.Basics;

internal class FindMaximumElement
{
    public static void FindMaxElement(long[] array)
    {
        long result = Int64.MinValue;
        for(int i = 0; i < array.Length; i++)
        {
            result = Max(result, array[i]);
        }
        WriteLine($"the maximum element is {result}");
    }
}