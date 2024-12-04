// Make String a Subsequence Using Cyclic Increments

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MakeStringaSubsequenceUsingCyclicIncrements
{
    public class Solution
    {
        public bool CanMakeSubsequence(string str1, string str2)
        {
            int left = 0;
            int right = 0;

            while (left < str1.Length && right < str2.Length)
            {
                char incrementedChar = str1[left] == 'z' ? 'a' : (char)(str1[left] + 1);

                if (str1[left] == str2[right] || incrementedChar == str2[right])
                {
                    right++;
                }

                left++;
            }

            return right == str2.Length;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make String a Subsequence Using Cyclic Increments");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}