// Number of Visible People in a Queue
namespace CompetitiveProgramming.LeetCode.NumberofVisiblePeopleinaQueue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] CanSeePersonsCount(int[] heights)
    {
        var stack = new Stack<int>();
        var seen = new int[heights.Length];
        for(int idx = 0; idx < heights.Length; idx++)
        {
            while(stack.Count > 0 && heights[stack.Peek()] <= heights[idx])
            {                
                seen[stack.Pop()]++;
            }
            if(stack.Count > 0)
            {
                seen[stack.Peek()]++;
            }
            stack.Push(idx);
        }
        return seen;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.CanSeePersonsCount([10,6,8,5,11,9]), [3,1,2,1,1,0]),
            ResultTester.CheckResult<int[]>(solution.CanSeePersonsCount([5,1,2,3,10]), [4,1,1,1,0])
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Visible People in a Queue");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}