// Jump Game IX
namespace CompetitiveProgramming.LeetCode.JumpGameIX;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MaxValue(int[] nums)
    {
        int[] ans = new int[nums.Length];
        int greatest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > greatest)
            {
                greatest = nums[i];
            }
            ans[i] = greatest;
        }

        List<int[]> smallestAt = new List<int[]>();
        int smallest = int.MaxValue;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] < smallest)
            {
                smallest = nums[i];
                smallestAt.Add(new int[2] { smallest, i });
            }
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int left = 0;
            int right = smallestAt.Count;
            while (right > left)
            {
                int middle = (right - left) / 2 + left;
                if (smallestAt[middle][0] < ans[i])
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            if (left < smallestAt.Count && ans[smallestAt[left][1]] > ans[i])
            {
                ans[i] = ans[smallestAt[left][1]];
            }
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.MaxValue([2,1,3]), [2,2,3]),
            ResultTester.CheckResult<int[]>(solution.MaxValue([2,3,1]), [3,3,3])
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jump Game IX");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}