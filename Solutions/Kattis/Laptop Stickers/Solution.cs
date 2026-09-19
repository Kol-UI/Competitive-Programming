// Laptop Stickers
namespace CompetitiveProgramming.Kattis.LaptopStickers;
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
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] lhk = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int l = int.Parse(lhk[0]);
        int h = int.Parse(lhk[1]);
        int k = int.Parse(lhk[2]);

        char[][] res = new char[h][];
        for (int i = 0; i < h; i++)
        {
            res[i] = new char[l];
            for (int j = 0; j < l; j++)
            {
                res[i][j] = '_';
            }
        }

        for (int step = 0; step < k; step++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            int sj = int.Parse(parts[2]);
            int si = int.Parse(parts[3]);

            int maxI = Math.Min(si + n, h);
            int maxJ = Math.Min(sj + m, l);

            char fillChar = (char)('a' + step);

            for (int i = si; i < maxI; i++)
            {
                for (int j = sj; j < maxJ; j++)
                {
                    res[i][j] = fillChar;
                }
            }
        }

        for (int i = 0; i < h; i++)
        {
            Console.WriteLine(new string(res[i]));
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
        StyleHelper.Title("Laptop Stickers");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}