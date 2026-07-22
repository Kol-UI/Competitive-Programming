// Nezzar and Lucky Number
namespace CompetitiveProgramming.CodeForces.NezzarandLuckyNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            int q = int.Parse(firstLine[0]);
            int d = int.Parse(firstLine[1]);

            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < q; i++)
            {
                long x = long.Parse(numbers[i]);

                bool possible = false;
                
                if (x >= d * 10)
                {
                    possible = true;
                }
                else
                {
                    for (int j = 0; j < 10 && !possible; j++)
                    {
                        long num = d + 10 * j;
                        if (num <= x && (x - num) % d == 0)
                        {
                            possible = true;
                        }
                    }
                }

                Console.WriteLine(possible ? "YES" : "NO");
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Nezzar and Lucky Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}