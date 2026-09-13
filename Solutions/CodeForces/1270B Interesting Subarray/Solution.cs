// Interesting Subarray
namespace CompetitiveProgramming.CodeForces.InterestingSubarray;
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
            long n = long.Parse(Console.ReadLine().Trim());
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long pos = 0;
            long prev = -1;

            for (int p = 0; p < n; p++)
            {
                long x = long.Parse(parts[p]);
                if (pos != 0) continue;
                if ((prev >= 0) && ((x > prev + 1) || (x < prev - 1)))
                {
                    pos = p;
                }
                prev = x;
            }

            Console.WriteLine(pos != 0 ? "YES" : "NO");
            if (pos != 0)
            {
                Console.WriteLine($"{pos} {pos + 1}");
            }
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
        StyleHelper.Title("Interesting Subarray");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}