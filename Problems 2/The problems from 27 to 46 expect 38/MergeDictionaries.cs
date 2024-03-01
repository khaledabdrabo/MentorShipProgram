using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class MergeDictionaries
    {
        public static Dictionary<TKey, TValue> MergeTwoDictionaries<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
        {
            Dictionary<TKey,TValue> merge = new Dictionary<TKey,TValue>(dict1);
            foreach (var word in dict2)
            {
                if (merge.ContainsKey(word.Key))
                {
                    merge[word.Key] = word.Value;
                }
                else
                {
                    merge.Add(word.Key, word.Value);
                }
            }
            return merge;
        }
    }
}
