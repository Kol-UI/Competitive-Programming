// Check If Two String Arrays are Equivalent



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckIfTwoStringArraysareEquivalent
{
    public class Solution
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string ans1 = "";
            string ans2 = "";

            for(int i = 0;i < word1.Length; i++)
            {
                ans1 += word1[i];
            }

            for(int i = 0;i < word2.Length; i++)
            {
                ans2 += word2[i];
            }

            if(string.Equals(ans1, ans2))
            {
                return true;
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] word1_1 = {"ab", "c"};
            string[] word2_1 = {"a", "bc"};

            string[] word1_2 = {"a", "cb"};
            string[] word2_2 = {"ab", "c"};

            string[] word1_3 = {"abc", "d", "defg"};
            string[] word2_3 = {"abcddefg"};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.ArrayStringsAreEqual(word1_1, word2_1), true),
                ResultTester.CheckResult<bool>(Solution.ArrayStringsAreEqual(word1_2, word2_2), false),
                ResultTester.CheckResult<bool>(Solution.ArrayStringsAreEqual(word1_3, word2_3), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1662");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}