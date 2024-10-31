// Minimum Total Distance Traveled

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTotalDistanceTraveled
{
    public class Solution
    {
        public long MinimumTotalDistance(IList<int> robot, int[][] factory)
        {

            var sortedRobots = robot.OrderBy(r => r).ToArray();
            Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));

            int n = sortedRobots.Length;
            int m = factory.Length;
            long inf = (1L << 53) - 1;
            
            long[,] dp = new long[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                dp[i, 0] = inf;  
            }

            for (int j = 1; j <= m; j++)
            {  
                for (int i = 1; i <= n; i++)
                { 
            
                    dp[i, j] = dp[i, j - 1];

                    long totalDistance = 0;
                    for (int k = 1; k <= Math.Min(i, factory[j - 1][1]); k++)
                    {
                        totalDistance += Math.Abs(sortedRobots[i - k] - factory[j - 1][0]);

                        if (dp[i - k, j - 1] != inf)
                        {
                            dp[i, j] = Math.Min(dp[i, j], dp[i - k, j - 1] + totalDistance);
                        }
                    }
                }
            }

            return dp[n, m] == inf ? 0 : dp[n, m];
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Total Distance Traveled");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}