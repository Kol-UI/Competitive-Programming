// All Pairs Segments
namespace CompetitiveProgramming.CodeForces.AllPairsSegments;
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
            string[] nq = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nq[0]);
            long q = long.Parse(nq[1]);

            Dictionary<long, long> m = new Dictionary<long, long>();

            for (long p = 1; p <= n; p++)
            {
                long key = n * p - p * p + p - 1;
                m[key] = m.GetValueOrDefault(key, 0) + 1;
            }

            string[] aParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long prev = long.Parse(aParts[0]);

            for (long p = 1; p < n; p++)
            {
                long x = long.Parse(aParts[p]);
                long key = p * (n - p);
                m[key] = m.GetValueOrDefault(key, 0) + (x - prev - 1);
                prev = x;
            }

            string[] qParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<long> results = new List<long>();

            for (int i = 0; i < q; i++)
            {
                long k = long.Parse(qParts[i]);
                results.Add(m.TryGetValue(k, out long res) ? res : 0);
            }

            Console.WriteLine(string.Join(" ", results));
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
        StyleHelper.Title("All Pairs Segments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}