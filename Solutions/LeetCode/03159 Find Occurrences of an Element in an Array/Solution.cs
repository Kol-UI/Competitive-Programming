// Find Occurrences of an Element in an Array
namespace CompetitiveProgramming.LeetCode.FindOccurrencesofanElementinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        int count = nums.Count(n => n == x);
        if(count == 0) return Enumerable.Repeat(-1, queries.Length).ToArray();
        
        int[] res=new int[queries.Length];
        List<int> pos = new();
        for(int i = 0;i < nums.Length; i++)
        {
            if(nums[i] == x) pos.Add(i);
        }
        for(int i = 0; i < queries.Length; i++)
        {
            res[i] = queries[i] > count ? -1 : res[i] = pos.ElementAt(queries[i]-1);            
        }
        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Occurrences of an Element in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}