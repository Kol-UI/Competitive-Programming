// Find N Unique Integers Sum up to Zero
namespace CompetitiveProgramming.LeetCode.FindNUniqueIntegersSumuptoZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] SumZero(int n)
    {
        int[] result = new int[n];

        int leftPointer = 0;
        int rightPointer = n - 1;
        int maxNumber = n / 2;

        while(leftPointer < rightPointer)
        {
            result[leftPointer] = maxNumber * (-1);
            result[rightPointer] = maxNumber;

            leftPointer++;
            rightPointer--;
            maxNumber--;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[] test = [-7,-1,1,3,4];
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.SumZero(3), new int[]{-1,0,1}),
            ResultTester.CheckResult<int[]>(solution.SumZero(1), new int[]{0}),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find N Unique Integers Sum up to Zero");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}