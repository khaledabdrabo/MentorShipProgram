using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class ArrayOperations
    {
        public static double  CalculateAverageScore(int[] playerScores)
        {
            double totalScore = sumOfSocres(playerScores);
            double averageScore = totalScore / playerScores.Length;
            return averageScore;

        }
        public static double sumOfSocres(int[] playerScores)
        {
            double total = 0;
            foreach (double score in playerScores)
            {
                total += score;

            }
            return total;
        }
    }
}
