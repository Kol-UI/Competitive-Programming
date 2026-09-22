// Smallest Pair With Different Frequencies
namespace CompetitiveProgramming.LeetCode.SmallestPairWithDifferentFrequencies;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MinDistinctFreqPair(int[] nums)
    {
        int[] freq = new int[101];
        int minV = 101, maxV = 0;
        foreach(int n in nums)
        {
            freq[n]++;
            minV = Math.Min(minV, n);
            maxV = Math.Max(maxV, n);
        }

        int expF = freq[minV];
        int high = -1;
        for(int i = minV+1; i <= maxV; i++)
        {
            int f = freq[i];
            if(f == 0 || f == expF)
                continue;

            high = i;
            break;
        }

        if(high == -1)
            return [-1, -1];

        return [minV, high];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.MinDistinctFreqPair([1,1,2,2,3,4]), [1,3]),
            ResultTester.CheckResult<int[]>(solution.MinDistinctFreqPair([1,5]), [-1,-1]),
            ResultTester.CheckResult<int[]>(solution.MinDistinctFreqPair([7]), [-1,-1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Pair With Different Frequencies");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}