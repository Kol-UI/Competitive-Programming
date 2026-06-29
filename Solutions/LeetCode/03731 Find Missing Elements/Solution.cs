// Find Missing Elements
namespace CompetitiveProgramming.LeetCode.FindMissingElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> FindMissingElements(int[] nums)
    {
        int min = nums.Min();
        int max = nums.Max();
        List<int> missing = new List<int>();
        for (int i = min; i <= max; i++)
        {
            if (!nums.Contains(i))
            {
                missing.Add(i);
            }    
        }
        return missing;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.FindMissingElements([1,4,2,5]), [3]),
            ResultTester.CheckResult<IList<int>>(solution.FindMissingElements([7,8,6,9]), []),
            ResultTester.CheckResult<IList<int>>(solution.FindMissingElements([5,1]), [2,3,4]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Missing Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}