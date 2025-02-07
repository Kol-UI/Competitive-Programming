// Find the Number of Distinct Colors Among the Balls

namespace CompetitiveProgramming.CodeForces.FindtheNumberofDistinctColorsAmongtheBalls;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        var pairs = new Dictionary<int,int>();
        var color = new Dictionary<int,int>();
        int count = 0;
        int n = queries.Length;
        var result = new int[n];

        for(int i = 0; i < n; i++)
        {
            int cont = 0;
            if(!color.ContainsKey(queries[i][1]))
            {
                color.Add(queries[i][1], 1);
                count++;
            }
            else color[queries[i][1]]++;

            if(!pairs.ContainsKey(queries[i][0])) pairs.Add(queries[i][0], queries[i][1]);
            else
            {
                cont = pairs[queries[i][0]];
                pairs[queries[i][0]] = queries[i][1]; 
                if(color[cont] > 1) color[cont]--;
                else
                {
                    color.Remove(cont);
                    count--;
                }
            }
            result[i] = count;
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Number of Distinct Colors Among the Balls");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}