// Left and Right Houses
namespace CompetitiveProgramming.CodeForces.LeftandRightHouses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

class Program
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine().Trim());
            string s = Console.ReadLine().Trim();

            long[] vl = new long[n + 1];
            long[] vr = new long[n + 1];

            for (int p = 1; p <= n; p++)
            {
                vl[p] = vl[p - 1] + (s[p - 1] == '0' ? 1 : 0);
            }

            for (int p = (int)n - 1; p >= 0; p--)
            {
                vr[p] = vr[p + 1] + (s[p] == '1' ? 1 : 0);
            }

            long idx = -1;
            float mindist = n + 7;

            for (int p = 0; p <= n; p++)
            {
                if (2 * vl[p] < p) continue;
                if (2 * vr[p] < (n - p)) continue;

                float dist = 0.5f * n - p;
                if (dist < 0) dist = -dist + 0.1f;
                if (dist < mindist)
                {
                    mindist = dist;
                    idx = p;
                }
            }

            Console.WriteLine(idx);
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
        StyleHelper.Title("Left and Right Houses");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}