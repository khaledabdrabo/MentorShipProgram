namespace Mentorship.Basics;

internal class MergeArrays
{
    public static void MergeTwoArrays(int[] array1, int[] array2)
    {
        int[] mergeArray = new int[array1.Length + array2.Length];
        int length1 = 0;
        int length2 = 0;
        int totalLength = 0;
        while(length1 < array1.Length  && length2 < array2.Length)
        {
            if (array1[length1] <= array2[length2])
            {
                mergeArray[totalLength++]= array1[length1++];
            }
            else
            {
                mergeArray[totalLength++] = array2[length2++];
            }

        }

        while (length1 < array1.Length)
        {
            mergeArray[totalLength++] = array1[length1++];
        }

        while (length2 < array2.Length)
        {
            mergeArray[totalLength++] = array2[length2++];
        }

        foreach(int item in mergeArray)
        {
            Write(item + " ");
        }
    }
}