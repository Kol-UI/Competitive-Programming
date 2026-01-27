// TMT Document
namespace CompetitiveProgramming.CodeForces.TMTDocument;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            bool possible = s.Length % 3 == 0;
            int tc = 0, mc = 0;
            
            for(int p = 0; p < s.Length && possible; p++)
            {
                if(s[p] == 'T') tc++;
                else if(s[p] == 'M')
                {
                    mc++;
                    if(tc < mc)
                    {
                        possible = false;
                        break;
                    }
                }
            }
            
            if(tc != 2 * mc) possible = false;
            tc = mc = 0;
            
            for(int p = s.Length - 1; p >= 0 && possible; p--)
            {
                if(s[p] == 'T') tc++;
                else if(s[p] == 'M')
                {
                    mc++;
                    if(tc < mc)
                    {
                        possible = false;
                        break;
                    }
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("TMT Document");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}