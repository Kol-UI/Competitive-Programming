// Super Ugly Number
namespace CompetitiveProgramming.LeetCode.SuperUglyNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        var heap = new PriorityQueue<int, int>();
        var prev = 1;
        for (int i = 1; i < n; ++i)
        {
            for (int p = 0; p < primes.Length; ++p)
            {
                long factor = (long)primes[p] * (long)prev;
                if (factor <= Int32.MaxValue)
                {
                    heap.Enqueue((int)factor, (int)factor);
                }
            }
            var next = heap.Dequeue();
            while (next == prev)
            {
                next = heap.Dequeue();
            }
            prev = next;
        }
        return prev;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Super Ugly Number");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}