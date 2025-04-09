// Minimum Operations to Make Array Values Equal to K
namespace CompetitiveProgramming.LeetCode.MinimumOperationtoMakeArrayValuesEqualtoK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        HashSet<int> st = new HashSet<int>();
        foreach (int x in nums)
        {
            if (x < k)
            {
                return -1;
            }
            else if (x > k)
            {
                st.Add(x);
            }
        }
        return st.Count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Array Values Equal to K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}