using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace problems
{
    public class LogicalOperators
    {
        public static bool PlayerStatusCheck(int score, int lives)
        {
            bool IsGameOver = false;
            if (score>100 && lives<=0)
            {
                IsGameOver = true;
            }
            return IsGameOver;
        }
        
    }
}
