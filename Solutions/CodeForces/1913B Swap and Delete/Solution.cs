// Swap and Delete
namespace CompetitiveProgramming.CodeForces.SwapandDelete;
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
            int cnt0 = 0, cnt1 = 0;
            
            foreach (char c in s)
            {
                if (c == '0') cnt0++;
                else cnt1++;
            }
            
            int remaining = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1' && cnt0 > 0)
                {
                    cnt0--;
                }
                else if (s[i] == '0' && cnt1 > 0)
                {
                    cnt1--;
                }
                else
                {
                    remaining = s.Length - i;
                    break;
                }
            }
            
            Console.WriteLine(remaining);
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
        StyleHelper.Title("Swap and Delete");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}