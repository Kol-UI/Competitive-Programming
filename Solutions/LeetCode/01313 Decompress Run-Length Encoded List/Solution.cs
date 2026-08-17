// Decompress Run-Length Encoded List
namespace CompetitiveProgramming.LeetCode.DecompressRunLengthEncodedList;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] DecompressRLElist(int[] nums)
      => nums
          .Chunk(2)
          .SelectMany(x => Enumerable.Repeat(x[1], x[0]))
          .ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.DecompressRLElist([1,2,3,4]), [2,4,4,4]),
            ResultTester.CheckResult<int[]>(solution.DecompressRLElist([1,1,2,3]), [1,3,3]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Decompress Run-Length Encoded List");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}