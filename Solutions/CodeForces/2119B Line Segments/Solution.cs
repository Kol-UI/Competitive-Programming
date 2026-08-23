// Line Segments
namespace CompetitiveProgramming.CodeForces.LineSegments;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] firstLine = Console.ReadLine().Split();
            long sx = long.Parse(firstLine[0]);
            long sy = long.Parse(firstLine[1]);
            long tx = long.Parse(firstLine[2]);
            long ty = long.Parse(firstLine[3]);
            double[] a = new double[n + 1];
            string[] secondLine = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                a[p] = double.Parse(secondLine[p]);
            }
            a[n] = Math.Sqrt((sx - tx) * (sx - tx) + (sy - ty) * (sy - ty));
            Array.Sort(a);
            double s = a[a.Length - 1];
            for (long p = 0; p < n; p++)
            {
                s -= a[p];
            }
            Console.WriteLine(s > 0 ? "No" : "Yes");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Line Segments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}
