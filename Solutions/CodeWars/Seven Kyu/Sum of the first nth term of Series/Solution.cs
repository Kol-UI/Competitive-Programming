// Sum of the first nth term of Series

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.SumofthefirstnthtermofSeries
{
    public class NthSeries
    {
        public static string SeriesSum(int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1/((double)(3 * i) - 2);
            }
            return String.Format("{0:0.00}", result);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(NthSeries.SeriesSum(1), "1,00"),
                ResultTester.CheckResult<string>(NthSeries.SeriesSum(2), "1,25"),
                ResultTester.CheckResult<string>(NthSeries.SeriesSum(5), "1,57"),
                ResultTester.CheckResult<string>(NthSeries.SeriesSum(0), "0,00"),
                ResultTester.CheckResult<string>(NthSeries.SeriesSum(9), "1,77"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of the first nth term of Series");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}