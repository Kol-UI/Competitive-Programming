// Mean of Array After Removing Some Elements
namespace CompetitiveProgramming.LeetCode.MeanofArrayAfterRemovingSomeElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public double TrimMean(int[] arr)
    {
        Array.Sort(arr);
        int removedRange = arr.Length/20;
        int last = arr.Length - removedRange;
        double totalCount = arr.Length - (removedRange<<1);
        double sum = 0;

        for(int i=removedRange; i<last; i++)
        {
            sum += arr[i];
        }

        return sum/totalCount;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<double>(solution.TrimMean([1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3]), 2.00000),
            ResultTester.CheckResult<double>(solution.TrimMean([6,2,7,5,1,2,0,3,10,2,5,0,5,5,0,8,7,6,8,0]), 4.00000),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mean of Array After Removing Some Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}