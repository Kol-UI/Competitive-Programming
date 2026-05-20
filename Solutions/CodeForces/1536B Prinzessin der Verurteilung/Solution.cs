// Prinzessin der Verurteilung
namespace CompetitiveProgramming.CodeForces.PrinzessinderVerurteilung;
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
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            bool done = false;
            
            for (char p = 'a'; p <= 'z'; p++)
            {
                string tStr = p.ToString();
                if (!s.Contains(tStr))
                {
                    Console.WriteLine(tStr);
                    done = true;
                    break;
                }
            }

            for (char p = 'a'; p <= 'z' && !done; p++)
            {
                for (char q = 'a'; q <= 'z' && !done; q++)
                {
                    string tStr = p.ToString() + q;
                    if (!s.Contains(tStr))
                    {
                        Console.WriteLine(tStr);
                        done = true;
                    }
                }
            }

            for (char p = 'a'; p <= 'z' && !done; p++)
            {
                for (char q = 'a'; q <= 'z' && !done; q++)
                {
                    for (char r = 'a'; r <= 'z' && !done; r++)
                    {
                        string tStr = p.ToString() + q + r;
                        if (!s.Contains(tStr))
                        {
                            Console.WriteLine(tStr);
                            done = true;
                        }
                    }
                }
            }
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
        StyleHelper.Title("Prinzessin der Verurteilung");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}