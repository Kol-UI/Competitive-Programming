// Reverse a Substring
namespace CompetitiveProgramming.CodeForces.ReverseaSubstring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int position = -1;
        
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] < s[i - 1])
            {
                position = i + 1;
                break;
            }
        }
        
        if (position < 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine($"YES\n{position - 1} {position}");
        }
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
        StyleHelper.Title("Reverse a Substring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}