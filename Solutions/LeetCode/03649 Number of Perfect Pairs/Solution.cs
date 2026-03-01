// Number of Perfect Pairs
namespace CompetitiveProgramming.LeetCode.NumberofPerfectPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long PerfectPairs(int[] nums)
    {
        Dictionary<int, int> freq = new();
        foreach (int n in nums)
        {
            int absN = Math.Abs(n);
            if (!freq.ContainsKey(absN))
                freq.Add(absN, 0);

            freq[absN]++;
        }

        List<int> keys = freq.Keys.ToList();
        keys.Sort();
        for (int i = 1; i < keys.Count; i++)
        {
            freq[keys[i]] += freq[keys[i - 1]];
        }

        long res = 0;
        int left = 0;
        for (int i = 0; i < keys.Count; i++)
        {
            int curK = keys[i], curF = freq[curK] - (i > 0 ? freq[keys[i - 1]] : 0);
            if (curF > 1)
            {
                long tmp = ((long)curF * (curF - 1) / 2);
                res += tmp;
            }

            while (left < i && keys[left] * 2 < curK)
            {
                left++;
            }

            if (left < i)
            {
                int lowF = freq[keys[i - 1]] - (left > 0 ? freq[keys[left - 1]] : 0);
                res += (long)curF * lowF;
            }
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.PerfectPairs([0,1,2,3]), 2),
            ResultTester.CheckResult<long>(solution.PerfectPairs([-3,2,-1,4]), 4),
            ResultTester.CheckResult<long>(solution.PerfectPairs([1,10,100,1000]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Perfect Pairs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}