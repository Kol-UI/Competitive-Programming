// Sum of Distances
namespace CompetitiveProgramming.LeetCode.SumofDistances;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long[] Distance(int[] nums)
    {
        int len = nums.Length;
        long[] res = new long[len];
        Dictionary<int, long[]> preSum = new(), tailSum = new();

        for (int i = 0; i < len; i++)
        {
            int cur = nums[i];
            long sum = 0;
            if (preSum.ContainsKey(cur))
            {
                sum = i * preSum[cur][1] - preSum[cur][0];
                preSum[cur][0] += i;
                preSum[cur][1]++;
            }
            else
                preSum.Add(cur, [i, 1]);

            res[i] = sum;
        }

        for (int i = len - 1; i >= 0; i--)
        {
            int cur = nums[i];
            long sum = 0;
            if (tailSum.ContainsKey(cur))
            {
                sum = tailSum[cur][0] - i * tailSum[cur][1];
                tailSum[cur][0] += i;
                tailSum[cur][1]++;
            }
            else
                tailSum.Add(cur, [i, 1]);

            res[i] += sum;
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Distances");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}