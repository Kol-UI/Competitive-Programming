// Smallest Index With Digit Sum Equal to Index
namespace CompetitiveProgramming.LeetCode.SmallestIndexWithDigitSumEqualtoIndex;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestIndex(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            if(digits(nums[i]) == i)
            {
                return i;
            }
        }
        return -1;
        
    }
    public int digits(int a)
    {
        int count = 0;
        while(a > 0)
        {
            count = count + a % 10;
            a = a / 10;
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
            ResultTester.CheckResult<int>(solution.SmallestIndex(new int[]{1,3,2}), 2),
            ResultTester.CheckResult<int>(solution.SmallestIndex(new int[]{1,10,11}), 1),
            ResultTester.CheckResult<int>(solution.SmallestIndex(new int[]{1,2,3}), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Index With Digit Sum Equal to Index");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}