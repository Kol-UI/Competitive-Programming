// Check If All 1's Are at Least Length K Places Away
namespace CompetitiveProgramming.LeetCode.CheckIfAll1sAreatLeastLengthKPlacesAway;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        int count = k;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                if(count < k)
                {
                    return false;
                }
                count = 0;
            }
            else
            {
                count++;
            }
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.KLengthApart(new int[]{1,0,0,0,1,0,0,1}, 2), true),
            ResultTester.CheckResult<bool>(solution.KLengthApart(new int[]{1,0,0,1,0,1}, 2), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check If All 1's Are at Least Length K Places Away");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}