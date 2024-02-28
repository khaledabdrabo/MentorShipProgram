using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class ForLoop
    {
       public static void IterateThroughList(List<string> list)
        {
            foreach (string item in list)
            {
                PerformAction(item);
            }

        }

        public  static void PerformAction(string item)
        {
            Console.WriteLine($"The action on item: {item}");

        }
    
    }

}
