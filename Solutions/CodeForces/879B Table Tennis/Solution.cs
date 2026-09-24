// Table Tennis
namespace CompetitiveProgramming.CodeForces.TableTennis;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string nkLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nkLine)) return;

        string[] nkParts = nkLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long n = long.Parse(nkParts[0]);
        long k = long.Parse(nkParts[1]);
        k = k < n ? k : n;

        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        while (parts.Length < n)
        {
            string[] nextParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] temp = new string[parts.Length + nextParts.Length];
            parts.CopyTo(temp, 0);
            nextParts.CopyTo(temp, parts.Length);
            parts = temp;
        }

        long w = long.Parse(parts[0]);
        long count = 0;

        for (int p = 1; p < n; p++)
        {
            long x = long.Parse(parts[p]);
            if (x > w)
            {
                long u = x;
                x = w;
                w = u;
                count = 1;
            }
            else
            {
                ++count;
                if (count >= k)
                {
                    break;
                }
            }
        }

        Console.WriteLine(w);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Table Tennis");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}