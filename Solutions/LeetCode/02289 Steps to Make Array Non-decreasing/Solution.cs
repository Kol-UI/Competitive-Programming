// Steps to Make Array Non-decreasing
namespace CompetitiveProgramming.LeetCode.StepstoMakeArrayNondecreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TotalSteps(int[] nums)
    {
        int maxSteps = 0;
        int totalCount = nums.Length;
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(Tuple.Create(nums[totalCount - 1], 0));

        for (int i = totalCount - 2; i >= 0; i--)
        {
            int currentSteps = 0;
            while (stack.Count > 0 && nums[i] > stack.Peek().Item1)
            {
                currentSteps = Math.Max(currentSteps + 1, stack.Pop().Item2);
            }

            stack.Push(Tuple.Create(nums[i], currentSteps));
            maxSteps = Math.Max(maxSteps, currentSteps);
        }

        return maxSteps;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Steps to Make Array Non-decreasing");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}