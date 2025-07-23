// Binary Cut
namespace CompetitiveProgramming.CodeForces.BinaryCut;
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
            string s = Console.ReadLine();
            int r = 0, d = 0;
            
            for (int p = 1; p < s.Length; p++)
            {
                if (s[p-1] == '0' && s[p] == '1') r++;
                if (s[p-1] == '1' && s[p] == '0') d++;
            }
            
            Console.WriteLine(r - (r > 0 ? 1 : 0) + d + 1);
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
        StyleHelper.Title("Binary Cut");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}