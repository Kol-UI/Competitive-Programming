// Colorful Stamp
namespace CompetitiveProgramming.CodeForces.ColorfulStamp;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            bool red = false;
            bool blue = false;
            bool valid = true;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'W')
                {
                    if (red ^ blue) valid = false;
                    red = false;
                    blue = false;
                }
                else if (s[i] == 'R') red = true;
                else if (s[i] == 'B') blue = true;
            }
            
            if (red ^ blue) valid = false;
            Console.WriteLine(valid ? "YES" : "NO");
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
        StyleHelper.Title("Colorful Stamp");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}