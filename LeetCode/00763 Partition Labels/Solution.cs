// Partition Labels

/*
You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.

Note that the partition is done so that after concatenating all the parts in order, the resultant string should be s.

Return a list of integers representing the size of these parts.

 

Example 1:

Input: s = "ababcbacadefegdehijhklij"
Output: [9,7,8]
Explanation:
The partition is "ababcbaca", "defegde", "hijhklij".
This is a partition so that each letter appears in at most one part.
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.

Example 2:

Input: s = "eccbbbbdec"
Output: [10]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PartitionLabels
{
    public class Solution
    {
        public static IList<int> PartitionLabels(string s)
        {
            var list = new List<int>();
            var dict = new Dictionary<char, int>();
            int start = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                dict.Add(s[i], s.Count(x => x == s[i]) - 1);
                else dict[s[i]]--;

                if(dict[s[i]] == 0)
                dict.Remove(s[i]);

                if (dict.Count == 0)
                {
                    list.Add(i - start);
                    start = i;
                }
            }
            return list;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<int> expected1 = new List<int> { 9, 7, 8 };
            IList<int> expected2 = new List<int> { 10 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.PartitionLabels("ababcbacadefegdehijhklij"), expected1),
                ResultTester.CheckResult<IList<int>>(Solution.PartitionLabels("eccbbbbdec"), expected2),
            };
            return results;
        }
    }
}