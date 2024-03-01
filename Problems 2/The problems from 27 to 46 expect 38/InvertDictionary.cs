using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class InvertDictionary
    {
        public static Dictionary<TValue,TKey> InvertedDictionry<TKey, TValue>(Dictionary<TKey,TValue> originalDictionary) 
        {
           // Invert the key-value pairs of a dictionary
           Dictionary<TValue,TKey> invertedDictionary = new Dictionary<TValue, TKey>();

            foreach (var KeyValue in originalDictionary )
            {
                invertedDictionary[KeyValue.Value] = KeyValue.Key;
            }
            return invertedDictionary;
        }  
    }
}
