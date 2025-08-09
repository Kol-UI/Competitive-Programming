// Progressive Square
namespace CompetitiveProgramming.CodeForces.ProgressiveSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0], c = input[1], d = input[2];
            
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(b);
            
            long[] v = new long[n * n];
            int index = 0;
            for (int row = 0; row < n; row++)
                for (int col = 0; col < n; col++)
                    v[index++] = row * c + col * d;
            Array.Sort(v);
            
            bool ans = true;
            for (int p = 0; ans && p < n * n; p++)
                if (b[0] + v[p] != b[p]) ans = false;
            
            Console.WriteLine(ans ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Progressive Square");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}