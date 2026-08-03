// Number of Unique XOR Triplets II
namespace CompetitiveProgramming.LeetCode.NumberofUniqueXORTripletsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int UniqueXorTriplets(int[] nums)
    {
        var set0 = new HashSet<int>(nums);
        var set1 = new HashSet<int>();
        foreach(var item in set0)
        {
            foreach (var item1 in set0)
            {
                set1.Add(item ^ item1);
            }
        }
        var set = new HashSet<int>();
        foreach (var item in set0)
        {
            foreach(var item1 in set1)
            {
                set.Add(item ^ item1);
            }
        }   
        var result = set.Count;
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
            ResultTester.CheckResult<int>(solution.UniqueXorTriplets([1,3]), 2),
            ResultTester.CheckResult<int>(solution.UniqueXorTriplets([6,7,8,9]), 4),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Unique XOR Triplets II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}