// Out of Boundary Paths


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.OutofBoundaryPaths
{
    public class Solution
    {
        const int Modulo9m7 = 1_000_000_007;

        public static int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            var directions = new (int dr, int dc)[4] { (-1, 0), (0, 1), (1, 0), (0, -1) };

            var dp = new int[m,n];

            dp[startRow, startColumn] = 1;

            var wave = new HashSet<(int r, int c)> { (startRow, startColumn) };

            var paths = 0;

            for (var move = 0; move < maxMove; move++)
            {
                var nextWave = new HashSet<(int r, int c)>(wave.Count * 4);

                var nextDp = new int[m, n];

                foreach (var i in wave)
                {
                    foreach (var d in directions)
                    {
                        var (r, c) = (i.r + d.dr, i.c + d.dc);

                        if (r < 0 || r >= m || c < 0 || c >= n)
                        {
                            paths = (paths + dp[i.r, i.c]) % Modulo9m7;
                        }
                        else
                        {
                            nextDp[r, c] = (nextDp[r, c] + dp[i.r, i.c]) % Modulo9m7;

                            nextWave.Add((r, c));
                        }
                    }
                }

                (wave, dp) = (nextWave, nextDp);
            }

            return paths;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindPaths(2, 2, 2, 0, 0), 6),
                ResultTester.CheckResult<int>(Solution.FindPaths(1, 3, 3, 0, 1), 12),
            };
            return results;
        }
    }
}