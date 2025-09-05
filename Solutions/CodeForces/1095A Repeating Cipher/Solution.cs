// Repeating Cipher
namespace CompetitiveProgramming.CodeForces.RepeatingCipher;
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
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        
        int r = 0, cnt = 0;
        string t = "";
        
        for (int p = 0; p < n; p++)
        {
            if (r == 0)
            {
                t += s[p];
                r = ++cnt;
            }
            else
            {
                r--;
            }
        }
        
        Console.WriteLine(t);
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
        StyleHelper.Title("Repeating Cipher");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}