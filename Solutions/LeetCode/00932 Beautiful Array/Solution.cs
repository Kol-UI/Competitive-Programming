// Beautiful Array
namespace CompetitiveProgramming.LeetCode.BeautifulArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] BeautifulArray(int n)
    {
        var result = new List<int>();
        result.Add(1);

        while (result.Count < n)
        {
            var temp = new List<int>();

            foreach (int odd in result)
            {
                if (odd * 2 - 1 <= n)
                {
                    temp.Add(odd * 2 - 1);
                }
            }

            foreach (int even in result)
            {
                if (even * 2 <= n)
                {
                    temp.Add(even * 2);
                }
            }

            result = temp;
        }

        return result.ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.BeautifulArray(4), [1,3,2,4]),
            ResultTester.CheckResult<int[]>(solution.BeautifulArray(5), [1,5,3,2,4]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Beautiful Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}