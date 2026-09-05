// Odd Sum Segments
namespace CompetitiveProgramming.CodeForces.OddSumSegments;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string[] nk = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nk[0]);
            long k = long.Parse(nk[1]);

            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] a = new long[n];
            long sum = 0;

            for (int p = 0; p < n; p++)
            {
                a[p] = long.Parse(parts[p]);
                sum += a[p];
            }

            List<long> res = new List<long>();
            for (int p = 0; p < n; p++)
            {
                if (res.Count >= k - 1) break;
                if (a[p] % 2 != 0) res.Add(p + 1);
            }
            res.Add(n);

            if ((((k % 2) ^ (sum % 2)) != 0) || res.Count < k)
            {
                Console.WriteLine("NO");
                continue;
            }

            Console.WriteLine("YES");
            Console.WriteLine(string.Join(" ", res));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Odd Sum Segments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}