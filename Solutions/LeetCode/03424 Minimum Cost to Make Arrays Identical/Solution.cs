// Minimum Cost to Make Arrays Identical
namespace CompetitiveProgramming.LeetCode.MinimumCosttoMakeArraysIdentical;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinCost(int[] arr, int[] brr, long k)
    {
        var result0 = MinCostWithoutSplit(arr, brr);
        var result1 = k + MinCostWithSplit(arr, brr);
        var result = Math.Min(result0, result1);
        return result;
    }
    private long MinCostWithSplit(int[] arr, int[] brr)
    {
        var list = CreateAuxList(arr, brr);
        var result = 0L;
        var stack = new Stack<(int val, bool isFromArr)>();
        for (int i = 0; i < list.Count; i++)
        {
            if (stack.Count == 0)
            {
                stack.Push(list[i]);
            }
            else
            {
                if (list[i].isFromArr == stack.Peek().isFromArr)
                {
                    stack.Push(list[i]);
                }
                else
                {
                    var item = stack.Pop();
                    result += Math.Abs(item.val - list[i].val);
                }
            }
        }
        return result;
    }

    private List<(int val, bool isFromArr)> CreateAuxList(int[] arr, int[] brr)
    {
        var result = new List<(int val, bool isFromArr)>();
        for (int i = 0; i < arr.Length; i++)
        {
            result.Add((arr[i], true));
            result.Add((brr[i], false));
        }
        result = result.OrderBy(p => p.val).ToList();
        return result;
    }

    private long MinCostWithoutSplit(int[] arr, int[] brr)
    {
        var result = 0L;
        for (int i = 0; i < arr.Length; i++)
        {
            result += Math.Abs(arr[i] - brr[i]);
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MinCost([-7,9,5], [7,-2,-5], 2), 13),
            ResultTester.CheckResult<long>(solution.MinCost([2,1], [2,1], 0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost to Make Arrays Identical");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}