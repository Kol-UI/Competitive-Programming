// Positions of Large Groups

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PositionsofLargeGroups
{
    public class Solution
    {
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            var result = new List<IList<int>>();
            int i = 0;

            while (i < s.Length)
            {
                int start = i;
                while (i < s.Length && s[i] == s[start])
                {
                    i++;
                }
                if (i - start >= 3)
                {
                    result.Add(new List<int> { start, i - 1 });
                }
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Positions of Large Groups");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}