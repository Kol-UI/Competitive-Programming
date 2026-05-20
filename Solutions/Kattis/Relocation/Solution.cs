// Relocation
namespace CompetitiveProgramming.Kattis.Relocation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        long n = long.Parse(firstLine[0]);
        long m = long.Parse(firstLine[1]);
        
        long[] v = new long[n + 1];
        string[] secondLine = Console.ReadLine().Split();
        for (long i = 1; i <= n; i++)
        {
            v[i] = long.Parse(secondLine[i - 1]);
        }
        
        for (long i = 0; i < m; i++)
        {
            string[] query = Console.ReadLine().Split();
            long t = long.Parse(query[0]);
            long a = long.Parse(query[1]);
            long b = long.Parse(query[2]);
            
            if (t == 1)
            {
                v[a] = b;
            }
            else
            {
                long diff = v[a] - v[b];
                if (diff < 0) diff = -diff;
                Console.WriteLine(diff);
            }
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Relocation");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}