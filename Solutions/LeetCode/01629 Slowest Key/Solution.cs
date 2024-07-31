// Slowest Key

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SlowestKey
{
    public class Solution
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            var keyDurations = keysPressed
                .Select((key, index) => (
                    Key: key,
                    Duration: releaseTimes[index] - (index == 0 ? 0 : releaseTimes[index - 1])
                ));

            return keyDurations
                .MaxBy(kd => (kd.Duration, kd.Key))
                .Key;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Slowest Key");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}