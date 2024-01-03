// Number of Laser Beams in a Bank



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofLaserBeamsinaBank
{
    public class Solution
    {
        public static int NumberOfBeams(string[] bank)
        {
            var lasers = bank
                .Select(x => x.Count(x => x == '1'))
                .Where(x => x > 0);

            return lasers
                .Zip(lasers.Skip(1))
                .Aggregate(0, (acc, x) => acc + x.Item1 * x.Item2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumberOfBeams(new string[] {"011001","000000","010100","001000"}), 8),
                ResultTester.CheckResult<int>(Solution.NumberOfBeams(new string[] {"000","111","000"}), 0),
            };
            return results;
        }
    }
}