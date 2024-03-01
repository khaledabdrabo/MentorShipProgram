using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class RemoveKeyValuePair
    {
       public static Dictionary<TKey,TValue> RemoveKeyValue<TKey, TValue>(Dictionary<TKey,TValue> originalDictionary,TKey keyToRemove)
        {
            // Remove a specific key-value pair from a dictionary
            if (originalDictionary.ContainsKey(keyToRemove))
                originalDictionary.Remove(keyToRemove);
             return originalDictionary;
        }

    }
}
