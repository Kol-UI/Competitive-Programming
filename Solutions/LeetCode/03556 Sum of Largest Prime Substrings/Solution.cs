// Sum of Largest Prime Substrings
namespace CompetitiveProgramming.LeetCode.SumofLargestPrimeSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long SumOfLargestPrimes(string s)
    {
        int n = s.Length;
        HashSet<long> hs = new HashSet<long>();
        for (int i = 0; i < n; i++)
        {
            long num = 0;
            for (int j = i; j < n; j++)
            {
                num = (num * 10) + (long)(s[j] - '0');
                if (!hs.Contains(num) && isPrime(num))
                {
                    hs.Add(num);
                }
            }
        }

        List<long> res = new List<long>(hs.ToList());
        res.Sort();
        int nn = res.Count;
        long sum = 0;
        for (int i = nn - 1; i >= nn - 3 && i >= 0; i--)
        {
            sum = sum + res[i];
        }
        return sum;
    }

    public bool isPrime(long num)
    {
        if (num == 0 || num == 1)
            return false;
        long end = (long)Math.Sqrt(num);
        for (int i = 2; i <= end; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.SumOfLargestPrimes("12234"), 1469),
            ResultTester.CheckResult<long>(solution.SumOfLargestPrimes("111"), 11),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Largest Prime Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}