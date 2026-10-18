// Construct Target Array With Multiple Sums
namespace CompetitiveProgramming.LeetCode.ConstructTargetArrayWithMultipleSums;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsPossible(int[] target)
    {
        if (target.Length is 1) return target[0] is 1;

        long sum = target.Sum(x => (long) x);
        PriorityQueue<long, long> priorityQueue = new(target.Select(x => ((long) x, (long) -x)));

        while (priorityQueue.Peek() is not 1)
        {
            long value = priorityQueue.Dequeue();
            if (sum - value is 1) return true;

            long valueBeforeOperation = value % (sum - value);
            sum = sum - value + valueBeforeOperation;
            if (valueBeforeOperation is 0 || value == valueBeforeOperation) return false;

            priorityQueue.Enqueue(valueBeforeOperation, -valueBeforeOperation);
        }

        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsPossible([9,3,5]), true),
            ResultTester.CheckResult<bool>(solution.IsPossible([1,1,1,2]), false),
            ResultTester.CheckResult<bool>(solution.IsPossible([8,5]), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct Target Array With Multiple Sums");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}