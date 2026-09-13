// Count Pairs That Form a Complete Day I
namespace CompetitiveProgramming.LeetCode.CountPairsThatFormaCompleteDayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountCompleteDayPairs(int[] hours)
    {
        if(hours.Length == 1) return 0;
        
        var countDays = 0;

        for(int i = 0; i < hours.Length - 1; i++)    
        {
            for(int j = i + 1; j < hours.Length; j++)
            {
                if((hours[i] + hours[j]) % 24 == 0)
                    countDays++;
            }
        }

        return countDays;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountCompleteDayPairs([12,12,30,24,24]), 2),
            ResultTester.CheckResult<int>(solution.CountCompleteDayPairs([72,48,24,3]), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Pairs That Form a Complete Day I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}