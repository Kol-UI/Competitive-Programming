// Yet Another Array Restoration
namespace CompetitiveProgramming.CodeForces.YetAnotherArrayRestoration;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Solve()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int x = int.Parse(input[1]);
        int y = int.Parse(input[2]);
        int st = 0, dif = int.MaxValue;
        
        for (int i = 1; i <= y; i++)
        {
            for (int j = 1; j < y; j++)
            {
                int cnt = 0;
                int nn = n;
                for (int k = i; k <= y && nn > 0; k += j, nn--)
                {
                    if (k == x || k == y) cnt++;
                    if (cnt == 2 && j < dif)
                    {
                        st = i;
                        dif = j;
                    }
                }
            }
        }
        
        for (int p = 0; p < n; p++)
        {
            Console.Write(st + (p == n - 1 ? "\n" : " "));
            st += dif;
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            Solve();
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
        StyleHelper.Title("Yet Another Array Restoration");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}