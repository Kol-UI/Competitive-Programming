// Count Pairs Of Similar Strings


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountPairsOfSimilarStrings
{
    public class Solution
    {
        public static int SimilarPairs(string[] words) => words
            .GroupBy(word => string.Concat(word.Distinct().OrderBy(c => c)))
            .Sum(group => (group.Count() - 1) * group.Count() / 2);    
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SimilarPairs(new string[] {"aba","aabb","abcd","bac","aabc"}), 2),
                ResultTester.CheckResult<int>(Solution.SimilarPairs(new string[] {"aabb","ab","ba"}), 3),
            };
            return results;
        }
    }
}