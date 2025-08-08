// Earliest Finish Time for Land and Water Rides II
namespace CompetitiveProgramming.LeetCode.EarliestFinishTimeforLandandWaterRidesII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        int landFirstEnd = int.MaxValue;
        int waterFirstEnd = int.MaxValue;
        for (int i = 0; i < landStartTime.Length; i++)
        {
            if (landStartTime[i] + landDuration[i] < landFirstEnd)
            {
                landFirstEnd = landStartTime[i] + landDuration[i];
            }
        }
        int result = int.MaxValue;
        for (int i = 0; i < waterStartTime.Length; i++)
        {
            if (waterStartTime[i] + waterDuration[i] < waterFirstEnd)
            {
                waterFirstEnd = waterStartTime[i] + waterDuration[i];
            }
            int end = Math.Max(landFirstEnd, waterStartTime[i]) + waterDuration[i];
            if (end < result)
            {
                result = end;
            }
        }
        for (int i = 0; i < landStartTime.Length; i++)
        {
            int end = Math.Max(waterFirstEnd, landStartTime[i]) + landDuration[i];
            if (end < result)
            {
                result = end;
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
        StyleHelper.Title("Intercepted Inputs");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}