// MAX-MEX Cut
namespace CompetitiveProgramming.CodeForces.MAXMEXCut;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int idx = 0, cnt = 0;
            
            while (idx < n)
            {
                if (a[idx] != b[idx])
                {
                    cnt += 2;
                }
                else if (a[idx] == '1' && b[idx] == '1')
                {
                    if (idx + 1 < n && a[idx + 1] == '0' && b[idx + 1] == '0')
                    {
                        cnt += 2;
                        idx++;
                    }
                }
                else if (a[idx] == '0' && b[idx] == '0')
                {
                    if (idx + 1 < n && a[idx + 1] == '1' && b[idx + 1] == '1')
                    {
                        cnt += 2;
                        idx++;
                    }
                    else
                    {
                        cnt++;
                    }
                }
                
                idx++;
            }
            
            Console.WriteLine(cnt);
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
        StyleHelper.Title("MAX-MEX Cut");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}