// Smallest Index With Equal Value
namespace CompetitiveProgramming.LeetCode.SmallestIndexWithEqualValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestEqual(int[] nums)
    {
        int smallest = -1;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i % 10 == nums[i])
            {
                smallest = i;
                break;
            }
        }

        return smallest;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SmallestEqual([0,1,2]), 0),
            ResultTester.CheckResult<int>(solution.SmallestEqual([4,3,2,1]), 2),
            ResultTester.CheckResult<int>(solution.SmallestEqual([1,2,3,4,5,6,7,8,9,0]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Index With Equal Value");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}