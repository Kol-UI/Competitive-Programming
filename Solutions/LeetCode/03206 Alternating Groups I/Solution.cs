// Alternating Groups I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AlternatingGroupsI
{
    public class Solution
    {
        public int NumberOfAlternatingGroups(int[] colors)
        {
            int numberOfColors = colors.Length;
            int alternatingGroupCount = 0;

            for (int i = 0; i < numberOfColors; i++)
            {
                int currentColor = colors[i];
                int nextColor = colors[(i + 1) % numberOfColors];
                int previousColor = colors[(i - 1 + numberOfColors) % numberOfColors];

                if (nextColor != currentColor && previousColor != currentColor)
                {
                    alternatingGroupCount++;
                }
            }

            return alternatingGroupCount;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Alternating Groups I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}