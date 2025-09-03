// Find the Number of Ways to Place People II
namespace CompetitiveProgramming.LeetCode.FindtheNumberofWaystoPlacePeopleII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfPairs(int[][] points)
    {
        Array.Sort(points, (a, b) => {
            var result = a[0].CompareTo(b[0]); 
            if(result == 0){
                return b[1].CompareTo(a[1]);
            }
            return result;
        }); 
        var result = 0; 
        for(int i = 0; i < points.Length; i++)
        {
            var x = points[i][0];
            var y = points[i][1];
            var minY = int.MinValue;
            for(int j = i + 1; j < points.Length; j++)
            {
                if(points[j][1] > y || points[j][1] <= minY)
                {
                    continue;
                }
                result += 1;
                minY = points[j][1];
            }
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Number of Ways to Place People II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}