namespace Mentorship.Basics;

internal class NestedLoops
{
    public static void CreatePattern(int rows, int columns)
    {
        for(int i=0;i<rows;i++) 
        {
            for(int  j=0;j<columns;j++)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}