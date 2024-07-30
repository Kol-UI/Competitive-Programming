// Minimum Deletions to Make String Balanced

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumDeletionstoMakeStringBalanced
{
    public class Solution
    {
        public int MinimumDeletions(string s)
        {
            int length = s.Length;
            int[] leftDeletions = new int[length];
            int[] rightDeletions = new int[length];

            leftDeletions[0] = s[0] == 'b' ? 1 : 0;
            rightDeletions[length - 1] = s[length - 1] == 'a' ? 1 : 0;

            for (int i = 1, j = length - 2; i < length; i++, j--)
            {
                leftDeletions[i] = leftDeletions[i - 1] + (s[i] == 'b' ? 1 : 0);
                rightDeletions[j] = rightDeletions[j + 1] + (s[j] == 'a' ? 1 : 0);
            }

            int minDeletions = Math.Min(leftDeletions[length - 1], rightDeletions[0]);

            for (int i = 0; i < length - 1; i++)
            {
                minDeletions = Math.Min(minDeletions, leftDeletions[i] + rightDeletions[i + 1]);
            }

            return minDeletions;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Deletions to Make String Balanced");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}