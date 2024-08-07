// Optimal Partition of String
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.OptimalPartitionofString
{
    public class Solution
    {
        /*
            Given a string s, partition the string into one or more substrings such that the characters in each substring are unique. That is, no letter appears in a single substring more than once.
            Return the minimum number of substrings in such a partition.
            Note that each character should belong to exactly one substring in a partition.

            Example 1:

            Input: s = "abacaba"
            Output: 4
            Explanation:
            Two possible partitions are ("a","ba","cab","a") and ("ab","a","ca","ba").
            It can be shown that 4 is the minimum number of substrings needed.
            
            Example 2:

            Input: s = "ssssss"
            Output: 6
            Explanation:
            The only valid partition is ("s","s","s","s","s","s").
        */

        // List Solution
        
        public static int PartitionString(string s)
        {
            var list = new List<char>();
            int result = 1;
            foreach(var c in s)
            {
                if(list.Contains(c))
                {
                    list.Clear();
                    list.Add(c);
                    result++;
                }
                else
                {
                    list.Add(c);
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int Case1Result2405 = Solution.PartitionString("abacaba");

            // Case 2
            int Case2Result2405 = Solution.PartitionString("ssssss");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1Result2405, 4),
                ResultTester.CheckResult<int>(Case2Result2405, 6)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Optimal Partition of String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}