namespace Mentorship.Basics;

internal class ArraysInitialization
{
    public static void InitializePlayerScoresArray()
    {
        int[] array = new int[] { 0, 0, 0, 0, 0 };
        for(int i=0; i < array.Length; i++) 
        {
            Write($"{array[i]} ");
        }
    }
}