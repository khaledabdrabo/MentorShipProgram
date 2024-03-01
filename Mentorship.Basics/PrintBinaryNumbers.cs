namespace Mentorship.Basics;
internal class PrintBinaryNumbers
{
    public static void PrintFirstNBinaryNumbers(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            queue<byte> myQueu = ToBinay(i);
            while (!myQueu.IsEmpty())
            {
                Write(myQueu.DeQueue());
            }
            WriteLine();
        }
    }

    public static queue<byte> ToBinay(int number)
    {
        queue<byte> myQueu = new();
        while (number > 0)
        {
            myQueu.EnQueue((byte)(number %2));
            number /= 2;
        }

            return myQueu;
    }
}