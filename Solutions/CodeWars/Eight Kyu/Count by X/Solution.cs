// Count by X

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.CountbyX
{
    public static class Kata
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                z[i] = x * (i + 1);
            }
            
            return z;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Kata.CountBy(1,5), new int[] {1,2,3,4,5}),
                ResultTester.CheckResult<int[]>(Kata.CountBy(2,5), new int[] {2,4,6,8,10}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count by X");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}