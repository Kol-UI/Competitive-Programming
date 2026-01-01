// Minimum Score Triangulation of Polygon
namespace CompetitiveProgramming.LeetCode.MinimumScoreTriangulationofPolygon;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int MinScoreTriangulation(int[] values) {
        int[,] map = new int[values.Length, values.Length];
        int ans = helper(values, 1, values.Length-1, map);

        return ans;
    }
    private int helper(int[] arr, int i, int j,int[,] map){
        if(i >= j) return 0;
        int maxn = int.MaxValue;
        if(map[i,j] != 0) return map[i,j];
        for(int k =i;k<j;k++){
            int temp = helper(arr, i, k, map) + helper(arr,k+1,j, map) + arr[i-1] * arr[k] * arr[j];

            if(temp < maxn){
                maxn = temp;
            }
        }
        map[i,j] = maxn;
        return maxn;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Score Triangulation of Polygon");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}