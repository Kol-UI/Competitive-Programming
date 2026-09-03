// Neighbor Grid
namespace CompetitiveProgramming.CodeForces.NeighborGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Text;

internal class Program
{
    private static void Main()
    {
        long t = ReadNextLong();
        StringBuilder sb = new();

        while (t-- > 0)
        {
            long n = ReadNextLong();
            long m = ReadNextLong();

            long[][] a = new long[n][];
            for (long row = 0; row < n; row++)
            {
                a[row] = new long[m];
                for (long col = 0; col < m; col++)
                {
                    a[row][col] = ReadNextLong();
                }
            }

            bool possible = true;
            for (long row = 0; row < n; row++)
            {
                if (!possible) break;
                for (long col = 0; col < m; col++)
                {
                    long d = (row > 0 ? 1 : 0) + (col > 0 ? 1 : 0) + (row + 1 < n ? 1 : 0) + (col + 1 < m ? 1 : 0);
                    if (a[row][col] > d)
                    {
                        possible = false;
                        break;
                    }
                    else
                    {
                        a[row][col] = d;
                    }
                }
            }

            if (possible)
            {
                sb.AppendLine("YES");
                for (long row = 0; row < n; row++)
                {
                    for (long col = 0; col < m; col++)
                    {
                        sb.Append(a[row][col]).Append(' ');
                    }
                    sb.AppendLine();
                }
            }
            else
            {
                sb.AppendLine("NO");
            }
        }

        Console.Write(sb.ToString());
    }

    private static long ReadNextLong()
    {
        int ch;
        while ((ch = Console.Read()) != -1 && ch <= 32) ;

        if (ch == -1) return 0;

        long sign = 1;
        if (ch == '-')
        {
            sign = -1;
            ch = Console.Read();
        }

        long res = 0;
        while (ch >= '0' && ch <= '9')
        {
            res = res * 10 + (ch - '0');
            ch = Console.Read();
        }

        return res * sign;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Neighbor Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}