// Vauvau
namespace CompetitiveProgramming.Kattis.Vauvau;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Program
{
    static void Calc(long x, long a, long b, long c, long d)
    {
        int ans = 0;
        
        long k1 = x % (a + b);
        if (k1 != 0 && k1 <= a) ans++;
        
        long k2 = x % (c + d);
        if (k2 != 0 && k2 <= c) ans++;
        
        if (ans == 1)
            Console.WriteLine("one");
        else if (ans == 0)
            Console.WriteLine("none");
        else
            Console.WriteLine("both");
    }
    
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        long a = long.Parse(firstLine[0]);
        long b = long.Parse(firstLine[1]);
        long c = long.Parse(firstLine[2]);
        long d = long.Parse(firstLine[3]);
        
        long[] values = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        foreach (long x in values)
        {
            Calc(x, a, b, c, d);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vauvau");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}