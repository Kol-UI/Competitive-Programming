// Superhero Transformation
namespace CompetitiveProgramming.CodeForces.SuperheroTransformation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        const string vw = "aeiou";
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        
        if (s.Length != t.Length)
        {
            Console.WriteLine("No");
            return;
        }
        
        string ans = "Yes";
        for (int p = 0; p < s.Length; p++)
        {
            bool fs = vw.IndexOf(s[p]) == -1;
            bool ft = vw.IndexOf(t[p]) == -1;
            if (fs != ft)
            {
                ans = "No";
                break;
            }
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Superhero Transformation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}