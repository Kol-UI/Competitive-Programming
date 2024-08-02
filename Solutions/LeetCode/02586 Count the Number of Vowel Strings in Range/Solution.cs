// Count the Number of Vowel Strings in Range


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CounttheNumberofVowelStringsinRange
{
    public class Solution
    {
        public static int VowelStrings(string[] words, int left, int right)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            while (left <= right)
            {
                if (vowels.Contains(words[left][0]) && vowels.Contains(words[left][^1]))
                {
                    count++;
                }
                left++;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.VowelStrings(new string[]{"are","amy","u"}, 0, 2), 2),
                ResultTester.CheckResult<int>(Solution.VowelStrings(new string[]{"hey","aeo","mu","ooo","artro"}, 1, 4), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2586");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}