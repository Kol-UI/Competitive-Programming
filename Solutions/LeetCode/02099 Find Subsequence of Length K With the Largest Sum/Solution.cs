// Find Subsequence of Length K With the Largest Sum
namespace CompetitiveProgramming.LeetCode.FindSubsequenceofLengthKWiththeLargestSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int[] MaxSubsequence(int[] nums, int k) 
    {
        List<int> list = new(nums);

        int n = nums.Length - k;
        for (int i = 0; i < n; i++) 
        {
            list.RemoveAt(list.IndexOf(list.Min()));
        }

        return list.ToArray();
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Find Subsequence of Length K With the Largest Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
	}
}