// Find the Losers of the Circular Game


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheLosersoftheCircularGame
{
    public class Solution
    {
        public static int[] CircularGameLosers(int n, int k)
        {
            bool[] game = new bool[n];

            for (int i = 0, j = 0; !game[i]; i = (i + ++j * k) % n)
            {
                game[i] = true;
            }

            var losers = new List<int>();

            for (int i = 0; i < game.Length; i++)
            {
                if (!game[i])
                {
                    losers.Add(i + 1);
                }
            }

            return losers.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.CircularGameLosers(5, 2), new int[]{4, 5}),
                ResultTester.CheckResult<int[]>(Solution.CircularGameLosers(4, 4), new int[]{2, 3, 4}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2682");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}