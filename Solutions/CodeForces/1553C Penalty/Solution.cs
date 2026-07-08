// Penalty
namespace CompetitiveProgramming.CodeForces.Penalty;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            
            int ga = 0, gb = 0;
            int ua = 0, ub = 0;
            int ra = 5, rb = 5;
            int mlen = 10;
            
            for (long p = 0; p < s.Length; p++)
            {
                if (p % 2 == 0)
                {
                    ra--;
                    if (s[(int)p] == '1') ga++;
                    else if (s[(int)p] == '?') ua++;
                }
                else
                {
                    rb--;
                    if (s[(int)p] == '1') gb++;
                    else if (s[(int)p] == '?') ub++;
                }
                
                if (ga + ua > gb + rb)
                {
                    mlen = (int)p + 1;
                    break;
                }
                else if (gb + ub > ga + ra)
                {
                    mlen = (int)p + 1;
                    break;
                }
            }
            
            Console.WriteLine(mlen);
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
        StyleHelper.Title("Penalty");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}