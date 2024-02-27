using System.Collections;
using System.Collections.Generic;

namespace Mentorship.Basics;

internal class ForLoop
{
    public static void IterateThroughList( IEnumerable list)
    {
        foreach(var item in list)
        {
            Write($"{item} ");
        }
    }
}