// Mahmoud and Longest Uncommon Subsequence
namespace CompetitiveProgramming.CodeForces.MahmoudandLongestUncommonSubsequence;
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
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        
        if (s == t)
            Console.WriteLine("-1");
        else
            Console.WriteLine(s.Length > t.Length ? s.Length : t.Length);
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
        StyleHelper.Title("Mahmoud and Longest Uncommon Subsequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}