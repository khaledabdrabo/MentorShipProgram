using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class FindCommonElementsInDictionaries
    {
        public static Dictionary<TKey, TValue> FindCommonElements<TKey,TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
        {
           Dictionary<TKey,TValue> commonElements = new Dictionary<TKey, TValue>();
            foreach (var word in dict1)
            {
                if (dict2.ContainsKey(word.Key) && dict2[word.Key].Equals(word.Value))
                {
                    commonElements.Add(word.Key, word.Value);
                }
            }
            return commonElements;
        }
    }
}
