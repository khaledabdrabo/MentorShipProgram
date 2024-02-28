namespace Mentorship.Basics;

internal class ArrayReverse
{
    public static void ReverseArray(int [] array)
    {
        //Array.Reverse(array);

        for(int i = 0; i < array.Length/2; i++) 
        {
            /*
             int temp = array[i];
             array[i] =  array[array.Length - 1 - i];
             array[array.Length - 1 - i] = temp;
            */

            (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]); 
        }

        foreach(int number in array)
        {
            Write(number+" ");
        }
    }
}