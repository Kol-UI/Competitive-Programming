// Movement of Robots
namespace CompetitiveProgramming.LeetCode.MovementofRobots;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumDistance(int[] nums, string s, int d)
    {
        var longNums = new long[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] %= 1000000007;

            if (s[i] == 'L') longNums[i] = nums[i] - d;
            else longNums[i] = nums[i] + d;
        }

        Array.Sort(longNums);

        long result = 0;
        long prefix = 0;
        for (int i = 0; i < longNums.Length; i++)
        {
            result += i * longNums[i] - prefix;
            result %= 1000000007;
            
            prefix += longNums[i];
            prefix %= 1000000007;
        }

        return (int)result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[] nums1 = {-2, 0, 2};
        string s1 = "RLL";
        int d1 = 3;
        int[] nums2 = {1, 0};
        string s2 = "RL";
        int d2 = 2;
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SumDistance(nums1, s1, d1), 8),
            ResultTester.CheckResult<int>(solution.SumDistance(nums2, s2, d2), 5)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Movement of Robots");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}