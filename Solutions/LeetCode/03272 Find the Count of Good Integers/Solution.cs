// Find the Count of Good Integers
namespace CompetitiveProgramming.LeetCode.FindtheCountofGoodIntegers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountGoodIntegers(int n, int k)
    {
        var dict = new HashSet<string>();
        int baseVal = (int)Math.Pow(10, (n - 1) / 2);
        int skip = n & 1;
        for (int i = baseVal; i < baseVal * 10; i++)
        {
            string s = i.ToString();
            s += new string(s.Reverse().Skip(skip).ToArray());
            long palindromicInteger = long.Parse(s);
            if (palindromicInteger % k == 0)
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                dict.Add(new string(chars));
            }
        }

        long[] factorial = new long[n + 1];
        factorial[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial[i] = factorial[i - 1] * i;
        }

        long ans = 0;
        foreach (string s in dict)
        {
            int[] cnt = new int[10];
            foreach (char c in s)
            {
                cnt[c - '0']++;
            }
            long tot = (n - cnt[0]) * factorial[n - 1];
            foreach (int x in cnt)
            {
                tot /= factorial[x];
            }
            ans += tot;
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<double>(solution.CountGoodIntegers(3, 5), 27),
            ResultTester.CheckResult<double>(solution.CountGoodIntegers(5, 6), 2468),
            ResultTester.CheckResult<double>(solution.CountGoodIntegers(1, 4), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Count of Good Integers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}