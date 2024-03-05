// Minimum Length of String After Deleting Similar Ends


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumLengthofStringAfterDeletingSimilarEnds
{
    public class Solution
    {
        public static int MinimumLength(string s)
        {
            int n = s.Length;
            if(n == 1)
                return 1;
            int start = 0, end = n - 1;
            while(start < end) {
                char prev = s[start];
                if(s[start] != s[end])
                    break;
                while(start <= end && s[start] == prev)
                    start++;
                while(end >= start && s[end] == prev)
                    end--;
            }

            if(start > end)
                return 0;
            return (end - start + 1);
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumLength("ca"), 2),
                ResultTester.CheckResult<int>(Solution.MinimumLength("cabaabac"), 0),
                ResultTester.CheckResult<int>(Solution.MinimumLength("aabccabba"), 3),
            };
            return results;
        }
    }
}