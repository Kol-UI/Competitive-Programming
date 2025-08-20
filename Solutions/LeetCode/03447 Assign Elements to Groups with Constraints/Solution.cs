// Assign Elements to Groups with Constraints
namespace CompetitiveProgramming.LeetCode.AssignElementstoGroupswithConstraints;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] AssignElements(int[] groups, int[] elements)
    {
        int[] dp = Enumerable.Repeat(int.MaxValue, 100000+1).ToArray();
        int lenE = elements.Length;
        HashSet<int> visited = new();
        for(int i = 0; i < lenE; i++)
        {
            int div = elements[i];
            if(visited.Contains(div))
                continue;

            visited.Add(div);
            int n = div;
            int offset = 1;
            while(n*offset <= 100000)
            {
                dp[n*offset] = Math.Min(dp[n*offset], i);
                offset++;
            }
        } 
        
        int[] res = new int[groups.Length];
        for(int i = 0; i < groups.Length; i++)
        {
            res[i] = dp[groups[i]] == int.MaxValue ? -1 : dp[groups[i]];
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Assign Elements to Groups with Constraints");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}