// Maximum Repeating Substring

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumRepeatingSubstring
{
    public class Solution
    {
        public int MaxRepeating(string sequence, string word)
        {
            int maxRepeats = 0;
            string testSequence = word;

            while (sequence.Contains(testSequence))
            {
                maxRepeats++;
                testSequence += word;
            }

            return maxRepeats;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Repeating Substring");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}