// Maximum Cost Deletion
namespace CompetitiveProgramming.CodeForces.MaximumCostDeletion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long a = long.Parse(input[1]);
            long b = long.Parse(input[2]);
            string s = Console.ReadLine();
            
            long d = 0;
            for (int p = 1; p < s.Length; p++)
            {
                if (s[p] != s[p - 1]) d++;
            }
            
            long factor = b >= 0 ? n : (1 + (d + 1) / 2);
            Console.WriteLine(n * a + factor * b);
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
        StyleHelper.Title("Maximum Cost Deletion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}