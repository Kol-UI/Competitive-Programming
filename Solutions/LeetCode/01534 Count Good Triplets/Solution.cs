// Count Good Triplets
namespace CompetitiveProgramming.LeetCode.CountGoodTriplets;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;
        int n = arr.Length;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) <= a)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountGoodTriplets(new int[]{3,0,1,1,9,7}, 7, 2, 3), 4),
            ResultTester.CheckResult<int>(solution.CountGoodTriplets(new int[]{1,1,2,2,3}, 0, 0, 1), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Good Triplets");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}