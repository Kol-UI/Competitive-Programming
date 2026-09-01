// Slice to Survive
namespace CompetitiveProgramming.CodeForces.SlicetoSurvive;
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
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(parts[0]);
            long m = long.Parse(parts[1]);
            long a = long.Parse(parts[2]);
            long b = long.Parse(parts[3]);

            long resA = (long)Math.Ceiling(Math.Log2(Math.Min(a, n - a + 1))) + (long)Math.Ceiling(Math.Log2(m)) + 1;
            long resB = (long)Math.Ceiling(Math.Log2(n)) + (long)Math.Ceiling(Math.Log2(Math.Min(b, m - b + 1))) + 1;

            Console.WriteLine(Math.Min(resA, resB));
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
        StyleHelper.Title("Slice to Survive");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}