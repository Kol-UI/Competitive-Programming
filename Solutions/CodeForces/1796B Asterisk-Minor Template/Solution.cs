// Asterisk-Minor Template
namespace CompetitiveProgramming.CodeForces.AsteriskMinorTemplate;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string a = Console.ReadLine()!;
            string b = Console.ReadLine()!;
            
            if (a[0] == b[0])
            {
                Console.WriteLine($"YES\n{a[0]}*");
            }
            else if (a[a.Length - 1] == b[b.Length - 1])
            {
                Console.WriteLine($"YES\n*{a[a.Length - 1]}");
            }
            else
            {
                bool found = false;
                for (int p = 1; p < a.Length; p++)
                {
                    for (int q = 1; q < b.Length; q++)
                    {
                        if (a[p - 1] == b[q - 1] && a[p] == b[q])
                        {
                            Console.WriteLine($"YES\n*{a[p - 1]}{a[p]}*");
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
                
                if (!found)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Asterisk-Minor Template");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}