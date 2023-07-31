// Top K Frequent Words

/*
Given an array of strings words and an integer k, return the k most frequent strings.

Return the answer sorted by the frequency from highest to lowest. Sort the words with the same frequency by their lexicographical order.

 

Example 1:

Input: words = ["i","love","leetcode","i","love","coding"], k = 2
Output: ["i","love"]
Explanation: "i" and "love" are the two most frequent words.
Note that "i" comes before "love" due to a lower alphabetical order.


Example 2:

Input: words = ["the","day","is","sunny","the","the","the","sunny","is","is"], k = 4
Output: ["the","is","sunny","day"]
Explanation: "the", "is", "sunny" and "day" are the four most frequent words, with the number of occurrence being 4, 3, 2 and 1 respectively.
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TopKFrequentWords
{
    public class Solution
    {
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            return words.GroupBy(word => word).OrderByDescending(freq => freq.Count()).ThenBy(freq => freq.Key).Take(k).Select(freq => freq.Key).ToList();
        }

    }

    public class Test
    {
        public static bool[] TestTopKFrequentWords()
        {
            string[] words1 = {"i","love","leetcode","i","love","coding"};
            int k1 = 2;
            string[] words2 = {"the","day","is","sunny","the","the","the","sunny","is","is"};
            int k2 = 4;
            IList<string> result1 = Solution.TopKFrequent(words1, k1);
            IList<string> result2 = Solution.TopKFrequent(words2, k2);
            IList<string> expected1 = new List<string> { "i", "love" };
            IList<string> expected2 = new List<string> { "the", "is", "sunny", "day" };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(result1, expected1),
                ResultTester.CheckResult<IList<string>>(result2, expected2)
            };
            return results;
        }
    }
}