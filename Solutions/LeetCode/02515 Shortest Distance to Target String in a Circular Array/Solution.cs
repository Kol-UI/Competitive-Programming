// Shortest Distance to Target String in a Circular Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestDistancetoTargetStringinaCircularArray
{
    public class Solution
    {
        public static int ClosetTarget(string[] words, string target, int startIndex)
        {
            int result = -1;
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i] != target) continue;
                int tmp = Math.Abs(startIndex - i);
                int current = Math.Min(tmp, words.Length - tmp);
                result = result == (-1)? current : Math.Min(result, current);
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
                ResultTester.CheckResult<int>(Solution.ClosetTarget(new string[] {"hello","i","am","leetcode","hello"}, "hello", 1), 1),
                ResultTester.CheckResult<int>(Solution.ClosetTarget(new string[] {"a","b","leetcode"}, "leetcode", 0), 1),
                ResultTester.CheckResult<int>(Solution.ClosetTarget(new string[] {"i","eat","leetcode"}, "ate", 0), -1),
            };
            return results;
        }
    }
}