// Maximum Candies Allocated to K Children
namespace CompetitiveProgramming.LeetCode.MaximumCandiesAllocatedtoKChildren;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumCandies(int[] candies, long k)
    {
        int left = 1, right = candies.Max(), result = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            long childrenCount = 0;

            foreach (int candy in candies) childrenCount += candy / mid;

            if (childrenCount >= k)
            {
                result = mid;
                left = mid + 1;
            }
            else right = mid - 1;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaximumCandies(new int[]{5,8,6}, 3), 5),
            ResultTester.CheckResult<int>(solution.MaximumCandies(new int[]{2,5}, 11), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Candies Allocated to K Children");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}