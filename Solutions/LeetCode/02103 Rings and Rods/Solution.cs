// Rings and Rods

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RingsandRods
{
    public class Solution
    {
        public int CountPoints(string rings)
        {
            var rodColors = new Dictionary<int, HashSet<char>>();

            for (int i = 0; i < rings.Length; i += 2)
            {
                char color = rings[i];
                int rod = rings[i + 1] - '0';

                if (!rodColors.TryGetValue(rod, out var colors))
                {
                    colors = new HashSet<char>();
                    rodColors[rod] = colors;
                }
                colors.Add(color);
            }

            return rodColors.Values.Count(colors => colors.Count == 3);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rings and Rods");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}