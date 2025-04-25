// Manhattan Circle
namespace CompetitiveProgramming.CodeForces.ManhattanCircle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int tc = int.Parse(Console.ReadLine()!);
        while (tc-- > 0)
        {
            string[] nm = Console.ReadLine()!.Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            char[][] v = new char[n][];
            for (int i = 0; i < n; i++)
            {
                v[i] = Console.ReadLine()!.ToCharArray();
            }

            int row = -1;
            int mx = 0;
            for (int i = 0; i < n; i++)
            {
                int tmx = 0;
                for (int j = 0; j < m; j++)
                {
                    if (v[i][j] == '#') tmx++;
                }
                if (tmx > mx)
                {
                    mx = tmx;
                    row = i + 1;
                }
            }

            int col = -1;
            mx = 0;
            for (int j = 0; j < m; j++)
            {
                int tmx = 0;
                for (int i = 0; i < n; i++)
                {
                    if (v[i][j] == '#') tmx++;
                }
                if (tmx > mx)
                {
                    mx = tmx;
                    col = j + 1;
                }
            }
            Console.WriteLine($"{row} {col}");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Manhattan Circle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}