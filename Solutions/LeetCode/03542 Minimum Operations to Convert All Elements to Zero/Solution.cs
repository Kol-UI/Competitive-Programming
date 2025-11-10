// Minimum Operations to Convert All Elements to Zero
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoConvertAllElementstoZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var stack = new Stack<int>();
        stack.Push(0);
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while(stack.Peek() > nums[i])
            {
                stack.Pop();
            }
            if (stack.Peek() == nums[i])
            {
                continue;
            }
            if (stack.Peek() < nums[i])
            {
                stack.Push(nums[i]);
                result++;
            }
        }
        return result;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Convert All Elements to Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}