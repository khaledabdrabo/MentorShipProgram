namespace Mentorship.Basics;

internal class MultiDimensionalArrays
{
    public static void InitializeGameBoard(int rows, int columns)
    {
        int[,] array = new int[rows,columns];
        for(int i = 0; i < rows; i++) 
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = 1;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Write(array[i,j]+" ");
            }
            WriteLine();
        }
    }
}