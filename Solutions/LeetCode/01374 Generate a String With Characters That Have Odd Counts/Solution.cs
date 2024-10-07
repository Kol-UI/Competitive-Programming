// Generate a String With Characters That Have Odd Counts

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GenerateaStringWithCharactersThatHaveOddCounts
{
    public class Solution
    {
        public string GenerateTheString(int n)
        {
            return n % 2 == 0 ? new string('a', n - 1) + 'b' : new string('a', n);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Generate a String With Characters That Have Odd Counts");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}