// Defuse the Bomb

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DefusetheBomb
{
    public class Solution
    {
        public static int[] Decrypt(int[] code, int k)
        {
            var result = new int[code.Length];

            for (var i = 0; i < code.Length; i++)
            for (var j = k; j != 0; j -= Math.Sign(k))
                result[i] += code[(i + j + code.Length) % code.Length];

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.Decrypt(new int[]{5,7,1,4}, 3), new int[]{12,10,16,13}),
                ResultTester.CheckResult<int[]>(Solution.Decrypt(new int[]{1,2,3,4}, 0), new int[]{0,0,0,0}),
                ResultTester.CheckResult<int[]>(Solution.Decrypt(new int[]{2,4,9,3}, -2), new int[]{12,5,6,13}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Defuse the Bomb");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}