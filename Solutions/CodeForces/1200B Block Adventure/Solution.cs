// Block Adventure
namespace CompetitiveProgramming.CodeForces.BlockAdventure;
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
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string line = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line)) line = Console.ReadLine();

            string[] nmk = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(nmk[0]);
            long m = long.Parse(nmk[1]);
            long k = long.Parse(nmk[2]);

            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (parts.Length < n)
            {
                string[] nextParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] temp = new string[parts.Length + nextParts.Length];
                parts.CopyTo(temp, 0);
                nextParts.CopyTo(temp, parts.Length);
                parts = temp;
            }

            long prev = long.Parse(parts[0]);
            bool possible = true;

            for (int p = 1; p < n; p++)
            {
                long x = long.Parse(parts[p]);
                if (prev + m + k < x)
                {
                    possible = false;
                }
                else
                {
                    long target = x > k ? x - k : 0;
                    m -= (target - prev);
                }
                prev = x;
            }

            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Block Adventure");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}