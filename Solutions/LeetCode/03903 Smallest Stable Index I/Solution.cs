// Smallest Stable Index I
namespace CompetitiveProgramming.LeetCode.SmallestStableIndexI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FirstStableIndex(int[] nums, int k)
    {
        int max = nums[0];
        int n = nums.Length;
        for(int i = 0; i < n; i++)
        {
            max = max > nums[i] ? max : nums[i];
            int min = nums[i];
            
            for(int j = i + 1; j < n; j++)
            {
                min = min < nums[j] ? min : nums[j];
            }    
            if(max - min <= k) return i;
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.FirstStableIndex([5,0,1,4], 3), 3),
            ResultTester.CheckResult<int>(solution.FirstStableIndex([3,2,1], 1), -1),
            ResultTester.CheckResult<int>(solution.FirstStableIndex([0], 0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Stable Index I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}