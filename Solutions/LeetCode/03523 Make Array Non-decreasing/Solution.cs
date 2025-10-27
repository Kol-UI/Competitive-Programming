// Make Array Non-decreasing
namespace CompetitiveProgramming.LeetCode.MakeArrayNondecreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumPossibleSize(int[] nums)
    {
        int n = nums.Length;
        Stack<int> st = new Stack<int>();
        foreach (var num in nums)
        {
            if (st.Count == 0 || st.Peek() <= num)
            {
                st.Push(num);
            }
        }
        return st.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaximumPossibleSize([4,2,5,3,5]), 3),
            ResultTester.CheckResult<int>(solution.MaximumPossibleSize([1,2,3]), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Array Non-decreasing");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}