// StORage room
namespace CompetitiveProgramming.CodeForces.StORageroom;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string nLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nLine)) nLine = Console.ReadLine();
            int n = int.Parse(nLine.Trim());

            long[][] M = new long[n][];
            long[] a = new long[n];

            for (int row = 0; row < n; row++)
            {
                M[row] = new long[n];
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                while (parts.Length < n)
                {
                    string[] nextParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string[] temp = new string[parts.Length + nextParts.Length];
                    parts.CopyTo(temp, 0);
                    nextParts.CopyTo(temp, parts.Length);
                    parts = temp;
                }

                long tmp = (1L << 30) - 1;
                for (int col = 0; col < n; col++)
                {
                    long x = long.Parse(parts[col]);
                    M[row][col] = x;
                    if (col == row) continue;
                    tmp &= x;
                }
                a[row] = tmp;
            }

            bool possible = true;
            for (int row = 0; possible && row < n; row++)
            {
                for (int col = 0; possible && col < n; col++)
                {
                    if (row == col) continue;
                    if ((a[row] | a[col]) != M[row][col])
                    {
                        possible = false;
                    }
                }
            }

            if (possible)
            {
                Console.WriteLine("YES");
                Console.WriteLine(string.Join(" ", a));
            }
            else
            {
                Console.WriteLine("NO");
            }
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
        StyleHelper.Title("StORage room");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}