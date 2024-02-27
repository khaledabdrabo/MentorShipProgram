namespace Mentorship.Basics;

public class LogicalOperators
{
    public static bool PlayerStatusCheck(int score,int lives)
    {
        if(score>100&&lives<=0)
        {
            return true;
        }
        return false;
    }
}


