// Double-ended Strings
namespace CompetitiveProgramming.CodeForces.DoubleendedStrings;
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
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int max = 0;

            for (int p = 0; p < a.Length; p++)
            {
                for (int q = 0; q < b.Length; q++)
                {
                    for (int r = 0; p + r < a.Length && q + r < b.Length; r++)
                    {
                        if (a[p + r] == b[q + r])
                        {
                            max = Math.Max(max, r + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            int ans = a.Length + b.Length - 2 * max;
            Console.WriteLine(ans);
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
        StyleHelper.Title("Double-ended Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}