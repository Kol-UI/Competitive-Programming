// Count Integers Appearing in a Single Block
namespace CompetitiveProgramming.LeetCode.CountIntegersAppearinginaSingleBlock;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountSpecialIntegers(int[] nums)
    {
        var result = new Dictionary<int, bool>();
        result.Add(nums[0], true);
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1]) 
            {
                if(!result.ContainsKey(nums[i])) result.Add(nums[i], true);
                else result[nums[i]] = false;
            }
        }
        return result.Count(x => x.Value);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountSpecialIntegers([1,2,2,1]), 1),
            ResultTester.CheckResult<int>(solution.CountSpecialIntegers([3,3,1,2,2,1]), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Integers Appearing in a Single Block");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}