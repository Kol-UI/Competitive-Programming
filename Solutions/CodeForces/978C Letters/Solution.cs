// Letters
namespace CompetitiveProgramming.CodeForces.Letters;
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
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        long[] a = new long[n + 1];
        long[] cs = new long[n + 1];
        string[] rooms = Console.ReadLine().Split();
        for (int p = 1; p <= n; p++)
        {
            a[p] = long.Parse(rooms[p - 1]);
            cs[p] = cs[p - 1] + a[p];
        }

        string[] letters = Console.ReadLine().Split();
        for (int i = 0; i < m; i++)
        {
            long b = long.Parse(letters[i]);
            int left = 1, right = n, dorm = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (cs[mid] >= b)
                {
                    dorm = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            long room = b - cs[dorm - 1];
            Console.WriteLine($"{dorm} {room}");
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
        StyleHelper.Title("Letters");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}