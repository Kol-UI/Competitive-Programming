// Find Maximum Number of String Pairs

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindMaximumNumberofStringPairs
{
    public class Solution
    {
        public static int MaximumNumberOfStringPairs(string[] words)
        {
            HashSet<string> map = new HashSet<string>();
            int result = 0;
            foreach(var word in words)
            {
                if(map.Contains("" + word[1] + word[0]))
                {
                    result++;
                    map.Remove("" + word[1] + word[0]);
                }
                else
                {
                    map.Add(word);
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximumNumberOfStringPairs(new string[]{"cd","ac","dc","ca","zz"}), 2),
                ResultTester.CheckResult<int>(Solution.MaximumNumberOfStringPairs(new string[]{"ab","ba","cc"}), 1),
                ResultTester.CheckResult<int>(Solution.MaximumNumberOfStringPairs(new string[]{"aa","ab"}), 0),
            };
            return results;
        }
    }
}