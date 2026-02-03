// Count Good Meals
namespace CompetitiveProgramming.LeetCode.CountGoodMeals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8602
public class Solution
{
    public int CountPairs(int[] deliciousness)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int length = deliciousness.Length;
        int count = 0;
        int mod = 1000000007;

        foreach (var num in deliciousness)
        {
            int sum = 1;
            for (int i = 0; i <= 21; i++)
            {
                if (sum >= num && map.ContainsKey(sum - num))
                {
                    count += map[sum - num];
                    count %= mod;
                }
                sum *= 2;
            }
            map[num] = map.GetValueOrDefault(num) + 1;

        }
        return count;
    }
}

public class Solution2
{
    private int size = 21;
    private List<int>? sample;
    private void BuildTwoPow()
    {
        sample = new List<int>();
        int cur = 1, cnt = size;
        while (size >= 0)
        {
            size--;
            sample.Add(cur);
            cur *= 2;
        }
    }

    public int CountPairs(int[] deliciousness)
    {
        Dictionary<int, int> freq = new();
        long res = 0;
        int mod = (int)Math.Pow(10, 9) + 7;
        BuildTwoPow();

        foreach (int d in deliciousness)
        {
            freq.TryAdd(d, 0);
            freq[d]++;
        }

        foreach (var kvp in freq)
        {
            int first = kvp.Key, cntF = kvp.Value;
            for (int j = sample.Count - 1; j >= 0; j--)
            {
                int p = sample[j];
                if (p < 2 * first)
                    break;

                if (p == 2 * first)
                    res += (long)cntF * (cntF - 1) / 2;
                else
                {
                    if (freq.ContainsKey(p - first))
                    {
                        res += (long)cntF * freq[p - first];
                    }
                }

                res %= mod;
            }

        }

        return (int)res;
    }
}
#pragma warning restore CS8602

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        Solution2 solution2 = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountPairs([1,3,5,7,9]), 4),
            ResultTester.CheckResult<int>(solution.CountPairs([1,1,1,3,3,3,7]), 15),
            ResultTester.CheckResult<int>(solution2.CountPairs([1,3,5,7,9]), 4),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Good Meals");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}