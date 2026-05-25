// Sort Even and Odd Indices Independently
namespace CompetitiveProgramming.LeetCode.SortEvenandOddIndicesIndependently;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] SortEvenOdd(int[] nums)
    {
        if (nums.Length < 3) return nums;

        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        int evenInd = 0;
        int oddInd = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0) even.Add(nums[i]);
            else odd.Add(nums[i]);
        }

        int[] oddArr = odd.OrderByDescending(num => num).ToArray(); ;
        int[] evenArr = even.OrderBy(num => num).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                nums[i] = evenArr[evenInd];
                evenInd++;
            }
            else
            {
                nums[i] = oddArr[oddInd];
                oddInd++;
            }
        }

        return nums;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.SortEvenOdd([4,1,2,3]), [2,3,4,1]),
            ResultTester.CheckResult<int[]>(solution.SortEvenOdd([2,1]), [2,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort Even and Odd Indices Independently");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}