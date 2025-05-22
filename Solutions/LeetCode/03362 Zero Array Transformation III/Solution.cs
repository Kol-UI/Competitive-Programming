// Zero Array Transformation III
namespace CompetitiveProgramming.LeetCode.ZeroArrayTransformationIII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxRemoval(int[] nums, int[][] queries)
    {
        int n = nums.Length;
        int[] arr = new int[n+1] ;
        Array.Sort(queries, (a, b) => a[0] - b[0]);
        
        int k = queries.Length;
        int j = 0;
        int prefix = 0;
        var hq = new PriorityQueue<int, int>( Comparer<int>.Create((a, b) => b.CompareTo(a)));

        for (int i = 0; i < n; i++)
        {
            prefix += arr[i];
            while( j < k && queries[j][0] == i)
            {
                hq.Enqueue( queries[j][1], queries[j][1]);
                j += 1;
            }
            while (prefix < nums[i] && hq.Count > 0 && hq.Peek() >= i)
            {
                prefix += 1;
                arr[hq.Dequeue() + 1] -= 1;
            }
            if (prefix < nums[i])
            {
                return -1;
            }
        }
        
        return hq.Count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Zero Array Transformation III");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}