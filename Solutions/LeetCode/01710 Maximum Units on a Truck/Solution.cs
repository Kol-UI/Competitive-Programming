// Maximum Units on a Truck
namespace CompetitiveProgramming.LeetCode.MaximumUnitsonaTruck;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a,b)=> b[1]-a[1]);

        int ans = 0;

        for(int i = 0;i<boxTypes.Length && truckSize>0;i++)
        {
            int temp = Math.Min(boxTypes[i][0], truckSize);
            truckSize -= temp;
            ans+=temp*boxTypes[i][1];
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaximumUnits([[1,3],[2,2],[3,1]], 4), 8),
            ResultTester.CheckResult<int>(solution.MaximumUnits([[5,10],[2,5],[4,7],[3,9]], 10), 91),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Units on a Truck");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}