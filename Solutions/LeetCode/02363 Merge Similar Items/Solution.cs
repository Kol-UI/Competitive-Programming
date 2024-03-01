// Merge Similar Items


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeSimilarItems
{
    public class Solution
    {
        public static IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            var counts = new SortedDictionary<int, int>();
            AddWeights(items1, counts);
            AddWeights(items2, counts);
            
            var result = new List<IList<int>>();

            foreach(var kvp in counts)
            {
                result.Add(new List<int>(){kvp.Key, kvp.Value});
            }

            return result;
        }

        private static void AddWeights(int[][] items1, SortedDictionary<int, int> counts)
        {
            foreach(var item in items1)
            {
                if(!counts.ContainsKey(item[0]))
                {
                    counts[item[0]] = 0;
                }
                
                counts[item[0]] += item[1];
            }
        }
    }
}