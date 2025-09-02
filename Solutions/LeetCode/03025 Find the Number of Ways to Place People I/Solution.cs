// Find the Number of Ways to Place People I
namespace CompetitiveProgramming.LeetCode.FindtheNumberofWaystoPlacePeopleI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfPairs(int[][] points)
    {
        int n = points.Length, res = 0;

        Array.Sort(points, (a, b) => 
            a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0])
        );

        for (int i = 0; i < n; i++)
        {
            int top = points[i][1];
            int bot = int.MinValue;

            for (int j = i + 1; j < n; j++)
            {
                int y = points[j][1];
                if (bot < y && y <= top)
                {
                    res++;
                    bot = y;
                    if (top == bot) break;
                }
            }
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Number of Ways to Place People I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}