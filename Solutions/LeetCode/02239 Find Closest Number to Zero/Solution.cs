// Find Closest Number to Zero
namespace CompetitiveProgramming.LeetCode.FindClosestNumbertoZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int number = nums[0];
        int minDif = -1;

        if (nums[0] < 0)
        {
            minDif = nums[0] * -1;
        }
        else
        {
            minDif = nums[0];
        }

        for (int i = 1; i < nums.Length; i++)
        {
            int dif = 0;
            if (nums[i] < 0)
            {
                dif = nums[i] * -1;
            }
            else
            {
                dif = nums[i];
            }

            if (dif < minDif)
            {
                minDif = dif;
                number = nums[i];
            }
            else if (dif == minDif)
            {
                if (nums[i] > number)
                {
                    minDif = dif;
                    number = nums[i];
                }
            }
            ;
        }

        return number;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.FindClosestNumber([-4,-2,1,4,8]), 1),
            ResultTester.CheckResult<int>(solution.FindClosestNumber([2,-1,1]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Closest Number to Zero");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}