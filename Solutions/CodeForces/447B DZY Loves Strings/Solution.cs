// DZY Loves Strings
namespace CompetitiveProgramming.CodeForces.DZYLovesStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int additional = int.Parse(Console.ReadLine());
        
        long[] weights = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long maxWeight = weights.Max();
        
        long total = 0;
        for (int i = 0; i < text.Length; i++)
        {
            total += (i + 1) * weights[text[i] - 'a'];
        }
        
        for (int i = 0; i < additional; i++)
        {
            total += (text.Length + i + 1) * maxWeight;
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("DZY Loves Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}