using System.Collections;

namespace Mentorship.Basics;

internal class ArrayOperations
{
    public static void CalculateAverageScore(IEnumerable<int> playerScores)
    {
        int total = sumOfScores(playerScores);
        double averageScore = (double) total/ playerScores.Count();
        WriteLine($"averageScore = {averageScore}");
    }
    private static int sumOfScores(IEnumerable<int> playerScores)
    {
        int sum = 0;
        foreach(var item in playerScores)
        {
            sum += item;
        }
        return sum;
    }
}